using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.break关键字的用法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;  
            while(i < 10)
            {
              
                while ( j < 10)
                {
                    j++;

                    if (j > 5)
                    {
                        break;
                    }
                    Console.WriteLine("我是里面的循环{0}-{1}",i,j);

                    //break只能跳出当前循环
                    //break;
                }

                i++;
                j = 0;
                Console.WriteLine("我是外面的循环{0}-{1}", i, j);
            }
            Console.ReadLine();
        }
    }
}
