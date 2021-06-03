using System;
using DAL;
using Models;

namespace TDD
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectDal project = new ProjectDal();

            foreach (ProjectModel model in project.GetAll())
            {
                Console.WriteLine(model.ChefProject);
            }
           

            Console.ReadKey();
        }
    }
}
