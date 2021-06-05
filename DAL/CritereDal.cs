using System;
using System.Collections.Generic;
using System.Data;
using DAL.SqlUtility;
using Models;

namespace DAL
{
    public class CritereDal
    {

        public List<CriteriaModel> GetAll()
        {
            List<CriteriaModel> result = new List<CriteriaModel>();
            string sql = "select * from critere";
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

        private CriteriaModel DataRowToModel(DataRow row)
        {
            CriteriaModel criteria = new CriteriaModel();

            if (row == null) return criteria;

            if (row["id"] != null && row["id"].ToString() != String.Empty)
            {
                criteria.CriteriaId = int.Parse(row["id"].ToString());
            }
            if (row["coherence_mission"] != null && row["coherence_mission"].ToString() != String.Empty)
            {
                criteria.CoherenceDegreeWithTheMission = row["coherence_mission"].ToString();
            }

            if (row["coherence_align_strategie"] != null && row["coherence_align_strategie"].ToString() != String.Empty)
            {
                criteria.AlignmentWithTheEnterpriseStrategy = row["coherence_align_strategie"].ToString();
            }
            if (row["urgence_projet"] != null && row["urgence_projet"].ToString() != String.Empty)
            {
                criteria.UrgencyProjectDegree = row["urgence_projet"].ToString();
            }
            if (row["stabilite_objectif_projet"] != null && row["stabilite_objectif_projet"].ToString() != String.Empty)
            {
                criteria.ObjectiveProjectStability = row["stabilite_objectif_projet"].ToString();
            }
            if (row["soutien_partie_prenante"] != null && row["soutien_partie_prenante"].ToString() != String.Empty)
            {
                criteria.SoutienDesPartiesPrenantes = row["soutien_partie_prenante"].ToString();
            }
            if (row["duree_projet"] != null && row["duree_projet"].ToString() != String.Empty)
            {
                criteria.DureeDuProjet = row["duree_projet"].ToString();
            }
            if (row["cout"] != null && row["cout"].ToString() != String.Empty)
            {
                criteria.CoutduProjet = row["cout"].ToString();
            }
            if (row["disponibilite_ressource"] != null && row["disponibilite_ressource"].ToString() != String.Empty)
            {
                criteria.DisponibilteDesRessources = row["disponibilite_ressource"].ToString();
            }
            if (row["risque_pendant_execution"] != null && row["risque_pendant_execution"].ToString() != String.Empty)
            {
                criteria.DegreeDeRiskDuringSonExecution = row["risque_pendant_execution"].ToString();
            }
            if (row["complexite_projet"] != null && row["complexite_projet"].ToString() != String.Empty)
            {
                criteria.DegreeDeComplxiteDuProjet = row["complexite_projet"].ToString();
            }
            if (row["caractere_innovation"] != null && row["caractere_innovation"].ToString() != String.Empty)
            {
                criteria.CaractereInnovation = row["caractere_innovation"].ToString();
            }
            if (row["develop_skills"] != null && row["develop_skills"].ToString() != String.Empty)
            {
                criteria.SkillsDevelopment = row["develop_skills"].ToString();
            }

            return criteria;
        }

    }
}
