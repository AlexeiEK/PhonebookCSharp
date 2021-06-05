using System;
using System.Collections.Generic;

namespace PhonebookCSharp
{
    public static class SPB
    {
        public static void ShowDictionery(Dictionary<string, List<object>> dictionery)
        {
            foreach (var item in dictionery)
            {
                Console.Write($"{item.Key} - {item.Value}\t");
                Console.WriteLine();
            }
        }
        public static void ShowAbonent (Dictionary<string, List<object>> dictionery)
        {
            Console.Write("Введите имя абонента: ");
            string name = Console.ReadLine();
            if (dictionery.ContainsKey($"{name}"))
            {
                Console.Write($"{dictionery[name]}\t");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Такого абонента не существует!");
            }
        }
        public static void ShowMenu()
        {
            Console.WriteLine("==МЕНЮ ТЕЛЕФОННОГО СПРАВОЧНИКА==");
            Console.WriteLine("1 - Добавить нового абонента");
            Console.WriteLine("2 - Изменить данные абонента");
            Console.WriteLine("3 - Удалить абонента");
            Console.WriteLine("4 - Показать абонента");
            Console.WriteLine("5 - Показать всех абонентов");
            Console.WriteLine("0 - Выйти из справочника");
            Console.WriteLine("================================");
        }
    }
}
