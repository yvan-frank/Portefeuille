using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace DAL.SqlUtility
{
    public abstract class DatabaseHelper:DbUtils
    {

        public static int ExecuteSql(string sql, params MySqlParameter[] cmSqlParameters)
        {
            using (var con = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    try
                    {
                        PreparedCommand(cmd, GetConnection(), null, sql, cmSqlParameters);
                        int rows = cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        return rows;
                    }
                    catch (MySqlException e)
                    {
                        throw e;
                    }
                }
            }
        }


        public static int ExecuteSqlCount(string sql)
        {
            using (var con = GetConnection())
            {
                int val;
                try
                {
                    using (MySqlCommand command = new MySqlCommand())
                    {
                        con.Open();
                        command.Connection = con;
                        command.CommandText = sql;
                    
                        val = Convert.ToInt32(command.ExecuteScalar());
                        command.Dispose();
                        con.Close();
                    }

                    return val;
                }
                catch
                {
                    return 0;
                }

            }
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
                con.Close();
                throw e;
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

        public static MySqlDataReader ExecuteDataReader(string sql, params MySqlParameter[] cmdParameter)
        {
            try
            {
                using (GetConnection())
                {
                
                    MySqlCommand cmd = new MySqlCommand();
                    PreparedCommand(cmd, GetConnection(), null, sql, cmdParameter);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    return reader;

                }
            }
            catch (MySqlException e)
            {
                GetConnection().Close();
                throw e;
            }
        }

        public static bool Exists(string sql, params MySqlParameter[] cmdParameters)
        {
            object obj = GetSingle(sql, cmdParameters);
            int cmdResult;
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
            {
                cmdResult = 0;
            }
            else
            {
                cmdResult = int.Parse(obj.ToString());
            }

            if (cmdResult == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public static object GetSingle(string sqlString, params MySqlParameter[] cmdParameters)
        {
            using (GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(sqlString, GetConnection()))
                {
                    try
                    {
                        GetConnection().Open();
                        object obj = cmd.ExecuteScalar();
                        if (Object.Equals(obj, null) || Object.Equals(obj, DBNull.Value))
                        {
                            return null;
                        }
                        else
                        {
                            return obj;
                        }
                    }
                    catch (Exception e)
                    {
                        GetConnection().Close();
                        throw e;
                    }
                }
            }
        }


    }
}
