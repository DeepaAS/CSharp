using System;

namespace ReverseArray
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string output = string.Empty;
            string[] inpArr = Console.ReadLine().Split(new char[] { ',' });
            Array.Reverse(inpArr);
            foreach (var i in inpArr)
            {
                if (i.Length != 0)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
            }
        }
    }
}
