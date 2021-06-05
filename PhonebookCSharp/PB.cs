using System;
using System.Collections.Generic;

namespace PhonebookCSharp
{
    public static class PB
    {
        public static void AddSubscriber(Dictionary<string, List<object>> phoneBook)
        {
            string name;
            Console.Write("Введите имя: ");
            do
            {
                name = Console.ReadLine();
                if (phoneBook.ContainsKey($"{name}")) Console.Write("Такое имя существует! Введите другое: ");
            } while (phoneBook.ContainsKey($"{name}"));
            bool exit;
            var phones = new List<object>();
            do
            {
                Console.Write("Введите номер телефона: ");
                phones.Add(Console.ReadLine());
                Console.WriteLine("Добавить ещё телефон (ДА/НЕТ)?");
                string exitQuestion = Console.ReadLine().ToUpper();
                if (exitQuestion == "ДА" || exitQuestion == "YES") exit = true;
                else exit = false;
            } while (exit);
            phoneBook.Add(name, phones);
            Console.WriteLine("Запись сохранена!");
            Console.ReadKey();
        }
        public static void DeleteAbonent (Dictionary<string, List<object>> phoneBook)
        {
            Console.Write("Введите имя абонента для удаления: ");
            string name = Console.ReadLine();
            if (phoneBook.ContainsKey($"{name}"))
            {
                phoneBook.Remove(name);
            }
            else
            {
                Console.WriteLine("Такого абонента не существует!");
            }
        }
    }
}
