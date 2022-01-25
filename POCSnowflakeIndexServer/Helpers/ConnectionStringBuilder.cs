using POCSnowflakeIndexServer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace POCSnowflakeIndexServer.Helpers
{
     public static class ConnectionStringBuilder
    {
        public static int AuthType { get; set; }
        public static string Account { get; set; }
        public static string Host { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string Database { get; set; }
        public static string Schema { get; set; }
        public static string Warehouse { get; set; }

        public static string FinalConnectionString;

        public static void BuildString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(FormAuthenticatorString(AuthType));
 

            if (!String.IsNullOrWhiteSpace(Host))
            {
                sb.Append("HOST=" + Host + ";");
            }

            string[] accountArray = Host.Split('.');
            Account = accountArray[0];

            sb.Append("ACCOUNT=" + Account + ";");
            sb.Append("USER=" + Username + ";");
            sb.Append("PASSWORD=" + Password + ";");

            if (!String.IsNullOrWhiteSpace(Database))
                sb.Append("db=" + Database + ";");

            if (!String.IsNullOrWhiteSpace(Schema))
                sb.Append("schema=" + Schema + ";");

            if (!String.IsNullOrWhiteSpace(Warehouse))
                sb.Append("Warehouse=" + Warehouse + ";");

            sb.Append("ROLE=ACCOUNTADMIN;CONNECTION_TIMEOUT=60");
            

            if (sb.ToString().Last() == ';')
            {
                sb.Remove(sb.Length - 1, 1);
            }

            FinalConnectionString = sb.ToString();
        }

       private static string FormAuthenticatorString(int selectedIndex)
        {
            string result = "";
            if ((AuthTypes)selectedIndex == AuthTypes.UnPW)
                result = "AUTHENTICATOR=snowflake;";

            return result;
        }

       
    }

    public enum AuthTypes
    {
        UnPW = 0,
        SSO = 1
    }
}
