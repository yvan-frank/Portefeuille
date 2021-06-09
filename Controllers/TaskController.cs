
using DAL;

namespace Controllers
{
    public class TaskController
    {
        private TaskDal dal = new TaskDal();

        public int CountTaskProject(string num)
        {
            return dal.CountTaskProject(num);
        }
    }
}
