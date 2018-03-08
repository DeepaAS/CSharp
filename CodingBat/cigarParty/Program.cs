using System;

namespace cigarParty
{
    class MainClass
    {
        public static bool cigParty(int cigars, Boolean isWeekend)
        {
            return ((cigars >= 40 && cigars <= 60) && !isWeekend) || ((cigars >= 40) && isWeekend);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(cigParty(30, false));
            Console.WriteLine(cigParty(50, false));
            Console.WriteLine(cigParty(70, true));
            Console.WriteLine((cigParty(20, true)));
        }
    }
}
