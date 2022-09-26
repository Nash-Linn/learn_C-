using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.两个项目
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //有个叫卡卡西的人在旅店登记的时候前台让他填一张表
            //这张表里的内容要存到电脑上,
            //有姓名 年龄 邮箱 家庭住址 工资
            //之后把这些信息显示出来
            string name = "卡卡西";
            int age = 30;
            string email = "kakaxi@qq.com";
            string address = "火影村";
            decimal salary = 5000m;
            Console.WriteLine("我叫" + name + "我住在" + address + "我今年" + age + "岁了" + "我的邮箱是" + email + "我的工资是" + salary);

            Console.ReadKey();


            
        }
    }
}
