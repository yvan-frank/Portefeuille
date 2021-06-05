
using System;
using System.Collections.Generic;
using System.Data;
using DAL.SqlUtility;
using Models;

namespace DAL
{
    public class ScenarioDal
    {
        public List<ScenarioModel> GetAllScenario()
        {
            List<ScenarioModel> result = new List<ScenarioModel>();
            try
            {
                
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

            }
            catch
            {
                //
            }

            return result;

        }
        private ScenarioModel DataRowToModel(DataRow row)
        {
            ScenarioModel scenario = new ScenarioModel();

            if (row == null) return scenario;

            if (row["id"] != null && row["id"].ToString() != String.Empty)
            {
                scenario.ProjectId = int.Parse(row["id"].ToString());
            }
            if (row["dateDebut"] != null && row["dateDebut"].ToString() != String.Empty)
            {
                scenario.StartDate = DateTime.Parse(row["dateDebut"].ToString());
            }
            if (row["dateFin"] != null && row["dateFin"].ToString() != String.Empty)
            {
                scenario.EnDate = DateTime.Parse(row["dateFin"].ToString());
            }
            if (row["cout"] != null && row["cout"].ToString() != String.Empty)
            {
                scenario.Cost = int.Parse(row["cout"].ToString());
            }
            if (row["etat"] != null && row["etat"].ToString() != String.Empty)
            {
                scenario.State = int.Parse(row["etat"].ToString());
            }
            if (row["status"] != null && row["status"].ToString() != String.Empty)
            {
                scenario.Status = int.Parse(row["status"].ToString());
            }

            if (row["externalBudget"] != null && row["externalBudget"].ToString() != String.Empty)
            {
                scenario.ExternalBudget = decimal.Parse(row["externalBudget"].ToString());
            }
           
            if (row["closeDate"] != null && row["closeDate"].ToString() != String.Empty)
            {
                scenario.CloseDate = DateTime.Parse(row["closeDate"].ToString());
            }
            if (row["estimateDate"] != null && row["estimateDate"].ToString() != String.Empty)
            {
                scenario.EstimatedDate = DateTime.Parse(row["estimateDate"].ToString());
            }
            if (row["donePercent"] != null && row["donePercent"].ToString() != String.Empty)
            {
                scenario.DonePercent = int.Parse(row["donePercent"].ToString());
            }

            return scenario;
        }
    }
}
