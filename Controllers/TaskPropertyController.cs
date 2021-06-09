
using System.Collections;
using DAL;
using Models;

namespace Controllers
{
    public class TaskPropertyController
    {
        private readonly TaskPropertyDal dal = new TaskPropertyDal();

        public ArrayList GetModel(string numero)
        {
            return dal.GetListModel(numero);
        }
    }
}
