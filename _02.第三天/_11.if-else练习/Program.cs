using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.if_else练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //      成绩 >= 90 :   A
            // 90 > 成绩 >= 80 :   B 
            // 80 > 成绩 >= 70 :   C 
            // 70 > 成绩 >= 60 :   D 
            // 60 > 成绩       :   E

            Console.WriteLine("请输入学员的考试成绩");
            int score = Convert.ToInt32(Console.ReadLine());

            #region if的做法
            //if (score >= 90)
            //{
            //    Console.WriteLine("A");
            //}
            //if (score >= 80 && score < 90)
            //{
            //    Console.WriteLine("B");
            //}
            //if (score >= 70 && score < 80)
            //{
            //    Console.WriteLine("C");
            //}
            //if (score >= 60 && score < 70)
            //{
            //    Console.WriteLine("D");
            //}
            //if ( score < 60)
            //{
            //    Console.WriteLine("E");
            //}
            #endregion


            //if-else
            //if (score >= 90)
            //{
            //    Console.WriteLine("A");
            //}
            //else
            //{
            //    if (score >= 80 )
            //    {
            //        Console.WriteLine("B");
            //    }
            //    else
            //    {
            //        if (score >= 70 )
            //        {
            //            Console.WriteLine("C");
            //        }
            //        else
            //        {
            //            if (score >= 60 && score < 70)
            //            {
            //                Console.WriteLine("D");
            //            }
            //            else
            //            {
            //                Console.WriteLine("E");
            //            }
                       
            //        }
                   
            //    }
              
            //}




            //if  else-if 
            if (score >= 90)
            {
                Console.WriteLine("A");
            }
            else if (score >= 80 )
            {
                Console.WriteLine("B");
            }
            else if (score >= 70 )
            {
                Console.WriteLine("C");
            }
            else if (score >= 60 )
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("E");
            }




            Console.ReadLine();
        }
    }
}
