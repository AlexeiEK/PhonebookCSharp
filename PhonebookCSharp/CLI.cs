using System;

namespace PhonebookCSharp
{
    class CLI
    {
        public static void InputAbonent()
        {
            Console.Write("Введите имя: ");
        }
        public static void InputAbonentOther()
        {
            Console.Write("Введите другое имя абонента: ");
        }
        public static void InputAbonentDelete()
        {
            Console.Write("Введите имя абонента для удаления: ");
        }
        public static void InputAbonentChenge()
        {
            Console.Write("Введите имя абонента для редактирования: ");
        }
        public static void InputPhone()
        {
            Console.Write("Введите номер телефона: ");
        }
        public static void InputPhoneOther()
        {
            Console.WriteLine("Добавить ещё телефон (ДА/НЕТ)?");
        }
        public static void WarningName()
        {
            Console.WriteLine("Такое имя существует!");
        }
        public static void WarningNameOther()
        {
            Console.WriteLine("Такое имя существует! Введите другое: ");
        }
        public static void WarningNoName()
        {
            Console.WriteLine("Такого абонента не существует!");
        }
        public static void WarningDelete()
        {
            Console.WriteLine("Абонент удален!");
        }
        public static void WarningChenge()
        {
            Console.WriteLine("Абонент изменен!");
        }
        public static void Saved()
        {
            Console.WriteLine("Запись сохранена!");
        }
        public static bool YesNo()
        {
            string exitQuestion = Console.ReadLine().ToUpper();
            if (exitQuestion == "ДА" || exitQuestion == "YES") return true;
            else return false;
        }
    }
}
