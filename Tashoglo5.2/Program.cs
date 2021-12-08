using System;

namespace Tashoglo5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[8, 3];
            Random rnd = new Random();
            for(int i=0;i<8;i++)
            {
                for (int j=0;j<3;j++)
                {
                    mas[i, j] = rnd.Next(-10, 11);
                    Console.Write(mas[i,j]+" ");
                }
                Console.WriteLine();
            }
            int[] res = Mylib.Class1.SumNegative(mas);
            for (int i = 0 ; i < res.Length; i++)

                {
                {
                    Console.Write(res[i] + "  ");

                }
                Console.WriteLine();
            }
                
        }
    }
}
