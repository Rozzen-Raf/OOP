using System;
using System.Collections.Generic;
using System.Text;

namespace Лаб4_ООП_
{
    class Smartphone : Mobile
    {
        double Camera;
        public Smartphone( string model, int RAM, string processor,string OS, int capacityBat, double Camera)
        {
            
            this.model = model;
            this.OS = OS;
            this.RAM = RAM;
            this.Processor = processor;
            this.capacityBat = capacityBat;
            this.Camera = Camera;
        }
        public void SmartInfo()
        {
            Console.WriteLine("Модель смартфона: {0}\nКамера:{1}\nОС:{2}\nКоличество ОЗУ:{3}\n" +
                    "Процессор:{4}\nОбъем батареии:{5}\n",
                    model, Camera, OS, RAM, Processor, capacityBat);
        }
    }
}
