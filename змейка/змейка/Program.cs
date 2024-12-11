using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        game.Start();
    }
}

class Game
{
    private const int Width = 30;
    private const int Height = 15;
    private Snake snake;
    private Food food;
    private bool isGameOver;

    public Game()
    {
        snake = new Snake();
        food = new Food(Width, Height);
        isGameOver = false;
    }

    public void Start()
    {
        Console.CursorVisible = false;
        while (!isGameOver)
        {
            Draw();
            Input();
            Logic();
            Thread.Sleep(150);
        }
        Console.SetCursorPosition(0, Height + 1);
        Console.WriteLine("Game Over!");
    }

    private void Draw()
    {
        Console.Clear();
        for (int x = 0; x < Width + 2; x++)
            Console.Write("#");
        Console.WriteLine();

        for (int y = 0; y < Height; y++)
        {
            Console.Write("#");
            for (int x = 0; x < Width; x++)
            {
                if (snake.Body.Any(b => b.X == x && b.Y == y))
                    Console.Write("s");
                else if (food.Position.X == x && food.Position.Y == y)
                    Console.Write("@");
                else
                    Console.Write(" ");
            }
            Console.WriteLine("#");
        }

        for (int x = 0; x < Width + 2; x++)
            Console.Write("#");
        Console.WriteLine();
    }

    private void Input()
    {
        if (Console.KeyAvailable)
        {
            var key = Console.ReadKey(true).Key;
            snake.ChangeDirection(key);
        }
    }

    private void Logic()
    {
        snake.Move();

        if (snake.Head.X < 0 || snake.Head.X >= Width || snake.Head.Y < 0 || snake.Head.Y >= Height || snake.Body.Skip(1).Any(b => b.X == snake.Head.X && b.Y == snake.Head.Y))
        {
            isGameOver = true;
        }

        if (snake.Head.X == food.Position.X && snake.Head.Y == food.Position.Y)
        {
            snake.Grow();
            food.Generate(Width, Height, snake.Body);
        }
    }
}

class Snake
{
    public List<Position> Body { get; private set; }
    public Position Head => Body.First();
    private Direction direction;

    public Snake()
    {
        Body = new List<Position> { new Position(5, 5) };
        direction = Direction.Right;
    }

    public void ChangeDirection(ConsoleKey key)
    {
        switch (key)
        {
            case ConsoleKey.UpArrow:
                if (direction != Direction.Down) direction = Direction.Up;
                break;
            case ConsoleKey.DownArrow:
                if (direction != Direction.Up) direction = Direction.Down;
                break;
            case ConsoleKey.LeftArrow:
                if (direction != Direction.Right) direction = Direction.Left;
                break;
            case ConsoleKey.RightArrow:
                if (direction != Direction.Left) direction = Direction.Right;
                break;
        }
    }

    public void Move()
    {
        Position newHead = new Position(Head.X, Head.Y);
        switch (direction)
        {
            case Direction.Up: newHead.Y--; break;
            case Direction.Down: newHead.Y++; break;
            case Direction.Left: newHead.X--; break;
            case Direction.Right: newHead.X++; break;
        }
        Body.Insert(0, newHead);
        Body.RemoveAt(Body.Count - 1);
    }

    public void Grow()
    {
        Body.Add(new Position(Body.Last().X, Body.Last().Y));
    }
}

class Food
{
    public Position Position { get; private set; }
    private Random random;

    public Food(int width, int height)
    {
        random = new Random();
        Generate(width, height, new List<Position>());
    }

    public void Generate(int width, int height, List<Position> snakeBody)
    {
        do
        {
            Position = new Position(random.Next(0, width), random.Next(0, height));
        } while (snakeBody.Any(b => b.X == Position.X && b.Y == Position.Y));
    }
}

struct Position
{
    public int X { get; set; }
    public int Y { get; set; }

    public Position(int x, int y)
    {
        X = x;
        Y = y;
    }
}

enum Direction
{
    Up,
    Down,
    Left,
    Right
}
