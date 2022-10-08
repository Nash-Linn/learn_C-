using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.convert类型转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //提示用户输入一个数字，接收并向控制台打印用户输入的这个数字的二倍

            //Console.WriteLine("请输入一个数字");
            //string strNum = Console.ReadLine();
            ////将用户输入的字符串转换成int类型或者double 类型
            ////Convert.ToInt32
            //double number = Convert.ToDouble(strNum);
            //Console.WriteLine(number * 2);
            //Console.ReadKey();

            Console.WriteLine("请输入一个数字");
            Console.WriteLine(Convert.ToDouble(Console.ReadLine()) * 2);
            Console.ReadKey();
        }
    }
}
