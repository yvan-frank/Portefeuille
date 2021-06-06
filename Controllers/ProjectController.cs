using System.Collections.Generic;
using DAL;
using Models;
namespace Controllers
{
    public class ProjectController
    {
        private readonly ProjectDal dal = new ProjectDal();

        public List<ProjectModel> GetAll()
        {
            return dal.GetAll();
        }

        public List<StatusAndStateProjectModel> GetStatus()
        {
            return dal.GetStatus();
        }

        public List<StatusAndStateProjectModel> GetState()
        {
            return dal.GetState();
        }

        public int CountProject()
        {
            return dal.CountProject();
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

        public ProjectModel GetModel(int projectId)
        {
            return dal.GetModel(projectId);
        }
    }
}
