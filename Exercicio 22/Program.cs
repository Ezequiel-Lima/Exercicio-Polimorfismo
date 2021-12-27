using Exercicio_22.Entities;
using System;
using System.Collections.Generic;

namespace Exercicio_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Employee> listEmployee = new List<Employee>();

                Console.Write("Enter the number of employees? ");
                int quantityEmployee = int.Parse(Console.ReadLine());

                for (int i = 0; i < quantityEmployee; i++)
                {
                    Console.WriteLine($"\nEmployee #{i + 1} data: ");
                    Console.Write("Outsourced (y/n)? ");
                    char typeEmployee = char.Parse(Console.ReadLine());
                    typeEmployee = char.ToUpper(typeEmployee);

                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());

                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine());

                    if (typeEmployee == 'N')
                    {
                        Employee employee = new Employee(name, hours, valuePerHour);
                        listEmployee.Add(employee);
                    }
                    else if (typeEmployee == 'Y')
                    {
                        Console.Write("Additional charge: ");
                        double additional = double.Parse(Console.ReadLine());
                        Employee outsourcedEmployee = new OutsourcedEmployee(name, hours, valuePerHour, additional);
                        listEmployee.Add(outsourcedEmployee);
                    }
                    else
                    {
                        Console.Write("Error");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }

                Console.WriteLine("\nPAYMENTS: ");
                foreach (var item in listEmployee)
                {
                    Console.WriteLine(item.Name + " - $ " + item.Payment().ToString("F2"));
                }

                Console.ReadKey();
            }
            catch (Exception error)
            {
                Console.WriteLine($">{error.Message}");
                Console.ReadKey();
            }
        }
    }
}
