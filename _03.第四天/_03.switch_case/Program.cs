using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _03.switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //李四的年终工作评定，如果定为A级，则工资涨500元
            //                  如果定为B级，则工资涨200元
            //                  如果定为C级，则工资不变
            //                  如果定为D级，则工资降200元
            //                  如果定为E级，则工资降500元
            //设李四的原工资为5000，请用户输入李四的评级,然后显示李四来年的工资

            double salary = 5000;
            Console.WriteLine("请输入对李四的年终评定");
            string level = Console.ReadLine();
            bool b = true;
            switch (level){
                case "A":
                        salary += 500;
                        break;
                case "B":
                        salary += 200;
                        break;
                case "C":
                        break;
                case "D":
                    
                        salary -= 200;
                        break;
                case "E":
                        salary -= 500;
                        break;
                    
                default:
                    b = false;
                    break;
            }

            if (b)
            {
                Console.WriteLine("李四明年的工资为{0}", salary);
            }
            else
            {
                Console.WriteLine("输入评级有误");
            }
           
            Console.ReadLine();
        }
    }
}
