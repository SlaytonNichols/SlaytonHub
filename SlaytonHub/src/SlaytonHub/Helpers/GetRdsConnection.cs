using System;
using System.Configuration;
using Amazon.RDS;

namespace SlaytonHub.Helpers
{
    public static class GetRdsConnection
    {
        public static string GetRdsConnectionString()
        {
            var dbname = Environment.GetEnvironmentVariable("DatabaseName");
            if (string.IsNullOrEmpty(dbname)) return null;
            var username = Environment.GetEnvironmentVariable("DBUserName");
            var hostname = Environment.GetEnvironmentVariable("DBEndPoint");
            var password = Environment.GetEnvironmentVariable("DBPass");
            

            return "Data Source=" + hostname + ";Initial Catalog=" + dbname + ";User ID=" + username + ";Password=" + password + ";";
        }
    }
}