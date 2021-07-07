
using System.Collections.Generic;
using DAL;
using Models;

namespace Controllers
{
    public class UserController
    {
        private UserDal dal = new UserDal();
        public bool Login(string id, string pass)
        {
            return dal.Login(id, pass);
        }

        public List<UserModel> GetList()
        {
            return dal.GetAll();
        }
    }
}
