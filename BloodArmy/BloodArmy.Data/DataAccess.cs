using System;
using System.Data.SqlClient;

namespace BloodArmy.Data
{
    public static class DataAccess
    {
        static SqlConnection conn;

        static SqlConnection Connection
        {
            get
            {
                conn = new SqlConnection(BloodArmy.Data.Properties.Settings.Default.ConnectionString);
                conn.Open();
                return conn;
            }
        }


        public static int ExecuteQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, Connection);
            return cmd.ExecuteNonQuery();
        }

        public static SqlDataReader GetData(string query)
        {
            SqlCommand cmd = new SqlCommand(query, Connection);
            return cmd.ExecuteReader();
        }

        public static SqlDataAdapter GetLoginData(string query)
        {
            SqlCommand cmd = new SqlCommand(query, Connection);
            SqlDataAdapter adapt= new SqlDataAdapter(cmd);
            return adapt;
        }
    }
}
