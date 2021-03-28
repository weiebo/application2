using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Calculate
    {
        public static int JianFa(int x, int y)
        {
            return x - y;
        }
        ///<summary>
        ///两个整数相减
        ///</summary>
        ///<param name="x">第一个减数</param>
        ///<param name="y">第二个减数</param>
        ///<returns></return>
        public static string JianFa(ref string x, ref string y)
        {
            string[] xx; string[] yy; string[] zz;
            xx = new string[100];
            yy = new string[100];
            for (int i = 0; i < x.Length; i++)
            {
                xx[i] = x[i].ToString();//将字符串存入数组
            }
            for (int i = 0; i < y.Length; i++)
            {
                yy[i] = y[i].ToString(); //将字符串存入数组
            }
            for (int i = 0; i < y.Length; i++)
            {
                for (int j = 0; j < x.Length; j++)
                {
                    if (xx[j] == yy[i])
                    {
                        for (int k = j; k < x.Length; k++)//在xx数组中查找与yy数组相同的值，并删除  
                            xx[k] = xx[k + 1];
                        break;
                    }

                }
            }
            string z = string.Join("", xx);
            return z;
        }
        public static int JiaFa(int x, int y)
        {
            return x + y;
        }

        public static string JiaFa(ref string x, ref string y)
        {
            string[] xx; string[] yy; string[] zz;
            xx = new string[100];
            yy = new string[100];
            zz = new string[200];
            for (int i = 0; i < x.Length; i++)
            {
                xx[i] = x[i].ToString();
                zz[i] = xx[i];
            }
            for (int i = 0; i < y.Length; i++)
            {
                yy[i] = y[i].ToString();
                zz[x.Length + i] = yy[i];
            }
            string z = string.Join("", zz);
            return z;
        }
        public static int ChengFa(int x, int y)
        {
            return x * y;
        }

        public static int ChuFa(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine("除数不可为0。");
                return 0;
            }
            else
                return x / y;
        }

    }
}
