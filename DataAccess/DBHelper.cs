using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace PRG262_Bob_s_Gym.DataAccess
{
    public static class DBHelper
    {

        private static readonly string connectionString = @"Server =(LocalDB); Database=(dbHere); Integrated Security=True;";

        /// <summary>
        /// returns an open SQL connection
        /// </summary>

        public static SqlConnection CreateConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }
        /// <summary>
        /// Executes a non-query command.
        /// </summary>
        public static int ExecuteNonQ(string commandText, CommandType cmdType = CommandType.Text, params SqlParameter[] parameters)
        {
            using (SqlConnection con = CreateConnection())
            using (SqlCommand sqlCmd = new SqlCommand(commandText, con))
            {
                sqlCmd.CommandType = cmdType;
                if(parameters != null)
                {
                    sqlCmd.Parameters.AddRange(parameters);
                }
                return sqlCmd.ExecuteNonQuery();
            }

        }

        /// <summary>
        /// returns data using SqlDataReader
        /// </summary>
        /// <returns></returns>
        public static SqlDataReader Read(string commandText, CommandType commandType = CommandType.Text, params SqlParameter[] parameters)
        {
            SqlConnection conn = CreateConnection();
            SqlCommand sqlcmd = new SqlCommand(commandText, conn);
            sqlcmd.CommandType = commandType;
            if(parameters != null)
            {
                sqlcmd.Parameters.AddRange(parameters);
            }

            return sqlcmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        /// <summary>
        /// Returns a single value
        /// 
        
        /// </summary>
        /// 
        public static object ExecuteScalarVal(string cmdText, CommandType commandType = CommandType.Text, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = CreateConnection())
            using (SqlCommand cmd = new SqlCommand(cmdText, connection))
            {
                cmd.CommandType = commandType;
                if(parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                return cmd.ExecuteScalar();
            }
        }

        /// <summary>
        /// Fills a DataTable (simplifying some of the code)
        /// 
        /// 
        /// </summary>
        /// 
        public static DataTable ExecDataTable(string cmdText, CommandType commandType = CommandType.Text, params SqlParameter[] parameters)
        {
            using (SqlConnection con = CreateConnection())
            using (SqlCommand cmd = new SqlCommand(cmdText, con))
            {
                cmd.CommandType = commandType;
                if(parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                using(SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }

            }

        }

        public static SqlConnection CloseConnection(SqlConnection conn)
        {
            conn.Close();
            return conn;
        }
    }
}
