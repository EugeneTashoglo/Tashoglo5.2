using System;

namespace Mylib
{
    public class Class1
    {
       public static int[] SumNegative(int[,] mas)
        {
            {
                int rows = mas.GetUpperBound(0) + 1;
                int columns = mas.Length / rows;
                int[] res = new int[rows];
                for (int i = 0; i < rows; i++)
                {
                    int S = 0;
                    for (int j = 0; j < columns; j++)
                    {
                        if (mas[i, j] % 3 == 0) S += mas[i, j];

                    }
                    res[i] = S;
                }
                return res;
            }
        }
    }
}