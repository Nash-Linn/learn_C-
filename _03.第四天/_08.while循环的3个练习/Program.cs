using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.while循环的3个练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //输入班级人数，然后依次输入学员成绩，计算班级学员的平均成绩和总成绩
            //10
            //循环体：提示输入学员成绩，接收，并转换成整数类型，累加到总成绩当中
            //循环条件：循环的次数小于等于班级人数

            Console.WriteLine("请输入班级人数");
            int count = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int i = 1;
            while(i <= count)
            {
                Console.WriteLine("请输入第{0}个学员的考试成绩",i);
                int score = Convert.ToInt32(Console.ReadLine());    
                //表示把每个学员的成绩累加到总成绩
                sum += score;
                i++;
            }
            Console.WriteLine("{0}个人的班级总成绩是{1}，平均成绩是{2}", count, sum, sum/count);
            Console.ReadLine();
        }
    }
}
