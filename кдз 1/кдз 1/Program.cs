using System;

class Program
{
    static void Main(string[] args)
    {
        string secretNumber = GenerateSecretNumber();
        Console.WriteLine("Первый игрок, загадайте четырехзначное число с различными цифрами.");
        Console.WriteLine("Второй игрок, попробуйте угадать это число!");

        int attempts = 0;
        while (true)
        {
            Console.Write("Введите Вашу попытку: ");
            string guess = Console.ReadLine();

            if (IsValidGuess(guess))
            {
                attempts++;
                (int bulls, int cows) = GetBullsAndCows(secretNumber, guess);
                Console.WriteLine($"Быки: {bulls}, Коровы: {cows}");

                if (bulls == 4)
                {
                    Console.WriteLine($"Поздравляем! Вы угадали число {secretNumber} за {attempts} попыток.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Убедитесь, что число четырехзначное и все цифры различны.");
            }
        }
    }

    static string GenerateSecretNumber()
    {
        Random random = new Random();
        string number;
        do
        {
            number = random.Next(1000, 10000).ToString();
        } while (HasDuplicateDigits(number));
        return number;
    }

    static bool HasDuplicateDigits(string number)
    {
        return number.Length != number.ToCharArray().Distinct().Count();
    }

    static bool IsValidGuess(string guess)
    {
        return guess.Length == 4 && int.TryParse(guess, out _) && !HasDuplicateDigits(guess);
    }

    static (int bulls, int cows) GetBullsAndCows(string secret, string guess)
    {
        int bulls = 0, cows = 0;
        bool[] secretChecked = new bool[4];
        bool[] guessChecked = new bool[4];

        return (bulls, cows);
    }
}
