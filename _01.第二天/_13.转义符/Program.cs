using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.转义符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  \n      换行
            //  \t      制表符
            //  \b      退格
            //  \r\n    换行 


            Console.WriteLine("今天天气好晴朗\n处处好风光");
            Console.ReadKey();

            Console.WriteLine("我想在这句话中输出一个英文半角的双引号\"\"");
            Console.ReadKey();


            // 加 @ 可以将字符串按照原格式输出
            // 路径 可以加 @ 就可以只写一个\  不用使用 \\ 代表 \
            string path = @"F:\test\project";
            Console.WriteLine(path);
            Console.ReadKey();

        }
    }
}
