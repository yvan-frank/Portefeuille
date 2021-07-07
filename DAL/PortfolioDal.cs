using System;
using System.Collections.Generic;
using System.Data;
using DAL.SqlUtility;
using Models;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class PortfolioDal
    {
        public List<PortfolioModel> GetAll()
        {
            List<PortfolioModel> result = new List<PortfolioModel>();

            string sql = "select * from portefeuille";
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


        public int Create(PortfolioModel portfolio)
        {
            string sql = "INSERT INTO portefeuille(denomination,cout,mission,strategie) VALUES(@denomi, @cout,@mission,@strategie)";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@denomi", MySqlDbType.VarChar),
                new MySqlParameter("@cout", MySqlDbType.Int32),
                new MySqlParameter("@mission", MySqlDbType.Text),
                new MySqlParameter("@strategie", MySqlDbType.Text)
            };

            parameters[0].Value = portfolio.Denominate == null ? (object) DBNull.Value : portfolio.Denominate;
            parameters[1].Value = portfolio.Cost == null ? (object) DBNull.Value : portfolio.Cost;
            parameters[2].Value = portfolio.MissionList == null ? (object) DBNull.Value : portfolio.MissionList;
            parameters[3].Value = portfolio.ObjectiveList == null ? (object) DBNull.Value : portfolio.ObjectiveList;

            return DatabaseHelper.ExecuteSql(sql, parameters);
        }


        private PortfolioModel DataRowToModel(DataRow row)
        {
            PortfolioModel portfolio = new PortfolioModel();

            if (row == null) return portfolio;

            if (row["numero"] != null && row["numero"].ToString() != String.Empty)
            {
                portfolio.IdPortfolio = row["numero"].ToString();
            }

            if (row["denomination"] != null && row["denomination"].ToString() != String.Empty)
            {
                portfolio.Denominate = row["denomination"].ToString();
            }

            if (row["cout"] != null && row["cout"].ToString() != String.Empty)
            {
                portfolio.Cost = int.Parse(row["cout"].ToString());
            }

            return portfolio;
        }
    }
}
