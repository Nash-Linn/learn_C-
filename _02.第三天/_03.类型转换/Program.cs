using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.类型转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //显示类型转换、自动类型转换
            //int -> double double -> int

            //类型如果相兼容的两个变量，可以使用自动类型转换或者强制类型转换
            //但是，如果两个类型的变量不兼容，比如string与int或者string与double
            //这个时候我们可以使用一个叫Convert的转换工厂进行转换
            //注意，使用Convert进行类型转换，也需要满足一个条件：
            //面儿上必须要过的去

            


            string s = "123";
            //将字符串转换成int或者double类型
            double d = Convert.ToDouble(s);
            int i = Convert.ToInt32(s);

            Console.WriteLine(d);
            Console.ReadLine();



            //让用户输入姓名 语文 数学 英语 三门课的成绩
            //然后给用户显示： XX，你的总成绩为XX分，平均成绩为XX分
            Console.WriteLine("请输入你的姓名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入你的语文成绩");
            string strChinese = Console.ReadLine();
            Console.WriteLine("请输入你的数学成绩");
            string strMath = Console.ReadLine();
            Console.WriteLine("请输入你的英语成绩");
            string strEnglish = Console.ReadLine();


            //由于字符串去相加的话，最终会变成相连接，如果要拿字符串类型的变量参与计算
            //需要将字符串转换成int或者double类型

            //int chinese = Convert.ToInt32(strChinese);
            //int math = Convert.ToInt32(strMath);
            //int english = Convert.ToInt32(strEnglish);

            double chinese = Convert.ToDouble(strChinese);
            double math = Convert.ToDouble(strMath);
            double english = Convert.ToDouble(strEnglish);


            Console.WriteLine("{0}，你的总成绩为{1}分，平均成绩为{2}分",name,chinese+math+english,(chinese + math + english)/3);
            Console.ReadKey();
        }
    }
}
