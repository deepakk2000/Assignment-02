using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee ID");
           int id=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Employee Genter M/F");
            char gender =Char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Salary");
            double salary = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Date of Joining DD/MM/YYYY");
            DateTime doj = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("\n ID\tEmployee Name\tEmployee Gender\tEmployee Salary\tDOJ");
            Console.WriteLine($"{id}\t{name}\t{gender}\t{salary}\t{doj:MM/dd/yyyy}");
            double taxRate = (salary > 90000) ? 30 : 15;
            Console.WriteLine($"\nYou have to pay:{taxRate}%");
        }
    }
}
