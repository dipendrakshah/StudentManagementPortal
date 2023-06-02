using Microsoft.Data.SqlClient;
using System.Configuration;
namespace DbFactory
{
    public class DAO
    {
        public static string GetConnectionString(string dbName, string name="Connection String")
        {
            var conString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            var builder = new SqlConnectionStringBuilder(conString)
            {
                InitialCatalog = dbName

            };
            return builder.ConnectionString;

        }

    }
}