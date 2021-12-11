using System;
using System.Globalization;
using System.Collections.Generic;
using InheritanceAndEncapsulation.Entities;

namespace InheritanceAndEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEmployee #{i + 1} data:");
                Console.Write("Outsourced(Y/N): ");
                char outsourced = char.Parse(Console.ReadLine().ToUpper());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (outsourced == 'Y')
                {
                    Console.Write("Addicional charge: ");
                    double addicionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    employees.Add(new OutsourceEmployee(name, hours, valuePerHour, addicionalCharge));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }

            }
            Console.WriteLine("\n\nPayments");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }

        }


    }
}