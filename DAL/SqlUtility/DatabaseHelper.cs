using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace DAL.SqlUtility
{
    public abstract class DatabaseHelper:DbUtils
    {
        public DatabaseHelper()
        {
            GetConnection();
        }
        private static void PreparedCommand(MySqlCommand cmd, MySqlConnection con, MySqlTransaction trans,
            string cmText, MySqlParameter[] cmdParameters)
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                cmd.Connection = con;
                cmd.CommandText = cmText;
                if (trans != null)
                {
                    cmd.Transaction = trans;
                }

                cmd.CommandType = CommandType.Text;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                if (cmdParameters != null)
                {
                    foreach (MySqlParameter parameter in cmdParameters)
                    {
                        if ((parameter.Direction == ParameterDirection.InputOutput ||
                             parameter.Direction == ParameterDirection.Input) && parameter.Value == null)
                        {
                            parameter.Value = DBNull.Value;
                        }

                        cmd.Parameters.Add(parameter);
                    }
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static DataSet Query(string sql, params  MySqlParameter[] cmdSqlParameters)
        {

            using (GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                PreparedCommand(cmd, GetConnection(), null, sql, cmdSqlParameters);
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();

                    if (da.SelectCommand.Connection == null)
                    {
                        //return null;
                    }
                    else
                    {
                        da.Fill(ds, "ds");
                        cmd.Parameters.Clear();

                    }


                    return ds;
                }
            }
        }

        public static void Query1(string sql, params MySqlParameter[] cmdSqlParameters)
        {
            using (GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                PreparedCommand(cmd, GetConnection(), null, sql, cmdSqlParameters);
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    try
                    {
                        da.Fill(ds, "ds");
                        cmd.Parameters.Clear();
                    }
                    catch (MySqlException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }
    }
}
