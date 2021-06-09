
using System;
using System.Collections;
using System.Data;
using DAL.SqlUtility;
using Models;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class TaskPropertyDal
    {

        public ArrayList GetListModel(string numero)
        {
            // sql jointure de 4 tables
            ArrayList result = new ArrayList();
            string sql = "CALL GetTaskByStatusOnProject('" + numero + "')";
            DataSet ds = DatabaseHelper.Query(sql);
            if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                //return null;
            }

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                result.Add(DataRowJoinStatus(row));
            }

            return result;
        }

        public TaskPropertyModel DataRowJoinStatus(DataRow row)
        {
            TaskPropertyModel model = new TaskPropertyModel();

            if (row == null) return model;
            if (row["taskCount"] != null && row["taskCount"].ToString() != String.Empty)
            {
                model.TaskId = int.Parse(row["taskCount"].ToString());
            }
            if (row["intitule"] != null && row["intitule"].ToString() != String.Empty)
            {
                model.Status = row["intitule"].ToString();
            }

            return model;
        }
        public TaskPropertyModel DataRowToModel(DataRow row)
        {
            TaskPropertyModel model = new TaskPropertyModel();

            if (row == null) return model;

            if (row["idTask"] != null && row["idTask"].ToString() != String.Empty)
            {
                model.TaskId = int.Parse(row["idTask"].ToString());
            }
            if (row["taskCount"] != null && row["taskCount"].ToString() != String.Empty)
            {
                model.TaskId = int.Parse(row["taskCount"].ToString());
            }
            if (row["numero"] != null && row["numero"].ToString() != String.Empty)
            {
                model.NumberProject = row["numero"].ToString();
            }
            if (row["task_name"] != null && row["task_name"].ToString() != String.Empty)
            {
                model.TaskName = row["task_name"].ToString();
            }
            if (row["pmName"] != null && row["pmName"].ToString() != String.Empty)
            {
                model.FunctionName = row["pmName"].ToString();
            }
            if (row["niveau"] != null && row["niveau"].ToString() != String.Empty)
            {
                model.Priority = row["niveau"].ToString();
            }
            if (row["libelle"] != null && row["libelle"].ToString() != String.Empty)
            {
                model.Status = row["libelle"].ToString();
            }
            if (row["intitule"] != null && row["intitule"].ToString() != String.Empty)
            {
                model.State = row["intitule"].ToString();
            }

            return model;
        }
    }
}
