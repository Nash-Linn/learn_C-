using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.变量
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //变量类型  变量名
            //变量名 = 值


            int number;
            number = 100;
            Console.WriteLine(number);

            //数据类型

            //整数类型 int 只能存储整数，不能存储小数
            //小数类型 double 既能存储整数，也能存储小数，小数点后面的位数 15——16位
            //金钱类型 decimal 用来存储金钱，值后面需要加一个m
            //字符串类型 string 可以存储空 值需要用 ""
            //字符类型 char 用来存储单个字符 最多，最少只能有一个字符，不能存储空 需要用''








            //整数
            int n = 100 ;

            //双精度浮点数
            double d = 3.14;

            //字符串
            string zsName = "张三";

            //字符
            char gender = '男' ;

            //decimal  需要加m 
            //精度更高和更小的范围  适合财务和货币计算
            decimal money = 5000m ;
        }
    }
}
