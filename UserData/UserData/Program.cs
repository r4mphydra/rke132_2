using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your year of birth.");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());
            int userAge = 2021 - yearOfBirth;
            Console.WriteLine("You are " + userAge + " years old.");
        }
    }
}
