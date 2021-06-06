﻿using System;
using System.Collections.Generic;
using System.Data;
using DAL.SqlUtility;
using Models;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class ProjectDal
    {
        public List<ProjectModel> GetAll()
        {
            List<ProjectModel> result = new List<ProjectModel>();
            string sql = "select * from projet";
            DataSet ds = DatabaseHelper.Query(sql);

            if (ds.Tables.Count == 0)
            {
                return result;
            }

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                result.Add(DataRowToModel(row));
            }

            return result;
        }

        public List<StatusAndStateProjectModel> GetStatus()
        {
            List<StatusAndStateProjectModel> result = new List<StatusAndStateProjectModel>();
            string sql = "select * from status";
            DataSet ds = DatabaseHelper.Query(sql);
            if (ds.Tables.Count == 0)
            {
                return result;
            }

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                result.Add(DataRowStatus(row));
            }

            return result;
        }

        public List<StatusAndStateProjectModel> GetState()
        {
            List<StatusAndStateProjectModel> result = new List<StatusAndStateProjectModel>();
            string sql = "select * from etat";
            DataSet ds = DatabaseHelper.Query(sql);
            if (ds.Tables.Count == 0)
            {
                return result;
            }

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                result.Add(DataRowEtat(row));
            }

            return result;
        }



        // insert projet
        public int Insert(ProjectModel model)
        {
            string sql =
                "INSERT INTO projet (numero,nom,decription,type,category,dateDebut,dateFin,cout,etat,status,internaBudget,externaBudget,returnOfInvest,closeDate,estimateDate,donePercent,chefProjet,planGoToLive,dueDate,CreateTime) VALUES(@numero,@nom,@decription,@type,@category,@dateDebut,@dateFin,@cout,@etat,@status,@internaBudget,@externaBudget,@returnOfInvest,@closeDate,@estimateDate,@donePercent,@chefProjet,@planGoToLive,@dueDate,@CreateTime)";
          
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@numero", MySqlDbType.String),
                new MySqlParameter("@nom", MySqlDbType.VarChar),
                new MySqlParameter("@decription", MySqlDbType.Text),
                new MySqlParameter("@type", MySqlDbType.VarChar),
                new MySqlParameter("@category", MySqlDbType.VarChar),
                new MySqlParameter("@dateDebut", MySqlDbType.Date),
                new MySqlParameter("@dateFin", MySqlDbType.Date),
                new MySqlParameter("@cout", MySqlDbType.Double),
                new MySqlParameter("@etat", MySqlDbType.Int32),
                new MySqlParameter("@status", MySqlDbType.Int32),
                new MySqlParameter("@internaBudget", MySqlDbType.Decimal),
                new MySqlParameter("@externaBudget", MySqlDbType.Decimal),
                new MySqlParameter("@returnOfInvest", MySqlDbType.Decimal),
                new MySqlParameter("@closeDate", MySqlDbType.Date),
                new MySqlParameter("@estimateDate", MySqlDbType.Date),
                new MySqlParameter("@donePercent", MySqlDbType.Int32),
                new MySqlParameter("@chefProjet", MySqlDbType.VarChar),
                new MySqlParameter("@planGoToLive", MySqlDbType.Date),
                new MySqlParameter("@dueDate", MySqlDbType.Date),
                new MySqlParameter("@CreateTime", MySqlDbType.Date)

            };

            parameters[0].Value = model.NumberProject == null ? (object) DBNull.Value : model.NumberProject;
            parameters[1].Value = model.ProjectName == null ? (object)DBNull.Value : model.ProjectName;
            parameters[2].Value = model.Description == null ? (object)DBNull.Value : model.Description;
            parameters[3].Value = model.ProjectType == null ? (object)DBNull.Value : model.ProjectType;
            parameters[4].Value = model.Category == null ? (object)DBNull.Value : model.Category;
            parameters[5].Value = model.DateDebut == null ? (object)DBNull.Value : model.DateDebut;
            parameters[6].Value = model.DateFin == null ? (object)DBNull.Value : model.DateFin;
            parameters[7].Value = model.Cost == null ? (object)DBNull.Value : model.Cost;
            parameters[8].Value = model.State == null ? (object)DBNull.Value : model.State;
            parameters[9].Value = model.Status == null ? (object)DBNull.Value : model.Status;
            parameters[10].Value = model.InternalBudget == null ? (object)DBNull.Value : model.InternalBudget;
            parameters[11].Value = model.ExternalBudget == null ? (object)DBNull.Value : model.ExternalBudget;
            parameters[12].Value = model.ReturnOfInvestment == null ? (object)DBNull.Value : model.CloseDate;
            parameters[13].Value = model.CloseDate == null ? (object)DBNull.Value : model.CloseDate;
            parameters[14].Value = model.EstimatedDate == null ? (object)DBNull.Value : model.EstimatedDate;
            parameters[15].Value = model.DonePercent == null ? (object)DBNull.Value : model.DonePercent;
            parameters[16].Value = model.ChefProject == null ? (object)DBNull.Value : model.ChefProject;
            parameters[17].Value = model.PlanGotoLive == null ? (object)DBNull.Value : model.PlanGotoLive;
            parameters[18].Value = model.DueDate == null ? (object)DBNull.Value : model.DueDate;
            parameters[19].Value = model.CreateTime == null ? (object)DBNull.Value : model.CreateTime;




            return DatabaseHelper.ExecuteSql(sql, parameters);
        }

        //update project

        public int Update(ProjectModel model)
        {
            string sql =
                "UPDATE projet SET numero=@numero,nom=@nom,decription=@decription,type=@type,category=@category,dateDebut=@dateDebut,dateFin=@dateFin,cout=@cout,etat=@etat,status=@status,internaBudget=@internaBudget,externaBudget=@externaBudget,returnOfInvest=@returnOfInvest,closeDate=@closeDate,estimateDate=@estimateDate,donePercent=@donePercent,chefProjet=@chefProjet, planGoToLive=@planGoToLive,dueDate=@dueDate,CreateTime=@CreateTime WHERE id=@ProjectId";

            MySqlParameter[] parameters =
           {
                new MySqlParameter("@ProjectId", MySqlDbType.Int32),
                new MySqlParameter("@numero", MySqlDbType.String),
                new MySqlParameter("@nom", MySqlDbType.VarChar),
                new MySqlParameter("@decription", MySqlDbType.Text),
                new MySqlParameter("@type", MySqlDbType.VarChar),
                new MySqlParameter("@category", MySqlDbType.VarChar),
                new MySqlParameter("@dateDebut", MySqlDbType.Date),
                new MySqlParameter("@dateFin", MySqlDbType.Date),
                new MySqlParameter("@cout", MySqlDbType.Double),
                new MySqlParameter("@etat", MySqlDbType.Int32),
                new MySqlParameter("@status", MySqlDbType.Int32),
                new MySqlParameter("@internaBudget", MySqlDbType.Decimal),
                new MySqlParameter("@externaBudget", MySqlDbType.Decimal),
                new MySqlParameter("@returnOfInvest", MySqlDbType.Decimal),
                new MySqlParameter("@closeDate", MySqlDbType.Date),
                new MySqlParameter("@estimateDate", MySqlDbType.Date),
                new MySqlParameter("@donePercent", MySqlDbType.Int32),
                new MySqlParameter("@chefProjet", MySqlDbType.VarChar),
                new MySqlParameter("@planGoToLive", MySqlDbType.Date),
                new MySqlParameter("@dueDate", MySqlDbType.Date),
                new MySqlParameter("@CreateTime", MySqlDbType.Date),
            };

            parameters[0].Value = model.ProjectId;
            parameters[1].Value = model.NumberProject == null ? (object)DBNull.Value : model.NumberProject;
            parameters[2].Value = model.ProjectName == null ? (object)DBNull.Value : model.ProjectName;
            parameters[3].Value = model.Description == null ? (object)DBNull.Value : model.Description;
            parameters[4].Value = model.ProjectType == null ? (object)DBNull.Value : model.ProjectType;
            parameters[5].Value = model.Category == null ? (object)DBNull.Value : model.Category;
            parameters[6].Value = model.DateDebut == null ? (object)DBNull.Value : model.DateDebut;
            parameters[7].Value = model.DateFin == null ? (object)DBNull.Value : model.DateFin;
            parameters[8].Value = model.Cost == null ? (object)DBNull.Value : model.Cost;
            parameters[9].Value = model.State == null ? (object)DBNull.Value : model.State;
            parameters[10].Value = model.Status == null ? (object)DBNull.Value : model.Status;
            parameters[11].Value = model.InternalBudget == null ? (object)DBNull.Value : model.InternalBudget;
            parameters[12].Value = model.ExternalBudget == null ? (object)DBNull.Value : model.ExternalBudget;
            parameters[13].Value = model.ReturnOfInvestment == null ? (object)DBNull.Value : model.CloseDate;
            parameters[14].Value = model.CloseDate == null ? (object)DBNull.Value : model.Description;
            parameters[15].Value = model.EstimatedDate == null ? (object)DBNull.Value : model.EstimatedDate;
            parameters[16].Value = model.DonePercent == null ? (object)DBNull.Value : model.DonePercent;
            parameters[17].Value = model.ChefProject == null ? (object)DBNull.Value : model.ChefProject;
            parameters[18].Value = model.PlanGotoLive == null ? (object)DBNull.Value : model.PlanGotoLive;


            return DatabaseHelper.ExecuteSql(sql, parameters);
        }
        // check doublon data from project
        public bool CheckData(ProjectModel model)
        {
            string sql = "select * from projet";
            string numberProject = "";
            string name = "";

            try
            {
                MySqlDataReader reader = DatabaseHelper.ExecuteDataReader(sql);
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        numberProject = reader.GetString(1);
                        name = reader.GetString(2);
                    }


                }
                return numberProject == model.NumberProject || name == model.ProjectName;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }


        //number project management
        public string GenerateProjectNumber()
        {
            ProjectModel model = new ProjectModel();
            string sql = "select * from projet";
            string numero = String.Empty;
            try
            {
                MySqlDataReader reader = DatabaseHelper.ExecuteDataReader(sql);

                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        numero = reader.GetString(1);
                    }
                }

                return numero;
            }
            catch (MySqlException e)
            {
                return numero;
            }
        }
        public ProjectModel GetModel(int projectId)
        {
            string sql = "select * from projet where id = @ProjectId";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@ProjectId", MySqlDbType.Int32)
            };
            parameters[0].Value = projectId;

            DataSet ds = DatabaseHelper.Query(sql, parameters);
            if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                return null;
            }

            return DataRowToModel(ds.Tables[0].Rows[0]);
        }

        //get count project
        public int CountProject()
        {
            string sql = "select count(*) from projet";

            int val = DatabaseHelper.ExecuteSqlCount(sql);

            return val;
        }

        

        private ProjectModel DataRowToModel(DataRow row)
        {
            ProjectModel project = new ProjectModel();

            if (row == null) return project;

            if (row["id"] != null && row["id"].ToString() != String.Empty)
            {
                project.ProjectId = int.Parse(row["id"].ToString());
            }
            if (row["numero"] != null && row["numero"].ToString() != String.Empty)
            {
                project.NumberProject = row["numero"].ToString();
            }
            if (row["nom"] != null && row["nom"].ToString() != String.Empty)
            {
                project.ProjectName = row["nom"].ToString();
            }
            if (row["decription"] != null && row["decription"].ToString() != String.Empty)
            {
                project.Description = row["decription"].ToString();
            }
            if (row["chefProjet"] != null && row["chefProjet"].ToString() != String.Empty)
            {
                project.ChefProject = row["chefProjet"].ToString();
            }
            if (row["type"] != null && row["type"].ToString() != String.Empty)
            {
                project.ProjectType = row["type"].ToString();
            }
            if (row["category"] != null && row["category"].ToString() != String.Empty)
            {
                project.Category = row["category"].ToString();
            }
            if (row["dateDebut"] != null && row["dateDebut"].ToString() != String.Empty)
            {
                project.DateDebut = DateTime.Parse(row["dateDebut"].ToString());
            }
            if (row["dateFin"] != null && row["dateFin"].ToString() != String.Empty)
            {
                project.DateFin = DateTime.Parse(row["dateFin"].ToString());
            }
            if (row["cout"] != null && row["cout"].ToString() != String.Empty)
            {
                project.Cost = int.Parse(row["cout"].ToString());
            }
            if (row["etat"] != null && row["etat"].ToString() != String.Empty)
            {
                project.State = int.Parse(row["etat"].ToString());
            }
            if (row["status"] != null && row["status"].ToString() != String.Empty)
            {
                project.Status = int.Parse(row["status"].ToString());
            }
            if (row["internaBudget"] != null && row["internaBudget"].ToString() != String.Empty)
            {
                project.InternalBudget = decimal.Parse(row["internaBudget"].ToString());
            }
            if (row["externaBudget"] != null && row["externaBudget"].ToString() != String.Empty)
            {
                project.ExternalBudget = decimal.Parse(row["externalBudget"].ToString());
            }
            if (row["returnOfInvest"] != null && row["returnOfInvest"].ToString() != String.Empty)
            {
                project.ReturnOfInvestment = decimal.Parse(row["returnOfInvest"].ToString());
            }
            if (row["closeDate"] != null && row["closeDate"].ToString() != String.Empty)
            {
                project.CloseDate = DateTime.Parse(row["closeDate"].ToString());
            }
            if (row["estimateDate"] != null && row["estimateDate"].ToString() != String.Empty)
            {
                project.EstimatedDate = decimal.Parse(row["estimateDate"].ToString());
            }
            if (row["donePercent"] != null && row["donePercent"].ToString() != String.Empty)
            {
                project.DonePercent = int.Parse(row["donePercent"].ToString());
            }
            if (row["planGoToLive"] != null && row["planGoToLive"].ToString() != String.Empty)
            {
                project.PlanGotoLive = DateTime.Parse(row["planGoToLive"].ToString());
            }
            return project;
        }

        private StatusAndStateProjectModel DataRowStatus(DataRow row)
        {
            StatusAndStateProjectModel status = new StatusAndStateProjectModel();

            if (row == null) return status;

            //status
            if (row["id"] != null && row["id"].ToString() != String.Empty)
            {
                status.IdStatus = int.Parse(row["id"].ToString());
            }
            if (row["libelle"] != null && row["libelle"].ToString() != String.Empty)
            {
                status.LibelleStatus =row["libelle"].ToString();
            }
            return status;
        }

        private StatusAndStateProjectModel DataRowEtat(DataRow row)
        {
            StatusAndStateProjectModel etat = new StatusAndStateProjectModel();

            if (row == null) return etat;

            // etat
            if (row["id"] != null && row["id"].ToString() != String.Empty)
            {
                etat.IdEtat = int.Parse(row["id"].ToString());
            }
            if (row["intitule"] != null && row["intitule"].ToString() != String.Empty)
            {
                etat.InstitulateEtat = row["intitule"].ToString();
            }

            return etat;
        }
    }
}
