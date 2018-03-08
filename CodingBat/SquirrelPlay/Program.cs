using System;

namespace SquirrelPlay
{
    class MainClass
    {
        public static bool SPlay(int temp, bool isSummer)
        {
            return (((temp >= 60 && temp <= 90) && !isSummer) || ((temp >= 60 && temp <= 100) && isSummer));
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(SPlay(70, false));
            Console.WriteLine(SPlay(95, false));
            Console.WriteLine(SPlay(95, true));
        }
    }
}
