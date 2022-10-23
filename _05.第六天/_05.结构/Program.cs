using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.结构
{

    public struct Person
    {
        public string _name;   //字段  //为区别字段和变量  名字前加 _
        public int _age;
        public Gender _gender;
    }

    public enum Gender
    {
        男,
        女
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //xx大学管理系统
            //姓名、性别、年龄、系别、年纪
            //string zsName = "张三";
            //int zsAge = 21;
            //char zsGender = '男';


            // 结构
            // 可以帮助我们一次声明多个不同类型的变量

            // 语法：
            // [public] struct 结构名
            // {
            //  成员;  //字段
            //  
            // }

            Person zsPerson;
            zsPerson._name = "张三";
            zsPerson._age = 21;
            zsPerson._gender = Gender.男;


            Person lsPerson;
            lsPerson._name = "李四";
            lsPerson._age = 22;
            lsPerson._gender = Gender.女;

            Console.WriteLine(zsPerson._name); 
            Console.ReadLine();

        }
    }
}
