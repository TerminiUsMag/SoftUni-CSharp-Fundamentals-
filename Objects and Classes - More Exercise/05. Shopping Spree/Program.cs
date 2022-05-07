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

            //List<Employee> employees = new List<Employee>();

            var employeeDict = new Dictionary<string, List<Employee>>();

            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string name = inputs[0];
                double salary = double.Parse(inputs[1]);
                string department = inputs[2];

                var newEmployee = new Employee(name, salary, department);

                //employees.Add(newEmployee);
                if (!employeeDict.ContainsKey(department))
                {
                    employeeDict.Add(department, new List<Employee>());
                }
                employeeDict[department].Add(newEmployee);

            }
            double maxAverageSalaryForDepartment = 0;
            string nameOfMaxAverageSalaryDepartment = string.Empty;



            foreach (var departmentName in employeeDict)
            {
                double averageSalaryForDepartment = 0;
                foreach (var employee in departmentName.Value)
                {
                    averageSalaryForDepartment += employee.Salary;
                }
                averageSalaryForDepartment /= departmentName.Value.Count();
                if (maxAverageSalaryForDepartment < averageSalaryForDepartment)
                {
                    nameOfMaxAverageSalaryDepartment = departmentName.Key;
                }
                maxAverageSalaryForDepartment = Math.Max(averageSalaryForDepartment, maxAverageSalaryForDepartment);
            }
            Console.WriteLine($"Highest Average Salary: {nameOfMaxAverageSalaryDepartment}");
            foreach (var departmentName in employeeDict)
            {
                if (departmentName.Key == nameOfMaxAverageSalaryDepartment)
                {
                    var departmentNameValueSorted = departmentName.Value.OrderByDescending(x => x.Salary).ToList();
                    foreach (var employee in departmentNameValueSorted)
                    {
                        Math.Round(employee.Salary, 2);
                        Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
                    }
                }
            }
        }
    }
}
