using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace Controllers
{
    public class PortfolioController
    {
        private PortfolioDal dal = new PortfolioDal();

        public List<PortfolioModel> GetAll()
        {
            return dal.GetAll();
        }
        public int Create(PortfolioModel portfolio)
        {
            return dal.Create(portfolio);
        }
    }
}
