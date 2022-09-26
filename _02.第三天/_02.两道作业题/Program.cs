using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.两道作业题
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //练习，计算46天是几周零几天
            //int days = 46;
            //int weeks = days / 7;
            //int day = days % 7;
            //Console.WriteLine("{0}天是{1}周零{2}天",days,weeks,day);
            //Console.ReadLine();



            //107653秒是几天几小时几分钟几秒

            //60 * 60   3600 * 24 = 86400

            int time = 107653;
            int day_num = time / 86400;
            int hours = time % 86400 / 3600;
            int minute = (time % 86400 % 3600) / 60;
            int second = time % 86400 % 3600 % 60;
            Console.WriteLine("{0}秒是{1}天{2}小时{3}分钟{4}秒", time, day_num, hours, minute, second);
            Console.ReadLine();


            //int seconds = 107653;
            //int days = seconds / 86400;
            //int secs = seconds % 86400;
            //int hours = secs / 3600;
            //secs = secs % 3600;
            //int mins = secs / 60;
            //secs = secs % 60;
            //Console.WriteLine("{0}秒是{1}天{2}小时{3}分钟{4}秒", seconds, days, hours, mins, secs);
            //Console.ReadLine();  //107653秒是1天5小时54分钟13秒
        }
    }
}
