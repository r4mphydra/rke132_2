using System;

namespace DrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your year of birth:");
            int userage = Convert.ToInt32(Console.ReadLine());
            if (userage > 18)
            {
                Console.WriteLine("You are allowed to apply for the driving license.");
            }
            else if (userage < 18)
            {
                Console.WriteLine("Unfortunately, you are not allowed apply for the license.");
            }
            else
            {
                Console.WriteLine("Congratulations, you are allowed to apply for license");
            }
            Console.WriteLine("Have a good day.");
        }
    }
    }
