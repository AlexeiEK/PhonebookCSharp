using System;
using System.Collections.Generic;

namespace PhonebookCSharp
{
    public static class SPB
    {
        public static void ShowDictionery(Dictionary<string, List<string>> dictionery)
        {
            foreach (var item in dictionery)
            {
                var number = 0;
                Console.Write($"{item.Key} - ");
                foreach (var phone in item.Value)
                {
                    Console.Write($"{++number}) {phone}\t");
                }
                Console.WriteLine();
            }
        }
        public static void ShowAbonent(Dictionary<string, List<string>> dictionery, string name)
        {
            var number = 0;
            Console.Write($"{name} - ");
            foreach (var phone in dictionery[name])
            {
                Console.Write($"{++number}) {phone}\t");
            }
            Console.WriteLine();
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
