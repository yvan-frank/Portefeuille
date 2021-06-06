using System;
using System.Text.RegularExpressions;
using Controllers;
using DAL;
using Models;

namespace TDD
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectController project = new ProjectController();

            string num = project.GenerateNumber();
            var substring = num.Substring(0, 5);
            string str = project.GenerateNumber();
            string[] numbers = Regex.Split(str, @"\D+");
            foreach (string nbr in numbers)
            {
                int number;
                if (int.TryParse(nbr, out number))
                {
                    number++;
                    Console.WriteLine(substring + number);
                }
            }

            Console.ReadKey();
        }
    }
}
