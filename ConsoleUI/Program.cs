using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string formatedName;
            Console.Write("What is your name: ");
            string name = Console.ReadLine();

            Console.Write("What is your age: ");
            string ageText = Console.ReadLine();

            bool isValidAge = int.TryParse(ageText, out int age);

            if (name.ToLower() == "brice" || name.ToLower() == "donald")
            {
                formatedName = $"Professor {name}";
            }
            else
            {
                formatedName = name;
            }

            if (age < 21)
            {
                Console.WriteLine($"I recommend you to wait {21 - age} year(s) for this course {formatedName}");
            }
            else
            {
                Console.WriteLine($"Welcome to the course {formatedName}");
            }
            Console.ReadLine();
        }
    }
}
