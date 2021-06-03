using MySql.Data.MySqlClient;
namespace DAL.SqlUtility
{
    public class DbUtils
    {
        //private string  Host = "127.0.0.1";
        //private int Port = 3306;
        //private string DatabaseName = "testportfolio";
        //private string Username = "root";
        //private string Password = "";

        private static string _connectionString;

        //protected DbUtils()
        //{
        //    _connectionString = "SERVER = "+Host +";DATABASE = " + DatabaseName + ";port = " + Port +";UID = " + Username + ";pwd = " + Password;
        //}

        public static MySqlConnection GetConnection()
        {
            _connectionString = "SERVER = 127.0.0.1;DATABASE = portfolio;port =3306;UID = root;pwd = ";

            return new MySqlConnection(_connectionString);
        }
    }
}
