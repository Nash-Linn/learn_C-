using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_do_while循环
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //明天小兰就要登台演出了，老师说再把明天演出的歌曲唱一遍
            //如果满意，小兰就可以回家了，否则就需要再练习一遍，直到老师满意为止（y/n)


            //循环体：小兰唱了一遍，问老师 满意吗 ？ 老师回答
            //循环条件：老师不满意


            //Console.WriteLine("老师我唱的你满意么？");
            //string answer = Console.ReadLine();
            //while(answer == "no")
            //{
            //    Console.WriteLine("老师，我再唱一遍，你满意么？");
            //    answer = Console.ReadLine();
            //}

            //Console.ReadLine();




            //遇见这种首先执行一遍的循环体，拿着执行后的结果再去判断是否执行循环的循环

            //do-while 循环 
            string answer = "";

            do
            {
                Console.WriteLine("老师，我唱的你满意么？yes/no");
                answer = Console.ReadLine();

            } while (answer == "no");

            Console.WriteLine("OK,放学回家");
            Console.ReadLine();

        }
    }
}
