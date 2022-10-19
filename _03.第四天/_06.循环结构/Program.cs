using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.循环结构
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //向控制台打印1000遍 下次考试我一定细心

            //while 循环
            //int i = 0;
            //while (i < 100){
            //    Console.WriteLine("下次一定");
            //    i++;
            //}
            //Console.ReadLine();


            int sum = 0;
            int i = 1;
            while (i <= 100)
            {   
                if(i%2 == 0)
                {
                    sum += i;
                }
                
                i++;
            }
            Console.WriteLine(sum);
            Console.ReadLine();

        }
    }
}
