using System;
using BmiOp.Entities;
using BmiOp.Exceptions;
using System.Globalization;
namespace BmiOp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("BMI Calulator");

                Console.WriteLine();
                Console.Write("Gender: [M/F] ");
                string gender = Console.ReadLine().ToUpper();

                if (gender == "F")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Age: ");
                    int age = int.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Weight: ");
                    double weight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine();
                    Female female = new(name, age, height, weight);
                    Console.WriteLine(female);
                }
                else if (gender == "M")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Age: ");
                    int age = int.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Weight: ");
                    double weight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine();
                    Male male = new(name, age, height, weight);
                    Console.WriteLine(male);
                }
                else
                {
                    throw new DomainExceptions(" -> F or M ");
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            catch (DomainExceptions e)
            {
                Console.WriteLine("Error: Invalid option" + e.Message);
            }
        }
    }
}
