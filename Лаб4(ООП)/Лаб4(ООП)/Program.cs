using System;

namespace Лаб4_ООП_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ноутбук:");
            notebook note = new notebook("Acer aspire 3", 4096, "Intel i5", "Windows 10", 4810, 14, Type.Рабочий);
            note.notebookinfo();
            Console.WriteLine("Смартфон:");
            Smartphone smart = new Smartphone("Xiaomi mi 8", 4096, "Qualcomm Snapdragon 660", "Android", 3350, 12);
            smart.SmartInfo();
            Console.WriteLine("Персональный компьютер:");
            PC percom = new PC("Acer", "GTX 1060 6GB", 16384, "Intel i7", "Windows 10");
            percom.PCinfo();
        }
    }
}
