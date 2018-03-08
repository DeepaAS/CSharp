using System;

namespace makeOutWord
{
    class MainClass
    {
        public static String mOutWord(String outstr, String word)
        {
            String outword = outstr.Insert(2, word);
            return outword;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the outWord: ");
            string OWordInput = Console.ReadLine();
            Console.WriteLine("Enter the word: ");
            string wordInput = Console.ReadLine();
            String output = mOutWord(OWordInput, wordInput);
            Console.WriteLine(output);
        }
    }
}
