using System.Collections.Generic;
using DAL;
using Models;
namespace Controllers
{
    public class ProjectController
    {
        private readonly ProjectDal dal = new ProjectDal();

        public List<ProjectModel> GetAll(int p)
        {
            return dal.GetAll(p);
        }

        public List<StatusAndStateProjectModel> GetStatus()
        {
            return dal.GetStatus();
        }

        public List<StatusAndStateProjectModel> GetState()
        {
            return dal.GetState();
        }

        public List<ProjectModel> GetListByNumero(string numero, string p)
        {
            return dal.GetListByNumero(numero, int.Parse(p));
        }

        public int CountProject(string p)
        {
            return dal.CountProject(int.Parse(p));
        }

        public int GetCostProject(string p)
        {
            return dal.GetCountCost(int.Parse(p));
        }

        public int Insert(ProjectModel model)
        {
            return dal.Insert(model);
        }

        public bool CheckData(ProjectModel model)
        {
            return dal.CheckData(model);
        }

        public string GenerateNumber()
        {
            return dal.GenerateProjectNumber();
        }

        public int Update(ProjectModel model)
        {
            return dal.Update(model);
        }

        public ProjectModel GetModel(string projectId, string p)
        {
            return dal.GetModel(projectId, int.Parse(p));
        }

        public int DeleteProject(string numero)
        {
            return dal.DeleteProject(numero);
        }

    }
}
