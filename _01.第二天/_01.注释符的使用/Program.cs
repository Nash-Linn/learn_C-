using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.注释符的使用
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //注释

            //单行注释

            /**
             * 多行注释
             * 
             */

            /*
            Console.WriteLine("注释");
            Console.WriteLine("注释");
            Console.WriteLine("注释");
            */

            ///文档注释  用来描述类和方法

        }

        /// <summary>
        /// 这个方法的作用就是求两个整数之间的最大值
        /// </summary>
        /// <param name="n1">第一个整数</param>
        /// <param name="n2">第二个整数</param>
        /// <returns>返回比较大的那个数字</returns>
        public static int GetMax(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;
        }


    }

    /// <summary>
    /// 这个类用来描述一个人的信息 从 姓名 性别 年龄描述
    /// </summary>
    public class Person
    {
        public string Name
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }

        public char Gender
        {
            get;
            set;
        }

    }
}
