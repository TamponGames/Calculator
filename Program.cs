using System;

class Program
{
    static void Main(string[] args)
    {
        bool isRunning = true;
        while (isRunning)
        {
            // Выводим меню
            Console.Clear();
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Ввести A");
            Console.WriteLine("2. Ввести B");
            Console.WriteLine("3. Выполнить операцию +");
            Console.WriteLine("4. Выполнить операцию -");
            Console.WriteLine("5. Выполнить операцию *");
            Console.WriteLine("6. Выполнить операцию /");
            Console.WriteLine("7. Выход");
            Console.Write("Выберите пункт меню: ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    InputA();
                    break;
                case "2":
                    InputB();
                    break;
                case "3":
                    AddOperation();
                    break;
                case "4":
                    SubtractOperation();
                    break;
                case "5":
                    MultiplyOperation();
                    break;
                case "6":
                    DivideOperation();
                    break;
                case "7":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Неверный выбор! Пожалуйста, выберите правильный пункт.");
                    break;
            }
        }
    }

    // Методы для выполнения операций:
    static void InputA()
    {
        Console.Write("Введите значение для A: ");
        double A = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"A = {A}");
        Console.ReadKey();
    }

    static void InputB()
    {
        Console.Write("Введите значение для B: ");
        double B = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"B = {B}");
        Console.ReadKey();
    }


    static void AddOperation()
    {
    }

    static void SubtractOperation()
    {
    }

    static void MultiplyOperation()
    {
    }

    static void DivideOperation()
    {
    }
}
