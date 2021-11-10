using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int userAge = Convert.ToInt32(Console.ReadLine());
            int year = 2021 - userAge;
            Console.WriteLine("You were born in " + year +".");
        }
    }
}
