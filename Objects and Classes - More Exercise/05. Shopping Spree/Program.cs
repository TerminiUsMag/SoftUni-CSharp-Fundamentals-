using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Shopping_Spree
{
    class Employee
    {
        public Employee(string name, double salary, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Department = department;
        }
        public string Department { get; set; }
        public double Salary { get; set; }
        public string Name { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = inputs[0];
                double salary = double.Parse(inputs[1]);
                string department = inputs[2];

                var newEmployee = new Employee(name, salary, department);

                employees.Add(newEmployee);
            }
        }
    }
}
