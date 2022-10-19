using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.复习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //练习4：不断要求用户输入一个数字，然后打印这个数字的二倍，当用户输入q的时候退出

            string input = "";
            do
            {
                Console.WriteLine("请输入一个数字,我们将打印这个数字的二倍");
                //不能直接转换成int类型  因为用户有可能输入q
                input = Console.ReadLine();
                if (input != "q")
                {

                    try
                    {
                        int number = Convert.ToInt32(input);
                        Console.WriteLine("您输入的数字的2倍是{0}", number * 2);
                    }
                    catch
                    {
                        Console.WriteLine("输入的字符串不能转换成数字，请重新输入");
                    }
                }
                else
                {
                    Console.WriteLine("输入的是q，程序退出");
                }


            } while (input != "q");
        }
    }
}
