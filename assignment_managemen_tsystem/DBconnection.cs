using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace assignment_managemen_tsystem
{
   public class DBconnection

    {
        public static SqlConnection DBConnect()
        {
            var conn = new SqlConnection();
            ////conn.conection string=data source //
            conn.ConnectionString = "Data Source=DESKTOP-2ILOCVB\\SQLEXPRESS;Initial Catalog=AssignmentDB;Integrated Security=True";
            if (conn.State != ConnectionState.Open) 
            {
                conn.Open();
            }
            return conn;//h:\cc#.net project\warehouse\warehouse
        }
        public static DataTable GetTableQuery(string SqlQuery)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = DBConnect();
                command.CommandText = SqlQuery;
                command.CommandType = CommandType.Text;
                SqlDataAdapter adapter =
                    new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }

            }
        public static void ExecuteNonQuery(string SqlQuery)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = DBConnect();
                command.CommandText = SqlQuery;
                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
           
           
        }

        }
    }

