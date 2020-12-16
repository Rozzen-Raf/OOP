using System;
using System.Collections.Generic;

namespace Лаб3_ООП_
{
    
    class Program
    {
       static int average(matrix mat, int m, int n)
        {
            int aver=0;
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; ++j)
                {
                    aver += mat.getel(i, j);
                }
            }
            aver /= m * n;
            return aver;
            
        }
        static matrix changer(matrix mat,int m,int n,int aver)
        {
            for(int i = 0; i < m; ++i)
            {
                for(int j = 0; j < n; ++j)
                {
                    if (mat.getel(i, j) > aver)
                    {
                        mat.changemat(i, j, -1);
                    }
                }
            }
            return mat;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размеры матрицы MxN:");
            int m, n;
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            matrix mat = new matrix(m, n);
            mat.show();
            int aver = average(mat, m, n);
           
            Console.WriteLine("Среднее арифметическое элементов матрицы: {0}",aver);

            mat = changer(mat, m, n, aver);
            mat.show();
        }
    }
}
