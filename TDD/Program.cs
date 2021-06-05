using System;
using DAL;
using Models;

namespace TDD
{
    class Program
    {
        static void Main(string[] args)
        {
            CritereDal project = new CritereDal();

            foreach (CriteriaModel model in project.GetAll())
            {
                Console.WriteLine(model.CoherenceDegreeWithTheMission);

            }

            

            Console.ReadKey();
        }
    }
}
