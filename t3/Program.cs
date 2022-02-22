using System;

namespace TASK3
{
    class Program
    {
        public delegate int MyDelegate(int firstNum, int secondNum);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = (int x, int y) => { return x + y; };
            MyDelegate myDelegate2 = (int x, int y) => { return x - y; };
            MyDelegate myDelegate3 = (int x, int y) => { return x * y; };
            MyDelegate myDelegate4 = (int x, int y) => { return x / y; };


            Console.Write("\n");
            Console.Write("Введите знак операции (+, -, *, /) ");
            string sign = Console.ReadLine();
            Console.Write("\n");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (sign == "+")
            {
                Console.WriteLine($"{a} + {b} = {myDelegate(a,b)}");
            }
            else if (sign == "-")
            {
                Console.WriteLine($"{a} - {b} = {myDelegate2(a, b)}");
            }
            else if (sign == "*")
            {
                Console.WriteLine($"{a} * {b} = {myDelegate3(a, b)}");
            }
            else if (sign == "/")
            {
                 Console.WriteLine($"{a} / {b} = {myDelegate4(a, b)}");
            }
        }
    }
}
