
using System;
using System.Collections.Generic;
using System.Data;
using DAL.SqlUtility;
using MySql.Data.MySqlClient;
using Models;

namespace DAL
{
    public class UserDal
    {

        public List<UserModel> GetAll()
        {
            List<UserModel> result = new List<UserModel>();
            string sql = "select pmName from user";
            DataSet ds = DatabaseHelper.Query(sql);

            if (ds.Tables.Count == 0)
            {
                return result;
            }

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                result.Add(DataRowModel(row));
            }

            return result;
        }

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

        public UserModel DataRowModel(DataRow row)
        {
            UserModel model = new UserModel();
            if (row == null) return model;

            if (row["pmName"] != null && row["pmName"].ToString() != String.Empty)
            {
                model.PM = row["pmName"].ToString();
            }

            return model;
        }
    }
}
