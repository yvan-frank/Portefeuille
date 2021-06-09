
using System;
using System.Data;
using DAL.SqlUtility;
using Models;

namespace DAL
{
    public class TaskDal
    {
        public int CountTaskProject(string num)
        {
            string sql = "CALL countTaskByProject('" + num + "')";

            int val = DatabaseHelper.ExecuteSqlCount(sql);

            return val;
        }
        public TaskModel DataRowToModel(DataRow row)
        {
            TaskModel model = new TaskModel();

            if (row == null) return model;

            if (row["id"] != null && row["id"].ToString() != String.Empty)
            {
                model.TaskId = int.Parse(row["id"].ToString());
            }
            if (row["task_name"] != null && row["task_name"].ToString() != String.Empty)
            {
                model.TaskName = row["task_name"].ToString();
            }
            if (row["isJalon"] != null && row["isJalon"].ToString() != String.Empty)
            {
                model.IsJalon = Int32.Parse(row["isJalon"].ToString());
            }
            if (row["planDate"] != null && row["planDate"].ToString() != String.Empty)
            {
                model.PlanDate = DateTime.Parse(row["planDate"].ToString());
            }
            if (row["duration"] != null && row["duration"].ToString() != String.Empty)
            {
                model.Duration = int.Parse(row["duration"].ToString());
            }
            if (row["planBudget"] != null && row["planBudget"].ToString() != String.Empty)
            {
                model.PlanDate = DateTime.Parse(row["planBudget"].ToString());
            }
            if (row["actualBudget"] != null && row["actualBudget"].ToString() != String.Empty)
            {
                model.ActualBudget = int.Parse(row["actualBudget"].ToString());
            }
            if (row["progress"] != null && row["progress"].ToString() != String.Empty)
            {
                model.Progress = int.Parse(row["progress"].ToString());
            }
            if (row["dalay_execution"] != null && row["dalay_execution"].ToString() != String.Empty)
            {
                model.DelayExecution = DateTime.Parse(row["dalay_execution"].ToString());
            }

            return model;
        }
    }
}
