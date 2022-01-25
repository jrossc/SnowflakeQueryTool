using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCSnowflakeIndexServer.Interfaces
{
    public interface ISpecificQueryService
    {
        Task<object> Get();
    }
}
