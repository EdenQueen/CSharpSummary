#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace CSharpSummery
{
    class Program
    {
        /*
         * 数值类型
         * sbyte：
         * byte：
         * short:, ushort:
         * int:,uint
         * long, ulong
         * float, double, decimal
         * char, bool, string
         */
        static void Main(string[] args)
        {
            ////在vs2013以及vs2017上编写代码
            //Console.WriteLine("Hello World");
            //Console.ReadKey();
            /*
            变量的命名规则，
            1.第一个字母必须是字母，下划线，或者@
            2.剩下的字母可以是字母，数字，下划线
            */
            //声明变量myInt，myStr;
            int myInt;
            string myStr;
            //给声明的变量赋值
            myInt = 18;
            //反斜杠加双引号可以输出字符双引号，转义字符
            myStr = "\"my age\"is";
            Console.WriteLine("{0}{1}", myStr, myInt);
            //Console.ReadKey()用途是暂停代码执行，等待用户执行下一操作；当不加该语句，控制台会一闪而过
            Console.ReadKey();
            //输出"my age"is18;
        }
    }
}
