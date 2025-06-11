using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    class Matrix_Fibon
    {
        public static int Fibon(int num)
        {
            if (num == 0)
                return 0;
            if (num == 1)
                return 1;

            int previous = 1;
            int now = 1;
            for (int i = 1; i < num; i++)
            {
                previous = now;
                now = previous + now;
            }
            return now;
        }
        static void ToPower(int power)
        {
            int[,] firstMatrix = new int[,] 
            { 
            { 1, 1 },
            { 1, 0 } 
            };
            int[,] final = new int[,]
            {
                {1,0 },
                {0,1}
            };
            if (power > 0)
            {
                while(power > 0)
                {
                    if (power % 2 == 1)
                    {
                        final = Multik(final,firstMatrix);
                    }
                    firstMatrix = Multik(firstMatrix, firstMatrix);
                    power /= 2;
                }
                Console.WriteLine(final[0, 0]);//Это результат от возведения матрицы в степень
            }
            else
            {
                Console.WriteLine("1");// 1 т.к. это вроде получится единичная матрица
            }
        }
        static int[,] Multik(int[,] first, int[,] second)
        {
            int[,] returnable = new int[,]
            {
                {0,0 },
                {0,0 }
            };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        returnable[i, j] += first[i, k] * second[k, j];
                    }
                }
            }
            return returnable;
        }
    }
}
