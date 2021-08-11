using System;

namespace dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Randomnumbergenerator());

            Console.ReadKey();

        }
        public class Randomnumbergenerator() {
            int face1;
            int face2;

                face1 = random.Next(1, 7);

                face2 = random.Next(1, 7);
            return face1 + face2 ;

            }


        }


    }
}
    
