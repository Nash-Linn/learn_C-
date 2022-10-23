using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.枚举和int以及string类型之间的转换
{
    public enum QQState
    {
        OnLine=1,
        OffLine,
        Leave,
        Buys,
        QMe
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

            #region 将 枚举类型 强转为 int类型
            //QQState state = QQState.OnLine;
            ////枚举类型默认可以跟int类型互相转换 枚举类型跟int类型是兼容的
            //int n = (int)state;
            //Console.WriteLine(n);
            //Console.WriteLine((int)QQState.OffLine);
            //Console.WriteLine((int)QQState.Leave);
            //Console.WriteLine((int)QQState.Buys);
            //Console.WriteLine((int)QQState.QMe);
            //Console.ReadLine();
            #endregion

            #region 将 int类型 强转为 枚举类型
            //int n1 = 3;
            //QQState state = (QQState)n1;
            //Console.WriteLine(state);
            //Console.ReadLine();
            #endregion

            #region 将 枚举类型 强转为 string类型
            //所有的类型都能转换为string类型
            //int n1 = 10;
            //double n1 = 3.14;
            //string s = n1.ToString();
            //Console.WriteLine(s);
            //Console.ReadLine();

            //QQState state = QQState.OnLine;
            //Console.WriteLine(state.ToString());
            //Console.ReadLine();
            #endregion


            #region  将 string类型 转换为 枚举类型
            string s = "0";
            //将 s 转换为枚举类型
            //调用parse()方法的目的就是为了让它帮助我们将一个字符串转换成对应的枚举类型

            QQState state = (QQState)Enum.Parse(typeof(QQState),s);
            Console.WriteLine(state);

            #endregion


            //枚举类型
            //提示用户选择一个在线状态,我们接收,并将用户的输入转换成枚举类型
            //再次打印到控制台中

            Console.WriteLine("请选择您的qq在线状态 1-Online 2-OffLine 3-Leave 4-Busy 5-QMe");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    QQState s1 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的在线状态是{0}",s1);
                    break;
                case "2":
                    QQState s2 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的在线状态是{0}", s2);
                    break;
                case "3":
                    QQState s3 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的在线状态是{0}", s3);
                    break;
                case "4":
                    QQState s4 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的在线状态是{0}", s4);
                    break;
                case "5":
                    QQState s5 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的在线状态是{0}", s5);
                    break;
            }


            Console.ReadLine();
        }
    }
}
