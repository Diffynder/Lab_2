using System;

namespace t2
{
    internal class Program
    {
        public delegate int D1();

        public static Random random = new Random();
        public static int Random1() => random.Next(1, 5);
        static void Main(string[] args)
        {
            D1[] array = new D1[5];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Random1;
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadKey();
        }
    }
}
