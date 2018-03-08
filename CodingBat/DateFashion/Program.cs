using System;

namespace DateFashion
{
    class MainClass
    {
        public static int DFashion(int you, int date)
        {
            int seat = 0;

            if (you >= 8 || date >= 8)
            {
                seat = 2;
            }
            else if (you <= 2 || date <= 2)
            {
                seat = 0;
            }
            else
            {
                seat = 1;
            }
            return seat;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(DFashion(5, 10));
            Console.WriteLine(DFashion(5, 2));
            Console.WriteLine(DFashion(5, 5));
        }
    }
}
