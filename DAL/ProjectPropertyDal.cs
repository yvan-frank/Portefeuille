
using System;
using System.Data;
using DAL.SqlUtility;
using Models;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class ProjectPropertyDal
    {

        public ProjectPropertyModel GetModel(string numero)
        {
            string sql = "SELECT * FROM (((projet p INNER JOIN status s ON p.status = s.id) INNER JOIN etat e ON p.etat = e.id) INNER JOIN user u ON p.pm = u.id) where numero = @numero";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@numero", MySqlDbType.VarChar)
            };
            parameters[0].Value = numero;
            DataSet ds = DatabaseHelper.Query(sql, parameters);
            if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                return null;
            }

            return DataRowJoin(ds.Tables[0].Rows[0]);
        }
        private ProjectPropertyModel DataRowJoin(DataRow row)
        {
            ProjectPropertyModel model = new ProjectPropertyModel();
            if (row == null) return model;
            if (row["libelle"] != null && row["libelle"].ToString() != String.Empty)
            {
                model.Status = row["libelle"].ToString();
            }
            if (row["numero"] != null && row["numero"].ToString() != String.Empty)
            {
                model.NumberProject = row["numero"].ToString();
            }
            if (row["pmName"] != null && row["pmName"].ToString() != String.Empty)
            {
                model.FunctionName = row["pmName"].ToString();
            }
            if (row["dateDebut"] != null && row["dateDebut"].ToString() != String.Empty)
            {
                model.DateDebut = DateTime.Parse(row["dateDebut"].ToString());
            }
            if (row["dateFin"] != null && row["dateFin"].ToString() != String.Empty)
            {
                model.DateFin = DateTime.Parse(row["dateFin"].ToString());
            }
            if (row["cout"] != null && row["cout"].ToString() != String.Empty)
            {
                model.Cost = int.Parse(row["cout"].ToString());
            }
            if (row["etat"] != null && row["etat"].ToString() != String.Empty)
            {
                model.State = row["etat"].ToString();
            }

            return model;
        }
    }
}
