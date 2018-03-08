using System;

namespace makeAbba
{
    class MainClass
    {
        public static String Abba(String str1, String str2)
        {
            String str3 = str1.Insert(str1.Length, str2);
            String str4 = str3.Insert(str3.Length, str2);
            String str5 = str4.Insert(str4.Length, str1);
            return str5;
        }

        public static void Main(string[] args)
        {
            String output = Abba("x", "y");
            Console.WriteLine(output);

        }
    }
}
