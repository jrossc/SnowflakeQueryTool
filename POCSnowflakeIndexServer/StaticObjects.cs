using POCSnowflakeIndexServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCSnowflakeIndexServer
{
    public static class StaticObjects
    {
        public static SchemaListModels[] schemaListModelList { get; set; }
        public static string SelectedDatabase { get; set; }
    }
}
