using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.接收用户的输入
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你的名字:");
            //我们还想要接受你输入的姓名
            //接受用户在控制台的输入
            string name = Console.ReadLine();

            Console.WriteLine("你的名字是{0}", name);
            Console.ReadKey();


            //
        }
    }
}
