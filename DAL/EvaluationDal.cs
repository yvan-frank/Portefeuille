
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using DAL.SqlUtility;
using Models;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class EvaluationDal
    {
        public List<EvaluationModel> GetListEvaluation()
        {
            List<EvaluationModel> result = new List<EvaluationModel>();
            string sql = "select * from evaluation";
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

        public int GetMaxScore()
        {
            string sql = "select max(score) from evaluation";

            int val = DatabaseHelper.ExecuteSqlCount(sql);

            return val;
        }
        public EvaluationModel GetModelEvaluation(string numero)
        {
            // sql jointure de 4 tables
            string sql = "select * from evaluation where project_number = @numero";
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

            return DataRowToModel(ds.Tables[0].Rows[0]);
        }
        public ArrayList GetModelList()
        {
            //List<ProjectPropertyModel> result = new List<ProjectPropertyModel>();
            ArrayList result = new ArrayList();
            string sql = "SELECT * FROM evaluation";

            DataSet ds = DatabaseHelper.Query(sql);
            if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                return null;
            }

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                result.Add(DataRowToModel(row));
            }

            return result;
        }
        public int Insert(EvaluationModel model)
        {
            string sql =
                "INSERT INTO evaluation (score,project_number,coherence_mission,coherence_align_strategie,urgence_projet,stabilite_objectif_projet,soutien_partie_prenante," +
                "duree_projet,cout,disponibilite_ressource,risque_pendant_execution,complexite_projet,caractere_innovation,develop_skills)" +
                " VALUES(@score,@projet,@cm,@cas,@up,@sop,@spp,@dp,@cout,@dr,@rpe,@cp,@ci,@ds)";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@score", MySqlDbType.Int32),
                new MySqlParameter("@projet", MySqlDbType.VarChar),
                new MySqlParameter("@cm", MySqlDbType.Int32),
                new MySqlParameter("@cas", MySqlDbType.Int32),
                new MySqlParameter("@up", MySqlDbType.Int32),
                new MySqlParameter("@sop", MySqlDbType.Int32),
                new MySqlParameter("@spp", MySqlDbType.Int32),
                new MySqlParameter("@dp", MySqlDbType.Int32),
                new MySqlParameter("@cout", MySqlDbType.Int32),
                new MySqlParameter("@dr", MySqlDbType.Int32),
                new MySqlParameter("@rpe", MySqlDbType.Int32),
                new MySqlParameter("@cp", MySqlDbType.Int32),
                new MySqlParameter("@ci", MySqlDbType.Int32),
                new MySqlParameter("@ds", MySqlDbType.Int32)

            };

            parameters[0].Value = model.Score == null ? (object)DBNull.Value : model.Score;
            parameters[1].Value = model.ProjectNumber == null ? (object)DBNull.Value : model.ProjectNumber;
            parameters[2].Value = model.CoherenceDegreeWithTheMission == null ? (object)DBNull.Value : model.CoherenceDegreeWithTheMission;
            parameters[3].Value = model.AlignmentWithTheEnterpriseStrategy == null ? (object)DBNull.Value : model.AlignmentWithTheEnterpriseStrategy;
            parameters[4].Value = model.UrgencyProjectDegree == null ? (object)DBNull.Value : model.UrgencyProjectDegree;
            parameters[5].Value = model.ObjectiveProjectStability == null ? (object)DBNull.Value : model.ObjectiveProjectStability;
            parameters[6].Value = model.SoutienDesPartiesPrenantes == null ? (object)DBNull.Value : model.SoutienDesPartiesPrenantes;
            parameters[7].Value = model.DureeDuProjet == null ? (object)DBNull.Value : model.DureeDuProjet;
            parameters[8].Value = model.CoutduProjet == null ? (object)DBNull.Value : model.CoutduProjet;
            parameters[9].Value = model.DisponibilteDesRessources == null ? (object)DBNull.Value : model.DisponibilteDesRessources;
            parameters[10].Value = model.DegreeDeRiskDuringSonExecution == null ? (object)DBNull.Value : model.DegreeDeRiskDuringSonExecution;
            parameters[11].Value = model.DegreeDeComplxiteDuProjet == null ? (object)DBNull.Value : model.DegreeDeComplxiteDuProjet;
            parameters[12].Value = model.CaractereInnovation == null ? (object)DBNull.Value : model.CaractereInnovation;
            parameters[13].Value = model.SkillsDevelop == null ? (object)DBNull.Value : model.SkillsDevelop;

            return DatabaseHelper.ExecuteSql(sql, parameters);
        }

        public int DeleteEvaluation(string numero)
        {
            string sql = "DELETE FROM evaluation WHERE project_number = @numero";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@numero", MySqlDbType.VarChar)
            };

            parameters[0].Value = numero;

            return DatabaseHelper.ExecuteSql(sql, parameters);
        }

        private EvaluationModel DataRowToModel(DataRow row)
        {
            EvaluationModel evaluation = new EvaluationModel();
            if (row["id"] != null && row["id"].ToString() != String.Empty)
            {
                evaluation.IdEvaluation = int.Parse(row["id"].ToString());
            }
            if (row["project_number"] != null && row["project_number"].ToString() != String.Empty)
            {
                evaluation.ProjectNumber = row["project_number"].ToString();
            }
            if (row["score"] != null && row["score"].ToString() != String.Empty)
            {
                evaluation.Score = int.Parse(row["score"].ToString());
            }
            //criteria
            if (row["coherence_mission"] != null && row["coherence_mission"].ToString() != String.Empty)
            {
                evaluation.CoherenceDegreeWithTheMission = int.Parse(row["coherence_mission"].ToString());
            }
            if (row["coherence_align_strategie"] != null && row["coherence_align_strategie"].ToString() != String.Empty)
            {
                evaluation.AlignmentWithTheEnterpriseStrategy = int.Parse(row["coherence_align_strategie"].ToString());
            }
            if (row["urgence_projet"] != null && row["urgence_projet"].ToString() != String.Empty)
            {
                evaluation.UrgencyProjectDegree = int.Parse(row["urgence_projet"].ToString());
            }
            if (row["stabilite_objectif_projet"] != null && row["stabilite_objectif_projet"].ToString() != String.Empty)
            {
                evaluation.ObjectiveProjectStability = int.Parse(row["stabilite_objectif_projet"].ToString());
            }
            if (row["soutien_partie_prenante"] != null && row["soutien_partie_prenante"].ToString() != String.Empty)
            {
                evaluation.SoutienDesPartiesPrenantes = int.Parse(row["soutien_partie_prenante"].ToString());
            }
            if (row["duree_projet"] != null && row["duree_projet"].ToString() != String.Empty)
            {
                evaluation.DureeDuProjet = int.Parse(row["duree_projet"].ToString());
            }
            if (row["cout"] != null && row["cout"].ToString() != String.Empty)
            {
                evaluation.CoutduProjet = int.Parse(row["cout"].ToString());
            }
            if (row["disponibilite_ressource"] != null && row["disponibilite_ressource"].ToString() != String.Empty)
            {
                evaluation.DisponibilteDesRessources = int.Parse(row["disponibilite_ressource"].ToString());
            }
            if (row["risque_pendant_execution"] != null && row["risque_pendant_execution"].ToString() != String.Empty)
            {
                evaluation.DegreeDeRiskDuringSonExecution = int.Parse(row["risque_pendant_execution"].ToString());
            }
            if (row["complexite_projet"] != null && row["complexite_projet"].ToString() != String.Empty)
            {
                evaluation.DegreeDeComplxiteDuProjet = int.Parse(row["complexite_projet"].ToString());
            }
            if (row["caractere_innovation"] != null && row["caractere_innovation"].ToString() != String.Empty)
            {
                evaluation.CaractereInnovation = int.Parse(row["caractere_innovation"].ToString());
            }
            if (row["develop_skills"] != null && row["develop_skills"].ToString() != String.Empty)
            {
                evaluation.SkillsDevelop = int.Parse(row["develop_skills"].ToString());
            }

            return evaluation;
        }
    }
}
