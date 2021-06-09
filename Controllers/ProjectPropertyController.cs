﻿
using System.Collections;
using System.Collections.Generic;
using DAL;
using Models;

namespace Controllers
{
    public class ProjectPropertyController
    {
        private ProjectPropertyDal dal = new ProjectPropertyDal();

        public ProjectPropertyModel GetModel(string numero)
        {
            return dal.GetModel(numero);
        }

        public ArrayList GetModelList()
        {
            return dal.GetModelList();
        }
    }
}
