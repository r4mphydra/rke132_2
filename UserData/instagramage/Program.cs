using System;

namespace instagramage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your age:");
            int userage = Convert.ToInt32(Console.ReadLine());
            if(userage > 12)
            {
                Console.WriteLine("You are allowed to use instagram.");
            }
            else if(userage < 12)
            {
                Console.WriteLine("Unfortunately, you are not allowed to use instagram.");
            }
            else
            {
                Console.WriteLine("You are allowed to use instagram.");
            }
            Console.WriteLine("Have a good day.");
        }
    }
}
