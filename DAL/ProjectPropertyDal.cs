
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using DAL.SqlUtility;
using Models;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class ProjectPropertyDal
    {
        public List<ProjectPropertyModel> GetAll(int p)
        {
            List<ProjectPropertyModel> result = new List<ProjectPropertyModel>();
            string sql = "CALL GetAllProjectByJointure('"+p+"')";
            DataSet ds = DatabaseHelper.Query(sql);

            if (ds.Tables.Count == 0)
            {
                return result;
            }

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                result.Add(DataRowJoin(row));
            }

            return result;
        } 
        public ProjectPropertyModel GetModel(string numero, int p)
        {
            // sql jointure de 4 tables
            string sql = "CALL GetJoinData('"+numero+ "', '" + p + "')";
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
        public ProjectPropertyModel GetModelName(string nom, int p)
        {
            // sql jointure de 4 tables
            string sql = "CALL GetName('"+nom+"')";
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

            return DataRowJoin(ds.Tables[0].Rows[0]);
        }
        public ArrayList GetModelList()
        {
            //List<ProjectPropertyModel> result = new List<ProjectPropertyModel>();
            ArrayList result = new ArrayList();
            string sql = "CALL GetProjectByStatus()";
           
            DataSet ds = DatabaseHelper.Query(sql);
            if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                return null;
            }

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                result.Add(DataRowGetProjetByStatus(row));
            }

            return result;
        }

        private ProjectPropertyModel DataRowGetProjetByStatus(DataRow row)
        {
            ProjectPropertyModel model = new ProjectPropertyModel();
            if (row == null) return model;
            if (row["projetNbr"] != null && row["projetNbr"].ToString() != String.Empty)
            {
                model.ProjectByStatus = int.Parse(row["projetNbr"].ToString());
            }
            if (row["intitule"] != null && row["intitule"].ToString() != String.Empty)
            {
                model.Status = row["intitule"].ToString();
            }

            return model;
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
            if (row["donePercent"] != null && row["donePercent"].ToString() != String.Empty)
            {
                model.DonePercent = int.Parse(row["donePercent"].ToString());
            }
            if (row["intitule"] != null && row["intitule"].ToString() != String.Empty)
            {
                model.State = row["intitule"].ToString();
            }
            if (row["nom"] != null && row["nom"].ToString() != String.Empty)
            {
                model.ProjectName = row["nom"].ToString();
            }
            if (row["type"] != null && row["type"].ToString() != String.Empty)
            {
                model.Strategy = row["type"].ToString();
            }
            if (row["estimateDate"] != null && row["estimateDate"].ToString() != String.Empty)
            {
                model.Duration = int.Parse(row["estimateDate"].ToString());
            }
            if (row["decription"] != null && row["decription"].ToString() != String.Empty)
            {
                model.Description = row["decription"].ToString();
            }
            if (row["type"] != null && row["type"].ToString() != String.Empty)
            {
                model.Type = row["type"].ToString();
            }
            if (row["category"] != null && row["category"].ToString() != String.Empty)
            {
                model.Category = row["category"].ToString();
            }

            return model;
        }
    }
}
