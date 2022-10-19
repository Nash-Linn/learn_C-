using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.switch_case练习
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //让用户输入姓名，然后显示出这个人上辈子是什么职业
            Console.WriteLine("请输入一个姓名，我们将显示出这个人上辈子的职业");

            string name = Console.ReadLine();
            //老杨、老苏、老马

            switch (name)
            {
                case "老秦":      //老秦和老杨的结果一样 可以省略上面的老秦
                case "老杨":
                    Console.WriteLine("上辈子是抽大烟的");
                    break;
                case "老苏":
                    Console.WriteLine("上辈子是个老鸨");
                    break;
                case "老马":
                    Console.WriteLine("上辈子是个老苏手下");
                    break;
                default:
                    Console.WriteLine("不认识");
                    break;
            }

            Console.ReadLine();
        }
    }
}
