using System;

namespace ArrayReverse
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the array elements[" + i + "]:");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(arr);
            //end 

            for (int i = 0; i < 3; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
