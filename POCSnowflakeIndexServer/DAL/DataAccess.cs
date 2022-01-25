using Snowflake.Data.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Reflection;
using System.Threading;
using Microsoft.Extensions.Hosting;

namespace POCSnowflakeIndexServer.DAL
{
   public abstract class DataAccess : BackgroundService, IDisposable
    {

        public virtual string ConnectionString { get; set; }
        private IDbConnection snowflakeDbConnection;
        private IDbCommand snowflakeDbCommand;
        private IDataReader snowflakeDbDataReader;
      

        public DataAccess()
        {
        }

        public abstract void AddParameter(string name, DbType type, object data);
        public abstract string TestConnection();
        public abstract DataTable GetData(string command); 
        public abstract DataTable GetDataProgress(string command, IProgress<int> progress);
        public abstract string GetDataJSON(string command);
        public abstract Task<string> TestConnectionAsync();

        #region IDisposable members

        public abstract void Dispose();
        //{
        //Dispose(true);
        //GC.SuppressFinalize(this);
        //  }

        protected abstract void Dispose(bool disposing);
        //{
            //try
            //{
            //    if (disposing)
            //    {
            //        if (snowflakeDbDataReader != null) snowflakeDbDataReader.Dispose();
            //        if (snowflakeDbCommand != null) snowflakeDbCommand.Dispose();
            //        if (snowflakeDbConnection != null) snowflakeDbConnection.Dispose();
            //    }
            //}
            //finally
            //{
            //    snowflakeDbDataReader = null;
            //    snowflakeDbCommand = null;
            //    snowflakeDbConnection = null;
            //}
       // }

        #endregion
    }



}
