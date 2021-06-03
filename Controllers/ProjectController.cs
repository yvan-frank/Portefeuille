using System.Collections.Generic;
using DAL;
using Models;
namespace Controllers
{
    public class ProjectController
    {
        private readonly ProjectDal _projectDal = new ProjectDal();

        public List<ProjectModel> GetAll()
        {
            return _projectDal.GetAll();
        }
    }
}
