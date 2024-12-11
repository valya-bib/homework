using System;

class Program
{
    static char[,] board = new char[3, 3];
    static char currentPlayer = 'X';

    static void Main(string[] args)
    {
        InitializeBoard();
        while (true)
        {
            PrintBoard();
            PlayerMove();
            if (CheckWin())
            {
                PrintBoard();
                Console.WriteLine($"Игрок {currentPlayer} выиграл");
                break;
            }
            if (CheckDraw())
            {
                PrintBoard();
                Console.WriteLine("Ничья");
                break;
            }
            SwitchPlayer();
        }
    }

    static void InitializeBoard()
    {
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                board[i, j] = ' ';
    }

    static void PrintBoard()
    {
        Console.Clear();
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(" " + board[i, 0] + " | " + board[i, 1] + " | " + board[i, 2]);
            if (i < 2) Console.WriteLine("---|---|---");
        }
    }

    static void PlayerMove()
    {
        int row, col;
        while (true)
        {
            Console.WriteLine($"Игрок {currentPlayer}, введите строку и столбец (0, 1 или 2): ");
            string input = Console.ReadLine();
            string[] parts = input.Split(',');
            if (parts.Length == 2 &&
                int.TryParse(parts[0], out row) &&
                int.TryParse(parts[1], out col) &&
                row >= 0 && row < 3 &&
                col >= 0 && col < 3 &&
                board[row, col] == ' ')
            {
                board[row, col] = currentPlayer;
                break;
            }
            Console.WriteLine("Некорректный ввод");
        }
    }

    static void SwitchPlayer()
    {
        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
    }

    static bool CheckWin()
    {
        // проверка строк, столбцов и диагоналей
        for (int i = 0; i < 3; i++)
        {
            if ((board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer) ||
                (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer))
                return true;
        }
        return (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer) ||
               (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer);
    }

    static bool CheckDraw()
    {
        foreach (var cell in board)
        {
            if (cell == ' ') return false;
        }
        return true;
    }
}

