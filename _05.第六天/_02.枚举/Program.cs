using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.枚举
{
    public enum Gender
    {
        男,
        女
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //[public] enum 枚举名
            //{
            //    值1,
            //    值2,
            //    值3,
            //    ...
            //}

            //[] 代表可省略
            //public:访问修饰符。公开的公共的，哪都可以访问
            //enum:关键字 ，声明枚举的关键字
            //枚举名：要符合Pascal命名规范

            //将枚举声明到命名空间下面，类的外面，
            //表示这个命名空间下，所有的类都可以使用这个枚举


            //枚举就是一个变量类型
            //只是枚举声明、赋值、使用的方式跟那些普通的变量类型不一样

            //变量类型 变量名=值

            Gender gender = Gender.男;

            Console.WriteLine(gender);
            Console.ReadLine();

            //xx大学管理系统
            //姓名 性别 年龄 系别 年龄
            //性别

        }
    }
}
