using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace Controllers
{
    public class CriteriaController
    {
        private readonly CritereDal criteria = new CritereDal();
        public List<CriteriaModel> GetAll()
        {
            return criteria.GetAll();
        }
    }
}
