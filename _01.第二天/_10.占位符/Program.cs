using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.占位符
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            int n1 = 10;
            int n2 = 20;
            int n3 = 30;

            //挖几个坑填几个  多填了,没异常  少填了,抛异常
            
            //输出顺序
            //占位符 按照挖坑的顺序输出
            Console.WriteLine("第一个数字是:{0},第二个数字是:{1},第三个数字是:{2}",n1,n2,n3);
            Console.ReadKey();


            //异常
            //异常是指:语法上并没有任何错误,只不过在程序运行的期间,由于某些原因出现了问题,
            //        使程序不能再正常的运行
        }
    }
}
