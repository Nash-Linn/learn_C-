using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.三元表达式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //计算两个数字的大小，求最大

            Console.WriteLine("请输入第一个数字");
            int n1 =  Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("请输入第二个数字");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(n1 > n2 ? n1 : n2);
            Console.ReadLine();
        }
    }
}
