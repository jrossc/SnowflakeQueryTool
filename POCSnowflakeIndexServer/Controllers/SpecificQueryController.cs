using Microsoft.Extensions.DependencyInjection;
using POCSnowflakeIndexServer.DAL;
using POCSnowflakeIndexServer.Helpers;
using POCSnowflakeIndexServer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCSnowflakeIndexServer.Controllers
{
    class SpecificQueryController : ISpecificQueryService
    {
        public readonly string connectionString = ConnectionStringBuilder.FinalConnectionString;
        public async Task<object> Get()
        {

            using (DataAccess da = new SnowflakeDataAccess())
            { 
                string query = "";
                if (!String.IsNullOrWhiteSpace(ConnectionStringBuilder.Database))
                {
                    query = "show columns in database " + ConnectionStringBuilder.Database;
                }
                else
                {
                    query = "show columns in account";
                }
                da.ConnectionString = connectionString;
                string sampledata = await Task.Run(() => da.GetDataJSON(query)).ConfigureAwait(false);
                sampledata.Replace(@"\", " ");

                return sampledata;
            }
        } 
    }
}

