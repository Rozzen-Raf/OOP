using System;
using System.Collections.Generic;
namespace Lr1_OOP_
{
    class Program
    {
        class MyTask
        {
            private List<double> data = new List<double>();
            private int n;
            
            public void InputData()
            {
                data.Clear();
                Console.WriteLine("Лабораторная работа №1. Вариант-10");
                Console.WriteLine("Введите количество чисел: ");
                n = Convert.ToInt32(Console.ReadLine());
                
                for(double i = 0,  b; i < n; ++i)
                {
                    Console.WriteLine("Введите число по номеру {0}:", i + 1);
                    b = Convert.ToDouble(Console.ReadLine());
                    data.Add(b);
                }
            }
            public void PrintResult()
            {
                double b=0;
                for(int i = 0; i < n; ++i)
                {
                    if (i % 2 == 1) b += data[i];
                }
                b = Math.Pow(b, 3);
                Console.WriteLine("Результат решения: {0}",b);
            } 

        }
        static void Main(string[] args)
        {
            MyTask mt = new MyTask();
            mt.InputData();
            mt.PrintResult();
        }
    }
}
