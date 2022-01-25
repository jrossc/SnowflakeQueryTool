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
    public class QueryAsParameterController : IQueryAsParameterService
    {
        public readonly string connectionString = ConnectionStringBuilder.FinalConnectionString;

        public async Task<object> Get(string command)
        {
            using (DataAccess da = new SnowflakeDataAccess())
            {
                da.ConnectionString = connectionString;
                var res = await Task.Run(() => da.GetData(command)).ConfigureAwait(false);
                return res;
            }
        }

        public async Task<object> GetWithProgress(string command, IProgress<int> progress)
        {
            using (DataAccess da = new SnowflakeDataAccess())
            {
                da.ConnectionString = connectionString;
                var res = await Task.Run(() => da.GetDataProgress(command, progress)).ConfigureAwait(false);
                return res;
            }
        }

    }
}
