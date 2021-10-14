using System;

namespace Looping_Construct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter Your Name\n");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Your Email...\n");
            string email = Console.ReadLine();

            Console.WriteLine("Enter Your MobileNo...\n");
            int MobileNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name is" + name + " Your Email is" + email + " Your MobileNo is" + MobileNo);
        }
    }
}
