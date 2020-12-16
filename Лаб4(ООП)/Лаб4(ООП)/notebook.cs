using System;
using System.Collections.Generic;
using System.Text;

namespace Лаб4_ООП_
{
    enum Type { Игровой, Рабочий}
    class notebook : Mobile
    {
        double diagonalScreen;
        Type typenote;
        
        public notebook( string model, int RAM, string processor, string OS, int capacityBat, double diagonalScreen, Type typenote)
        {
            
            this.model = model;
            this.OS = OS;
            this.RAM = RAM;
            this.Processor = processor;
            this.capacityBat = capacityBat;
            this.diagonalScreen = diagonalScreen;
            this.typenote = typenote;
           
        }
       public void notebookinfo()
        {
            Console.WriteLine("Модель ноутбука: {0}\nТип ноутбука:{1}\nОС:{2}\nКоличество ОЗУ:{3}" +
                "\nПроцессор:{4}\nОбъем батареии:{5}\nДиагональ экрана:{6}\n", 
                model, typenote, OS, RAM, Processor, capacityBat, diagonalScreen); 
            

        }
    }
}
