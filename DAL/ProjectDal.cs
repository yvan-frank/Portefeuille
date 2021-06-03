using System;
using System.Collections.Generic;
using System.Data;
using DAL.SqlUtility;
using Models;

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

        private ProjectModel DataRowToModel(DataRow row)
        {
            ProjectModel project = new ProjectModel();

            if (row == null) return project;

            if (row["id"] != null && row["id"].ToString() != String.Empty)
            {
                project.ProjectId = int.Parse(row["id"].ToString());
            }
            if (row["nom"] != null && row["nom"].ToString() != String.Empty)
            {
                project.ProjectName = row["nom"].ToString();
            }
            if (row["description"] != null && row["description"].ToString() != String.Empty)
            {
                project.Description = row["description"].ToString();
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
            if (row["internalBudget"] != null && row["internalBudget"].ToString() != String.Empty)
            {
                project.InternalBudget = decimal.Parse(row["internalBudget"].ToString());
            }
            if (row["externalBudget"] != null && row["externalBudget"].ToString() != String.Empty)
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
                project.EstimatedDate = DateTime.Parse(row["estimateDate"].ToString());
            }
            if (row["donePercent"] != null && row["donePercent"].ToString() != String.Empty)
            {
                project.DonePercent = int.Parse(row["donePercent"].ToString());
            }

            return project;
        }
    }
}
