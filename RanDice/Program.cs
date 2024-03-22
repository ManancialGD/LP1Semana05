using System;

namespace RanDice
{
    class Program
    {
        static int n;
        static int s;
        static int sum;
        static void Main(string[] args)
        {
            n = int.Parse(args[0]);
            s = int.Parse(args[1]);

            sum = SumDice(n, s);
            Console.WriteLine(sum);
        }

        static int SumDice(int numberOfDice, int seed)
        {
            int tmpSum = 0;
            Random r = new Random(seed);
            for (int i = 0; i < numberOfDice; i++)
            {
                tmpSum += r.Next(1,7);
                Console.WriteLine(tmpSum);
            }
            return tmpSum;
        }
    }
}
