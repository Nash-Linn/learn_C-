using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.for循环练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //求1-100之间的所有整数和 偶数和 奇数和


            //int sum = 0;
            //int odd = 0;
            //int even = 0;
            //for (int i = 0; i <= 100; i++)
            //{   
            //    if(i % 2 == 0)
            //    {
            //        even += i;
            //    }
            //    else
            //    {
            //        odd += i;
            //    }
            //}
            //sum = even + odd;

            //Console.WriteLine(sum);
            //Console.WriteLine(odd);
            //Console.WriteLine(even);
            //Console.ReadLine();


            //找出100 - 999间的水仙花数？
            //水仙花数指的是 
            //百位的立方 + 十位的立方 + 各位的立方 == 当前这个数字

            for (int i =100; i <= 999; i++)
            {
                int bai = i / 100;
                int shi = i % 100 / 10;
                int ge = i % 10;
                if( Math.Pow(bai, 3) + Math.Pow(shi, 3) + Math.Pow(ge, 3) == i)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
