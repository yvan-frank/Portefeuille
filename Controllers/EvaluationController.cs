using System;
using System.Collections;
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

        public List<EvaluationModel> GetListEvaluation()
        {
            return dal.GetListEvaluation();
        }
        public int Insert(EvaluationModel model)
        {
            return dal.Insert(model);
        }

        public EvaluationModel GetModelEvaluation(string numero)
        {
            return dal.GetModelEvaluation(numero);
        }
        public int GetMaxScore()
        {
            return dal.GetMaxScore();
        }
        public ArrayList GetModelList()
        {
            return dal.GetModelList();
        }

        public int DeleteEvaluation(string numero)
        {
            return dal.DeleteEvaluation(numero);
        }
    }
}
