using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.算数运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   + - * / %
            //隐式类型转换   自动给类型转换
            // int -> double
            //转换条件  目标类型 大于 当前类型

            //显示类型转换   强制类型转换 
            // double -> int
            //强制类型转换 需要相关语法
            //转换条件 两种类型相兼容
            //语法： (待转换的类型）要转换的值；

            double d = 303.5;
            int n = (int)d;






            int n1 = 10;
            int n2 = 3;
            int result = n1 / n2;
            Console.WriteLine(result);


            int r = 5;
            double area = 3.14 * r * r;
            double perimeter = 2 * 3.14 * r;
            Console.WriteLine("圆的面积是{0}，周长是{1}",area,perimeter);
            Console.ReadKey();
        }
    }
}
