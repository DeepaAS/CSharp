using System;

namespace extraEnd
{
    class MainClass
    {
        public static String threeCopystr(String str)
        {
            String lasttwochar = str.Substring(str.Length - 2);
            String str2 = str.Insert(str.Length, lasttwochar);
            String output = str2.Insert(str2.Length, lasttwochar);
            return output;
        }

        public static void Main(string[] args)
        {
            string output = threeCopystr("lo");
            Console.WriteLine(output);
        }
    }
}
