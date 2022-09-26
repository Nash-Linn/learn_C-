using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.交换变量
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //用中间变量

            int n1 = 10;
            int n2 = 20;
            //int temp = n1;
            //n1 = n2;
            //n2 = temp;


            //不用中间变量

             n1 = n1 - n2;
             n2 = n1 + n2;
             n1 = n2 - n1;


            Console.WriteLine("n1:{0},n2:{1}", n1, n2);
            Console.ReadKey();

        }
    }
}
