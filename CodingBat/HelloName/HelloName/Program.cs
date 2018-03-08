using System;

namespace HelloName
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string Name = Console.ReadLine();
            Console.WriteLine("Hello {0}!", Name);
        }
    }
}
