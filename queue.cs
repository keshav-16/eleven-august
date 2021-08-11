using System;

namespace ques2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = new int[3];

            for (int i = 0; i < 3; i++)
            {
                arr2[i] = arr1[2 - i];
            }
            for (int j = 0; j < 3 ; j++){
                Console.WriteLine(arr2[j]);
          }
            Console.ReadLine();
        }
    }
}
