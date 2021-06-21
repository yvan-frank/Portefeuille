
using DAL.SqlUtility;
using MySql.Data.MySqlClient;
using Models;

namespace DAL
{
    public class UserDal
    {
        public bool Login(string id, string password)
        {
            string sql = "select * from admin";

            UserModel model = new UserModel();
            MySqlDataReader reader = DatabaseHelper.ExecuteDataReader(sql);

            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    model.Username = reader.GetString(1);
                    model.Password = reader.GetString(2);
                }
            }

            if (id.Equals(model.Username) && password.Equals(model.Password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
