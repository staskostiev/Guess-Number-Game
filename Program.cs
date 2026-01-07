using System;

class Program
{
    static void Main()
    {
        int wins = 0;

        while (true)
        {
            Console.Clear();

            int maxNumber = 100;

            Console.WriteLine("Выбери уровень сложности:");
            Console.WriteLine("1 - Легко (числа 1-10)");
            Console.WriteLine("2 - Нормально (числа 1-100)");
            Console.WriteLine("3 - Хард (числа 1-1000)");

            string level = Console.ReadLine();

            //if (level == "1")
            {
                maxNumber = 10;
            }
            else if (level == "3")
            {
                maxNumber = 1000;
            }


            Random random = new Random();
            int secretNum = random.Next(1, maxNumber + 1);

            while (true)
            {
                try
                {
                    string text = Console.ReadLine();
                    int guess = Convert.ToInt32(text);

                    if (guess < secretNum)
                    {
                        Console.WriteLine("Загаданное число больше.");
                    }
                    else if (guess > secretNum)
                    {
                        Console.WriteLine("Загаданное число меньше.");
                    }
                    else
                    {
                        Console.WriteLine("Победа!");

                        Console.WriteLine($"(Правильное число было: {secretNum})");
                        wins++;
                        Console.WriteLine($"Количество побед:{wins}");
                        Console.ReadKey();
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вводить только числа!");
                }
            }
            Console.WriteLine("Нажми ESC чтобы выйти, или любую другую кнопку чтобы продолжить...");
            var keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Escape)
            {
                break;
            }
        }
        
    }
}