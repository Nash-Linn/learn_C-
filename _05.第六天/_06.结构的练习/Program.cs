using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.结构的练习
{
    public struct MyColor
    {
        public int _red;
        public int _green;
        public int _blue;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //定义一个结构叫 MyColor ,有三个成员,分别定义为int类型的 red green blue
            //声明一个 MyColor类型的变量,并对其成员赋值,使MyColor可以表示成一个红色

            MyColor mc;
            mc._red = 255;
            mc._blue = 0;
            mc._green = 0;


            
        }
    }
}
