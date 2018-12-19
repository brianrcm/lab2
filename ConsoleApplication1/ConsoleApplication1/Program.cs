using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static Boolean f = false;
        static void Main(string[] args)
        {
            Console.WriteLine("Откуда");
            string point1 = Console.ReadLine();
            Console.WriteLine("Куда");
            string point2 = Console.ReadLine();
            Console.WriteLine("Введите дату отправления чч.мм.гг");
            string date = Console.ReadLine();
            Console.WriteLine("Выберите класс: \n 1.Эконом\n 2.Бизнес");
            string cl = Console.ReadLine();
            poisk();
            if (f == true)
            {
                Console.WriteLine("1.Купить билет\n2.Забронировать билет"); string ch = Console.ReadLine();
                Console.WriteLine("ФИО"); string fio = Console.ReadLine();
                Console.WriteLine("Номер документа"); string doc = Console.ReadLine();
                Console.WriteLine("Дата рождения"); string birthd = Console.ReadLine(); f = false;
                Console.WriteLine("Выберите место c 1-99"); string seat = Console.ReadLine(); poisk(); ;
                while (f == false) { seat = Console.ReadLine(); poisk(); }
                Random rnd = new Random(); int v = rnd.Next(3000, 10000); Console.WriteLine($"Цена: {v}");
                switch (ch)
                {
                    case "1":
                        {
                            Console.WriteLine("Введите номер кредитной карты"); string cred = Console.ReadLine();
                            Console.WriteLine("Оплата прошла успешно. Ваш билет:");
                            Console.WriteLine($"ФИО: {fio} \n Номер документа {doc} \n Дата рождения {birthd} \n" +
                            $" Откуда {point1} \n Куда {point2} \n Дата отправления {date} \n Время 17:30 \n Класс {cl} \n Место {seat}");

                        }
                        break;
                    case "2":
                        {
                            Console.WriteLine("Бронь прошла успешно!");
                            Console.WriteLine($"ФИО: {fio} \n Номер документа {doc} \n Дата рождения {birthd} \n" +
                            $" Откуда {point1} \n Куда {point2} \n Дата отправления {date} \n Время 17:30 \n Класс {cl} \n Место {seat}");
                        }
                        break;
                }
            }
            Console.Read();

        }

        static void poisk()
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 100);
            if ((value % 2) == 0) { Console.WriteLine("Найдено"); f = true; }
            else Console.WriteLine("Не найдено");
        }


    }
}
