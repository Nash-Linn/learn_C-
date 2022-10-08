using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.逻辑运算符练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //让用户输入老苏的语文和数学成绩，输出一下判断是否正确，
            //正确输出True，错误输出False

            Console.WriteLine("小苏，输入你的语文成绩");

            int chinese = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("小苏，输入你的数学成绩");

            int math = Convert.ToInt32(Console.ReadLine());

            //bool b =  chinese > 90 && math > 90;

            bool b = chinese > 90 || math > 90;

            Console.WriteLine(b);
            Console.ReadLine();

        }
    }
}
