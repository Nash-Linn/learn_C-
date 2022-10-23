using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.continue练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //找出100内的所有素数

            for (int i = 2; i <= 100; i++)
            {
                bool b = true;
                for (int j = 2; j < i; j++)
                {
                    //除尽了说明不是质数， 也没有必要往下继续取余的必要了
                    if(i % j == 0)
                    {
                        b = false;
                        break;
                    }
                }
                if (b)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
