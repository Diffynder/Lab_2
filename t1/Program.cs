using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1
{
    internal class Program
    {
        public delegate double DDel(double firstNum, double secondNum,double thirdNum);
        static void Main(string[] args)
        {
            DDel doubDel = delegate (double firstNum, double secondNum, double thirdNum)
            {
                double res = (firstNum + secondNum + thirdNum) / 3;
                return res;
            };

            Console.WriteLine($"Середнє арифметичне чисел = {doubDel(10, 12, 20)}");
        }
    }
}
