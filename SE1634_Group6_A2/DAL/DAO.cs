using assignment2prn.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace SE1634_Windows.DAL
{
    internal class DAO
    {
        string strConnect;
        

        public DAO()
        {
            var conf = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            strConnect = conf.GetConnectionString("DbConnection");
        }

        public DataTable GetDataTable (string sql)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(strConnect);

                SqlCommand cmd = new SqlCommand(sql);
                cmd.Connection = sqlConnection;

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public DataTable GetDataTable2(SqlCommand sql)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(strConnect);

                
                sql.Connection = sqlConnection;

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = sql;
                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public bool Update(SqlCommand cmd)
        {
            try
            {
                SqlConnection conn = new SqlConnection(strConnect);
                cmd.Connection = conn;

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
