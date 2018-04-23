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
            //Variable();
            Expression();
        }

        static void Variable()
        {
            /*
            变量的命名规则，
            1.第一个字母必须是字母，下划线，或者@
            2.剩下的字母可以是字母，数字，下划线
             * 关于命名
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
        static void Expression()
        {
            /*
             * 表达式是由数值和运算符组成
             * 运算符分为三种，一元运算符，二元运算符，三元运算符
             * 一元运算符包括，+，-，++，--等
             * 二元运算符包括+，-，*，/，%等
             * 赋值运算符：=，==，/=，+=，-=，%=等
             * var1 += var2 与 var1 = var1 + var2等价
             * 
             * 运算符优先级：++，--（用做前缀），+，-（一元）
             *               *，/，%
             *               +，-
             *               =，*=， /=， %=，+=，-=
             *               ++， --（用做后缀）
             */
            double firstNum, secondNum;
            string name;
            Console.WriteLine("Please enter your name:");
            //使用Console.ReadLine()提示用户输入信息，并存储在string变量中
            name = Console.ReadLine();
            Console.WriteLine("Welcome{0} ", name);
            Console.WriteLine("Please enter a number:");
            //将string变量转化成double形式
            firstNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter another number:");
            secondNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", firstNum, secondNum, firstNum + secondNum);
            Console.WriteLine("{0} - {1} = {2}", firstNum, secondNum, firstNum - secondNum);
            Console.WriteLine("{0} * {1} = {2}", firstNum, secondNum, firstNum * secondNum);
            Console.WriteLine("{0} / {1} = {2}", firstNum, secondNum, firstNum / secondNum);
            Console.WriteLine("{0} % {1} = {2}", firstNum, secondNum, firstNum % secondNum);
            Console.ReadKey();

        }
    }
}
