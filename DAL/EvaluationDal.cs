
using System;
using System.Data;
using DAL.SqlUtility;
using Models;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class EvaluationDal
    {
        public int Insert(EvaluationModel evaluation)
        {
            string sql = "insert into evaluation (score) values(@score)";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@score", MySqlDbType.Int32)
            };
            parameters[0].Value = evaluation.Score == null ? (object)DBNull.Value : evaluation.Score;

            return DatabaseHelper.ExecuteSql(sql, parameters);
        }

        public ProjectModel GetModel(string nom)
        {
            string sql = "select * from projet where nom = @nom";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@nom", MySqlDbType.VarChar)
            };
            parameters[0].Value = nom;

            DataSet ds = DatabaseHelper.Query(sql, parameters);
            if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                return null;
            }

            return DataRowToModel(ds.Tables[0].Rows[0]);
        }

        private ProjectModel DataRowToModel(DataRow row)
        {
            ProjectModel project = new ProjectModel();
            if (row["nom"] != null && row["nom"].ToString() != String.Empty)
            {
                project.ProjectName = row["nom"].ToString();
            }

            return project;
        }
    }
}
