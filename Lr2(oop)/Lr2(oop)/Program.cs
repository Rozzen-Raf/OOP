using System;
using System.IO;
using System.Collections.Generic;
using System.Numerics;

namespace Lr2_oop_
{
    class Program
    {
        enum Lsa
        {
            Ready,NotReady
        }

       class Program1
        {
            string Name;
            int kod;
            Programist performing;
            Lsa Sost;
             public Lsa getSost()
            {
                return this.Sost;
            }
            public void ChangeSost(Lsa sost)
            {
                this.Sost = sost;
            }
            public int getkod()
            {
                return this.kod;
            }
            public void Give(Programist programist) {
                this.performing = programist;
            }
            public string GetProgramistfio()
            {
                string fio;
                if (this.performing == null)
                {
                    fio = "Программиста нет";
                }
                else
                {
                    fio = this.performing.getfio();
                }
                
                return fio;
            }
            
            public Programist GetProgramist()
            {
                return this.performing;
            }
            public string getname()
            {
                return this.Name;
            }
            public  Program1 In(string Name, int kod, Lsa Sost)
            {
                Program1 t = new Program1();
                t.Name = Name;
                t.kod = kod;
                t.Sost = Sost;
                t.performing = null;
                return t;
            }
            
        }
        class Programist
        {
            string fio;
            string biletSpecial;
            public string getfio()
            {
                return this.fio;
            }
            public string getbilet()
            {
                return this.biletSpecial;
            }
            public Programist(string Fio, string bilet) {
                fio = Fio;
                biletSpecial = bilet;
}
        }
        class SysAdm
        {


            List<Program1> prlib = new List<Program1>();
            
            public static SysAdm In()
            {
                
                SysAdm res = new SysAdm();
                res.prlib.Clear();
                Program1 pr = new Program1();
                pr = pr.In("calculator", 1, Lsa.NotReady);
                res.prlib.Add(pr);
                pr = pr.In("Finder", 2, Lsa.NotReady);
                res.prlib.Add(pr);
                
                return res;
            }
            public void Issuance_of_assignments(int kod, Programist programist)
            {

                foreach(Program1 pr in prlib)
                {
                    if(pr.getkod() == kod){
                        if (pr.getSost()==Lsa.NotReady) {
                            if (pr.GetProgramist() == null)
                            {
                                pr.Give(programist);
                                Console.WriteLine("Задание выдано");
                                break;
                            } 
                            else
                            {
                                Console.WriteLine("Задание выполняет другой программист");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Программа уже готова");
                            break;
                        }
                    } 
                    else
                    {
                        Console.WriteLine("Программа с таким кодом отсутствует");
                    }
                }
            }
            public void ListTask()
            {
                Console.WriteLine("Список заданий:");
                foreach (Program1 pr in prlib)
                {
                    
                    Console.WriteLine("{0} {1} {2} {3}", pr.getname(), pr.getkod(), pr.getSost(), pr.GetProgramistfio());
                }
            }
            public void Deliveryofassignment(Programist programist)
            {
                Console.WriteLine("Какое задание вы хотите сдать? Введите код:");
                int kod = Convert.ToInt32(Console.ReadLine());
                foreach(Program1 pr in prlib)
                {
                    if(pr.getkod()==kod) {
                        if (pr.GetProgramist()!=null&&pr.GetProgramist().getbilet() == programist.getbilet()) {
                            if (pr.getSost() != Lsa.Ready)
                            {
                                pr.ChangeSost(Lsa.Ready);
                                Console.WriteLine("Задание сдано");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Задание уже было выполнено!");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Это задание не ваше!");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Программа с таким кодом отсутствует");
                    }
                }
            }

        }
        static void Main(string[] args)
        {
            SysAdm ds = SysAdm.In();
            Console.WriteLine("Планировщик заданий готов к работе!");
            Console.WriteLine("Идентификация программиста");
            Console.WriteLine("ФИО:");
            string FIOP = Console.ReadLine();
            Console.WriteLine("Пропуск:");
            string bilet = Console.ReadLine();
            Programist prst = new Programist(FIOP, bilet);
            int operation=0;
            do
            {
                Console.WriteLine("Уважаемый {0}, выберите действие:", prst.getfio());
                Console.WriteLine("1 - Вывод каталога\n2 - Запрос задания\n3 - Сдача задания\n0 - выход:");
                operation = Convert.ToInt32(Console.ReadLine());
                switch (operation)
                {
                    case 1: ds.ListTask(); break;
                    case 2:
                        Console.WriteLine("Какое задание брать? Введите код:");
                        int kod = Convert.ToInt32(Console.ReadLine());
                        ds.Issuance_of_assignments(kod, prst);
                        break;
                    case 3: ds.Deliveryofassignment(prst);break;
                    default:break;
                }

            } while (operation != 0);
            Console.WriteLine("Работа планировщика заданий завершена!");
                
            
        }
    }
}
