using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.异常捕获
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //语法上没有错误，在程序运行过程中，由于某些原因程序出现了错误，不能再正常的运行

            Console.WriteLine("请输入一个数字");
            int number = 0;  //声明变量
            bool b = true;
            try
            {
                number = Convert.ToInt32(Console.ReadLine()) * 2;  //赋值
                //Console.WriteLine(number);  //使用
            }
            catch
            {
                Console.WriteLine("输入的内容不能够转换成数字");
                b = false;
            }
            if (b)
            {
                Console.WriteLine(number);  //使用
            }
            
           
            Console.ReadLine();


            //try catch
            //执行过程： 如果try中的代码没有出现异常，那么catch中的代码不会执行
            //如果try中代码出现异常，就算他后面还有100行代码也不会执行，会直接跳到catch中


            //变量的作用域
            //变量的作用域就是你能够使用这个变量的范围
            //变量的作用域一般从声明他的那个括号开始到那个括号对应的结束的括号结束
            

        }
    }
}
