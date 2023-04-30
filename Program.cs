using KeroFitness.BL.Controller;
using KeroFitness.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Greet();
            var name = Console.ReadLine();
            var userController = new UserController(name);
            Console.WriteLine(userController.CurrentUser);
            if (userController.IsNewUser)
            {
                Console.Write("Enter your gender:");
                var gender = Console.ReadLine();
                DateTime birthDate = ParseDataTime();
                var weight = ParseDouble("weight");
                var height = ParseDouble("height");

                userController.SetNewUserData(gender, birthDate, weight, height);






            }

        }

        private static DateTime ParseDataTime()
        {
            DateTime birthDate;
            while (true)
            {
                Console.Write("Enter your BirthDate (dd.MM.yyyy):");
                if (DateTime.TryParse(Console.ReadLine(), out birthDate))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect date format");
                }
            }

            return birthDate;
        }

        private static double ParseDouble(string name) 
        {
            while (true)
            {
                Console.Write($"Enter {name}:");
                if (double.TryParse(Console.ReadLine(), out double value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine($"Incorrect {name} format");
                }
            }
        }

        public static void Greet ()
        {
            Console.Write("Hi,this is a FitnessProgram");
            Console.WriteLine();
            Console.Write("Enter your UserName:");
        }
    }
}
