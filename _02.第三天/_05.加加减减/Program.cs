using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.加加减减
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            //number++;
            ++number;
            Console.WriteLine(number);
            Console.ReadKey();

            //++:分为前++和后++，不管是前++还是后++，最终的结果都是给这个变量加1。
            //区别表现在表达式中，如果是前++，则先给变量自身加一，然后带着这个加一后的值去参与运算。
            //                  如果是后++, 则先拿原值参与运算，运算完成后，再将这个变量自身加1。
            // --同上 



            int a = 5;
            int b = a++ + ++a * 2 + --a + a++;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();


            //  5          a = 6
            //  7*2        a = 7
            //  6          a = 6 
            //  6          a = 7
            //  a = 7 b = 31



        }
    }
}
