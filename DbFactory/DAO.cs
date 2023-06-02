using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Web;
using System.Web.UI.WebControls;

using System.Threading.Tasks;

namespace DbFactory
{
    public class DAO
    {
        public static string GetConnectionString(string dbName, string name="Connection String")
        {
            var conString = ConfigurationManager.ConnectionStrings["name"].ConnectionString;
            var builder = new SqlConnectionStringBuilder(conString);
            {
               // InitialCatalog = dbName
            };
            return builder.ConnectionString;       
            
            
        }

        public static bool LoadList(DropDownList ddl, string TableName, string TextField, string ValueField)
        {
            var conString = "Data Source = XCOGITBOOK\\SQLSERVER; Initial Catalog = mgtPortal; User Id=sa; Password = D$5564xcog!";
            var sql = "SELECT " + TextField + ", " + ValueField + " FROM " + TableName;
            var dt = new DataTable();
            using (var con = new SqlConnection(conString))
            {
                con.Open();
                using (var cmd = new SqlCommand(sql, con))
                {
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            ddl.DataSource = dt;
            ddl.DataTextField = TextField;
            ddl.DataValueField = ValueField;
            ddl.DataBind();
            return true;
        }

        public static bool LoadList(DropDownList ddl, string query)
        {
            var conString = "Data Source = XCOGITBOOK\\SQLSERVER; Initial Catalog = mgtPortal; User Id=sa; Password = D$5564xcog!";
            var sql = query;
            var dt = new DataTable();
            using (var con = new SqlConnection(conString))
            {
                con.Open();
                using (var cmd = new SqlCommand(sql, con))
                {
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            ddl.DataSource = dt;            
            ddl.DataBind();
            return true;
        }
    }
}
