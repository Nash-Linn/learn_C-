using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.if结构
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //编程实现：如果跪键盘的时间大于60分钟，那么媳妇奖励我晚饭不用做了
            Console.WriteLine("请输入你跪键盘的时间");
            int mins = Convert.ToInt32(Console.ReadLine());

            //如果跪键盘的时间 > 60 则不做晚饭

            if(mins > 60 )
            {
                Console.WriteLine("好老公不用跪键盘了");
            }
            else
            {
                Console.WriteLine("做饭去吧");
            }

            Console.ReadLine();

        }
    }
}
