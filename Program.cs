using System;
using System.Collections.Generic;

namespace Ex_Listas {
    class Program {
        static void Main(string[] args) {

            Console.Write("How many employees will be registered? ");
            int qtdEmployees = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            Console.WriteLine("------------------");
            for (int i = 0; i < qtdEmployees; i++) {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                employees.Add(new Employee(id, name, salary));
            }

            Console.WriteLine("------------------");

            Console.Write("Enter the employee id that will have salary increase: ");
            int employeeId = int.Parse(Console.ReadLine());

            Console.WriteLine("------------------");

            Console.Write("Enter the percentage: ");
            double percentage = double.Parse(Console.ReadLine());


            var employeeFound = employees.Find(item => item.Id == employeeId);
            employeeFound.changeSalary(percentage);

            Console.WriteLine("------------------");

            foreach (var employee in employees) {
                Console.WriteLine($"{employee.Id},{employee.Name},{employee.Salary}");
            }

        }
    }
}
