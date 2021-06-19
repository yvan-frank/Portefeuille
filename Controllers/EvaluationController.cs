using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace Controllers
{
    public class EvaluationController
    {
        private readonly EvaluationDal dal = new EvaluationDal();

        public int Insert(EvaluationModel model)
        {
            return dal.Insert(model);
        }

        public ProjectModel GetModel(string nom)
        {
            return dal.GetModel(nom);
        }
    }
}
