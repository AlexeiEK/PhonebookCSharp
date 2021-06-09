using System;
using System.Collections.Generic;

namespace PhonebookCSharp
{
    public static class PB
    {
        public static void AddSubscriber(Dictionary<string, List<string>> phoneBook, string name)
        {
            bool exit;
            var phones = new List<string>();
            do
            {
                CLI.InputPhone();
                phones.Add(Console.ReadLine());
                CLI.InputPhoneOther();
                exit = CLI.YesNo();
            } while (exit);
            phoneBook.Add(name, phones);
            CLI.Saved();
            Console.ReadKey();
        }
        public static void DeleteAbonent(Dictionary<string, List<string>> phoneBook, string name)
        {
            phoneBook.Remove(name);
        }
        public static void ChangeAbonent(Dictionary<string, List<string>> dictionery, string name)
        {
            if (dictionery.ContainsKey($"{name}"))
            {
                DeleteAbonent(dictionery, name);
                AddSubscriber(dictionery, name);
                CLI.WarningChenge();
            }
            else
            {
                CLI.WarningNoName();
            }
        }
    }
}
