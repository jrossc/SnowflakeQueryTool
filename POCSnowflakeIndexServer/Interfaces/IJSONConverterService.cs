using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCSnowflakeIndexServer.Interfaces
{
    public interface IJSONConverterService
    {
        string SerializeObject(object obj);
    }
}
