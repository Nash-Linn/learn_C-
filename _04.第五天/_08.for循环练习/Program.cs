using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.for循环练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            bool b = true;
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("请输入第{0}个人的成绩",i);

                try {
                    int score = Convert.ToInt32(Console.ReadLine());
                    if (score >= 0 && score <= 100)
                    {
                        sum += score;
                    }
                    else
                    {
                        Console.WriteLine("输入的成绩不在正确范围内，程序退出");
                        b = false;
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("输入的成绩不在正确范围内，程序退出");
                    b = false;
                    break;
                }
            }
            if (b)
            {
                Console.WriteLine("5个人的平均成绩是{0}", sum / 5);
            }

            Console.ReadLine();
        }
    }
}
