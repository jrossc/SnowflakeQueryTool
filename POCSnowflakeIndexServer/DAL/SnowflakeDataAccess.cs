using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using POCSnowflakeIndexServer.Helpers;
using POCSnowflakeIndexServer.Interfaces;
using Snowflake.Data.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace POCSnowflakeIndexServer.DAL
{
    public class SnowflakeDataAccess : DataAccess
    {
        public override string ConnectionString { get; set; }
        private IDbConnection snowflakeDbConnection;
        private IDbCommand snowflakeDbCommand;
        private IDataReader snowflakeDbDataReader;
        private IJSONConverterService _jsonService;

        public SnowflakeDataAccess()
        {
            snowflakeDbConnection = new SnowflakeDbConnection();
            snowflakeDbCommand = snowflakeDbConnection.CreateCommand();
            _jsonService = new JSONConverterHelper();
        }

        public SnowflakeDataAccess(IJSONConverterService jSONConverterService) =>
            _jsonService = jSONConverterService;    

        public SnowflakeDbParameter Parameters(string name)
        {
            return (SnowflakeDbParameter)snowflakeDbCommand.Parameters[name];
        }

        public override void AddParameter(string name, DbType type, object data)
        {
            var param = snowflakeDbCommand.CreateParameter();
            param.ParameterName = name;
            param.Value = data;
            param.DbType = type;
            snowflakeDbCommand.Parameters.Add(param);
        }

        public override string TestConnection()
        {
            try
            {
                snowflakeDbConnection.ConnectionString = ConnectionString;
                snowflakeDbConnection.Open();
                snowflakeDbConnection.Close();
                ConnectForm.tested = true;
                return "Connection Succeeded";
            }
            catch (Exception ex)
            {
                ConnectForm.tested = false;
                return "Failed to establish a connection: " + ex.Message + Environment.NewLine + Environment.NewLine + ex.InnerException + Environment.NewLine + Environment.NewLine + ex.StackTrace;
            }

        }

        public override DataTable GetData(string command)
        {

            snowflakeDbConnection.ConnectionString = ConnectionString;
            snowflakeDbConnection.Open();

            snowflakeDbCommand.CommandText = command;
            snowflakeDbDataReader = snowflakeDbCommand.ExecuteReader();

            var tb = new DataTable();
            tb.Load(snowflakeDbDataReader);
            int count = tb.Rows.Count;

            snowflakeDbConnection.Close();
            return tb;
        }

        public override DataTable GetDataProgress(string command, IProgress<int> progress)
        {

            snowflakeDbConnection.ConnectionString = ConnectionString;
            snowflakeDbConnection.Open();

            snowflakeDbCommand.CommandText = command;
            snowflakeDbDataReader = snowflakeDbCommand.ExecuteReader();
            int rows = 0;

            while (snowflakeDbDataReader.Read())
            {
                rows++;
            }

            //need to close and re-execute again after the while loop for getting rows
            snowflakeDbDataReader.Close();
            snowflakeDbDataReader = snowflakeDbCommand.ExecuteReader();

            //print columns
            var tb = new DataTable();
            for (int i = 0; i < snowflakeDbDataReader.FieldCount; i++)
            {
                tb.Columns.Add(snowflakeDbDataReader.GetName(i));
            }

            //print and add row
            while (snowflakeDbDataReader.Read())
            {
                DataRow tempRow = tb.NewRow();
                for (int i = 0; i < snowflakeDbDataReader.FieldCount; i++)
                {
                    tempRow[i] = snowflakeDbDataReader[i];
                }
                tb.Rows.Add(tempRow);

                if (progress != null)
                    progress.Report((tb.Rows.Count / rows) * 100);
            }

            snowflakeDbConnection.Close();
            return tb;
        }

        public override string GetDataJSON(string command)
        {

            try
            {
                snowflakeDbConnection.ConnectionString = ConnectionString;
                snowflakeDbConnection.Open();

                snowflakeDbCommand.CommandText = command;
                snowflakeDbDataReader = snowflakeDbCommand.ExecuteReader();

                var tb = new DataTable();
                tb.Load(snowflakeDbDataReader);
                int count = tb.Rows.Count;

                string result = _jsonService.SerializeObject(tb);

                snowflakeDbConnection.Close();
                return result;
            }
            catch (Exception ex)
            {
                return "Failed to get data: " + ex.Message + Environment.NewLine + Environment.NewLine + ex.InnerException + Environment.NewLine + Environment.NewLine + ex.StackTrace;
            }
        }

        public override async Task<string> TestConnectionAsync()
        {
            string str = await Task.Run(() => TestConnection()).ConfigureAwait(false);
            return str;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
               // _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }



        #region IDisposable members

        public override void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing)
                {
                    if (snowflakeDbDataReader != null) snowflakeDbDataReader.Dispose();
                    if (snowflakeDbCommand != null) snowflakeDbCommand.Dispose();
                    if (snowflakeDbConnection != null) snowflakeDbConnection.Dispose();
                }
            }
            finally
            {
                snowflakeDbDataReader = null;
                snowflakeDbCommand = null;
                snowflakeDbConnection = null;
            }
        }

        #endregion
    }
}
