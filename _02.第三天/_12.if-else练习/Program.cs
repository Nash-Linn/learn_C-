using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.if_else练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //比较三个数的大小

            Console.WriteLine("请输入第一个数字");
            int numberOne = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("请输入第二个数字");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第三个数字");
            int numberThree = Convert.ToInt32(Console.ReadLine());

            if(numberOne > numberTwo)
            {
                if(numberOne > numberThree)
                {
                    Console.WriteLine(numberOne);
                }
                else
                {
                    Console.WriteLine(numberThree);
                }
            }
            else
            {
                if(numberTwo > numberThree)
                {
                    Console.WriteLine(numberTwo);
                }
                else
                {
                    Console.WriteLine(numberThree);
                }
            }
            Console.ReadLine();
        }
    }
}
