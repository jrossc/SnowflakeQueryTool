using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCSnowflakeIndexServer.Interfaces
{
    public interface IQueryAsParameterService
    {
        Task<object> Get(string command);
        Task<object> GetWithProgress(string command, IProgress<int> progress);
    }
}
