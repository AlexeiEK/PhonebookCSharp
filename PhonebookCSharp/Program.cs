using System;
using System.Collections.Generic;

namespace PhonebookCSharp
{
    class Program
    {
        static void PrintDictionery(Dictionary<string, List<object>> dictionery)
        {
            foreach (var item in dictionery)
            {
                Console.Write($"{item.Key} - {item.Value}\t");
                Console.WriteLine();
            }
        }
        static void ShowMenu()
        {
            Console.WriteLine("==МЕНЮ ТЕЛЕФОННОГО СПРАВОЧНИКА==");
            Console.WriteLine("1 - Добавить нового абонента");
            Console.WriteLine("2 - Изменить данные абонента");
            Console.WriteLine("3 - Удалить абонента");
            Console.WriteLine("4 - Показать всех абонентов");
            Console.WriteLine("0 - Выйти из справочника");
            Console.WriteLine("================================");
        }
        static void AddSubscriber(Dictionary<string, List<object>> phoneBook)
        {
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            var exit = 1;
            var phones = new List<object>();
            do
            {
                Console.WriteLine("Введите номер телефона: ");
                phones.Add(Console.ReadLine());
                Console.WriteLine("Добавить ещё телефон?");
                exit = Convert.ToInt32(Console.ReadLine());
            } while (exit != 0);
            phoneBook.Add(name, phones);
        }
        static void Main()
        {
            var phoneBook = new Dictionary<string, List<object>>();
            int key;
            do
            {
                Console.Clear();
                ShowMenu();
                Console.WriteLine("Введите необходимый пункт меню: ");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        AddSubscriber(phoneBook);
                        Console.Clear(); break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        PrintDictionery(phoneBook);
                        Console.ReadKey();
                        break;
                    case 0:
                        Console.WriteLine("До свидания!");
                        break;
                    default:
                        Console.WriteLine("Выберите правильный пункт меню!");
                        break;
                }
            } while (key != 0);
            Console.ReadKey();
        }
    }
}