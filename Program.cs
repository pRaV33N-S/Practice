using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            char gender;
            double salary;
            DateTime doj;
            Console.WriteLine("Enter ID");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Gender");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Salary");
            salary = double.Parse(Console.ReadLine());
            Console.WriteLine("DOJ");
            doj = DateTime.Parse(Console.ReadLine());

            if (salary > 90000)
                Console.WriteLine("You have to pay 30%");
            else
                Console.WriteLine("You have to pay 15%");
            Console.ReadKey();
        }
    }
}