using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    
    class Program
    {

        public static void Equals(ref int x, ref int y)
        {
            if (x == y)
            {
                Console.WriteLine("{0}与{1}相等。", x, y);
            }
            else
            {
                Console.WriteLine("{0}与{1}不相等。", x, y);
            }
        }
        static void Main(string[] args)
        {
            string x,y;
            int a,b,s=0;

            Console.Write("请输入x的值：");
            x =  Console.ReadLine();
            if (int.TryParse(x, out a))
                s = s + 0;
            else
                s++;
            Console.Write("请输入运算符：");
            char c = Convert.ToChar(Console.ReadLine());

            Console.Write("请输入y的值：");
            y = Console.ReadLine();
            if (int.TryParse(y, out b))
                s = s + 0;
            else
                s++;

            if (s == 0)
            {
                if (c == 43)
                {
                    Console.WriteLine("{0}+{1}={2}", a, b, Calculate.JiaFa(a, b));
                }
                else if (c == 45)
                {
                    Console.WriteLine("{0}-{1}={2}", a, b, Calculate.JianFa(a, b));
                }
                else if (c == 42)
                {
                    Console.WriteLine("{0}*{1}={2}", a, b, Calculate.ChengFa(a, b));
                }
                else if (c == 47)
                {

                    Console.WriteLine("{0}/{1}={2}", a, b, Calculate.ChuFa(a, b));
                }
            }
            else
            {
                if (c == 43)
                {
                    Console.WriteLine("{0}+{1}={2}", x, y, Calculate.JiaFa(ref x, ref y));
                }
                else if (c == 45)
                {
                    Console.WriteLine("{0}-{1}={2}", x, y, Calculate.JianFa(ref x, ref y));
                }
            }


        }
    }
}
