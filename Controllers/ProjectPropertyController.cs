
using System.Collections;
using System.Collections.Generic;
using DAL;
using Models;

namespace Controllers
{
    public class ProjectPropertyController
    {
        private ProjectPropertyDal dal = new ProjectPropertyDal();

        public List<ProjectPropertyModel> GetAll(string p)
        {
            return dal.GetAll(int.Parse(p));
        }

        public ProjectPropertyModel GetModel(string numero, string p)
        {
            return dal.GetModel(numero, int.Parse(p));
        }

        public ProjectPropertyModel GetName(string name, string p)
        {
            return dal.GetModelName(name, int.Parse(p));
        }
        public ArrayList GetModelList()
        {
            return dal.GetModelList();
        }
    }
}
