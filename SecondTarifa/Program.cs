using System;

namespace SecondTarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://open.kattis.com/problems/tarifa

            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());

            int sum = 0;
            int[] thirds = new int[second];
            for (int i = 0; i < thirds.Length; i++)
            {
                thirds[i] = int.Parse(Console.ReadLine());
                sum = sum + thirds[i];
            }

            var res = NextMonth(first, second, sum);
            Console.WriteLine(res);
        }
        private static int NextMonth(int a, int b, int s)
        {
            return (a * (b + 1) - s);
        }
    }
}
