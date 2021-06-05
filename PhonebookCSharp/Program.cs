using System;
using System.Collections.Generic;

namespace PhonebookCSharp
{
    class Program
    {
        static void Main()
        {
            var phoneBook = new Dictionary<string, List<object>>();
            int key;
            do
            {
                Console.Clear();
                SPB.ShowMenu();
                Console.WriteLine("Введите необходимый пункт меню: ");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        PB.AddSubscriber(phoneBook);
                        Console.Clear(); break;
                    case 2:
                        PB.ChangeAbonent(phoneBook);
                        break;
                    case 3:
                        Console.Write("Введите имя абонента для удаления: ");
                        PB.DeleteAbonent(phoneBook);
                        break;
                    case 4:
                        SPB.ShowAbonent(phoneBook);
                        Console.ReadKey();
                        break;
                    case 5:
                        SPB.ShowDictionery(phoneBook);
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