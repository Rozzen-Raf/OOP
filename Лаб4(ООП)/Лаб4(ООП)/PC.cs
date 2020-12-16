using System;
using System.Collections.Generic;
using System.Text;

namespace Лаб4_ООП_
{
    class PC:Stationary
    {
        string videographycard;
        public PC(string Monitor, string videographycard,  int RAM, string Processor, string OS )
        {
            this.Monitor = Monitor;
            this.videographycard = videographycard;
            this.OS = OS;
            this.RAM = RAM;
            this.Processor = Processor;
            

        }
        public void PCinfo()
        {
            Console.WriteLine("Монитор: {0}\nВидеокарта:{1}\nОС:{2}\nКоличество ОЗУ:{3}" +
                "\nПроцессор:{4}\n", Monitor, videographycard, OS, RAM, Processor);
        }
    }
}
