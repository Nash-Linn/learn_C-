using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.类型转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 3;
            int d = n1 / n2;  
            Console.WriteLine(d);   //3
            Console.ReadKey();

            int a1 = 10;
            int a2 = 3;
            double a3 = a1 / a2;
            Console.WriteLine(a3);  //3
            Console.ReadKey();


            int b1 = 10;
            int b2 = 3;
            double b3 = b1*1.0 / b2;
            Console.WriteLine(b3);  //3.333333
            Console.ReadKey();


            double c1 = 10;
            int c2 = 3;
            double c3 = c1  / c2;
            Console.WriteLine(c3);  //3.333333
            Console.ReadKey();

            double d1 = 10;
            int d2 = 3;
            double d3 = d1 / d2;
            Console.WriteLine("{0:0.00}",d3);  //3.33  冒号后跟0.00 表示保留两位
            Console.ReadKey();

        }
    }
}
