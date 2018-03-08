using System;

namespace firstHalf
{
    class MainClass
    {
        public static String halfStr(String str)
        {
            String output = string.Empty;
            if (str.Length % 2 == 0)
            {
                int index = (str.Length / 2);
                output = str.Substring(0, index);
            }
            else
            {
                Console.WriteLine("Length of your string is not even");
            }
            return output;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string of even length: ");
            String input = Console.ReadLine();
            String output = halfStr(input);
            Console.WriteLine("Substring is: {0}", output);
        }
    }
}
