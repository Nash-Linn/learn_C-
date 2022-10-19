using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.continue练习
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //用while continue 实现计算1到100(含)之间的除了能被7整除之外的所有整数 

            int i = 1;
            int sum = 0;
            while(i <= 100)
            {
                if (i % 7 == 0)
                {
                    i++;
                    continue;
                }
                sum += i;
                i++;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
