using System;

namespace diceroll
{
    class Program
    {
        public class Randomnumbergenerator
        {
            int topSide;
            int Sides = 6;
            Random random = new Random();
            public void setNum()
            {
                topSide = (random.Next(6) + 1);
               
            }
            public int getNum()
            {
                return topSide;
            }

        }
        static void Main(string[] args)
        {
            Randomnumbergenerator x = new Randomnumbergenerator();
           int num = x.getNum();
            int sum=0 ;
            int[] numarr = new int[2];
            Console.WriteLine("the random number is " + num);
            numarr[0] = x.getNum();
            numarr[1] = x.getNum();
            for (int i=0; i<2; i++)
            {
                sum += numarr[i];
            }
            Console.WriteLine("the total of the two dice is " + sum);
            Console.ReadLine();
        }
    }
}
