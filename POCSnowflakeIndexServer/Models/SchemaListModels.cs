using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCSnowflakeIndexServer.Models
{
    public class SchemaListModels
    {
        public string database_name { get; set; }
        public string schema_name { get; set; }
        public string table_name { get; set; }
        public string column_name { get; set; }
        public string data_type { get; set; }
    }


    public class DataType
    {
        public string Type { get; set; }
        public string Length { get; set; }
        public string byteLength { get; set; }
        public bool nullable { get; set; }
    }
}
