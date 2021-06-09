using System;
using System.Collections.Generic;

namespace PhonebookCSharp
{
    class Program
    {
        static void Main()
        {
            var phoneBook = new Dictionary<string, List<string>>();
            int key;
            string name;

            do
            {
                Console.Clear();
                SPB.ShowMenu();
                Console.WriteLine("Введите необходимый пункт меню: ");
                string chekKey = Console.ReadLine();
                if (Int32.TryParse(chekKey, out key))
                {
                    switch (key)
                    {
                        case 1:
                            CLI.InputAbonent();
                            do
                            {
                                name = Console.ReadLine();
                                if (phoneBook.ContainsKey($"{name}"))
                                {
                                    CLI.WarningName();
                                    CLI.InputAbonentOther();
                                }
                            } while (phoneBook.ContainsKey($"{name}"));
                            PB.AddSubscriber(phoneBook, name);
                            break;
                        case 2:
                            CLI.InputAbonentChenge();
                            name = Console.ReadLine();
                            PB.ChangeAbonent(phoneBook, name);
                            Console.ReadKey();
                            break;
                        case 3:
                            CLI.InputAbonentDelete();
                            name = Console.ReadLine();
                            if (phoneBook.ContainsKey($"{name}"))
                            {
                                PB.DeleteAbonent(phoneBook, name);
                                CLI.WarningDelete();
                                Console.ReadKey();
                            }
                            else
                            {
                                CLI.WarningNoName();
                            }
                            break;
                        case 4:
                            CLI.InputAbonent();
                            name = Console.ReadLine();
                            if (phoneBook.ContainsKey($"{name}"))
                            {
                                SPB.ShowAbonent(phoneBook, name);
                                Console.ReadKey();
                            }
                            else
                            {
                                CLI.WarningNoName();
                                Console.ReadKey();
                            }
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
                            Console.ReadKey();
                            break;
                    }
                }
                else
                {
                    key = -1;
                }
            } while (key != 0);
            Console.ReadKey();
        }
    }
}