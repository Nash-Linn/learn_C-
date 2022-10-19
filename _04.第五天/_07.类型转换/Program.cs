using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.类型转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int numberOne = Convert.ToInt32("123");


            //int.Parse  类似 Convert.ToInt32
            //int number = int.Parse("123");
            //Console.WriteLine(number);
            //Console.ReadLine();


            int number = 0;
            bool b = int.TryParse("123", out number);
            Console.WriteLine(b);
            Console.WriteLine(number);

            Console.ReadLine();   
        }
    }
}
