using System;
using System.Collections.Generic;
using System.Text;

namespace Лаб3_ООП_
{
    class matrix
    {
        List<List<int>> mat = new List<List<int>>();
        int m;
        int n;
       public matrix(int m,int n)
        {
            this.m = m;
            this.n = n;
            for(int i = 0; i < m; ++i)
            {
                List<int> temp = new List<int>();
                Random rnd = new Random();
                for(int j=0;j<n;j++)
                    temp.Add(rnd.Next() % 10);
                mat.Add(temp);
            }
        }
        public void show()
        {
            Console.WriteLine("Вывод матрицы");
            for(int i = 0; i < this.m; ++i)
            {
                for(int j = 0; j < this.n; ++j)
                {
                    Console.Write(String.Format("{0,7:000}", mat[i][j] + " "));
                }
                Console.Write("\n");
            }
           
        }
        public int getel(int in1,int jn)
        {
            if (in1 < this.m && jn < this.n)
                return mat[in1][jn];
            else
            {
                Console.WriteLine("Выход за пределы матрицы");
                return -2;
            }
        }
        public void changemat(int in1,int jn, int num)
        {
            if (in1 < this.m && jn < this.n)
            {
                mat[in1][jn] = num;

            }
            else
            {
                Console.WriteLine("Выход за пределы матрицы");
            }
        }
    }
}
