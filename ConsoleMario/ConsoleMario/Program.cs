class Program
{
    static void Main(string[] args)
    {
        DrawPixels(ConsoleColor.Blue, 0, 0, 14);

        DrawPixels(ConsoleColor.Blue, 0, 1, 4);
        DrawPixels(ConsoleColor.Red, 4, 1, 5);
        DrawPixels(ConsoleColor.Blue, 9, 1, 5);

        DrawPixels(ConsoleColor.Blue, 0, 2, 3);
        DrawPixels(ConsoleColor.Red, 3, 2, 9);
        DrawPixels(ConsoleColor.Blue, 12, 2, 2);

        DrawPixels(ConsoleColor.Blue, 0, 3, 3);
        DrawPixels(ConsoleColor.Black, 3, 3, 3);
        DrawPixels(ConsoleColor.White, 6, 3, 2);
        DrawPixels(ConsoleColor.Black, 8, 3, 1);
        DrawPixels(ConsoleColor.White, 9, 3, 1);
        DrawPixels(ConsoleColor.Blue, 10, 3, 4);

        DrawPixels(ConsoleColor.Blue, 0, 4, 2);
        DrawPixels(ConsoleColor.Black, 2, 4, 1);
        DrawPixels(ConsoleColor.White, 3, 4, 1);
        DrawPixels(ConsoleColor.Black, 4, 4, 1);
        DrawPixels(ConsoleColor.White, 5, 4, 3);
        DrawPixels(ConsoleColor.Black, 8, 4, 1);
        DrawPixels(ConsoleColor.White, 9, 4, 3);
        DrawPixels(ConsoleColor.Blue, 12, 4, 2);

        DrawPixels(ConsoleColor.Blue, 0, 5, 2);
        DrawPixels(ConsoleColor.Black, 2, 5, 1);
        DrawPixels(ConsoleColor.White, 3, 5, 1);
        DrawPixels(ConsoleColor.Black, 4, 5, 2);
        DrawPixels(ConsoleColor.White, 6, 5, 3);
        DrawPixels(ConsoleColor.Black, 9, 5, 1);
        DrawPixels(ConsoleColor.White, 10, 5, 3);
        DrawPixels(ConsoleColor.Blue, 13, 5, 1);

        DrawPixels(ConsoleColor.Blue, 0, 6, 2);
        DrawPixels(ConsoleColor.Black, 2, 6, 2);
        DrawPixels(ConsoleColor.White, 4, 6, 4);
        DrawPixels(ConsoleColor.Black, 8, 6, 4);
        DrawPixels(ConsoleColor.Blue, 12, 6, 2);

        DrawPixels(ConsoleColor.Blue, 0, 7, 4);
        DrawPixels(ConsoleColor.White, 4, 7, 7);
        DrawPixels(ConsoleColor.Blue, 11, 7, 3);

        DrawPixels(ConsoleColor.Blue, 0, 8, 3);
        DrawPixels(ConsoleColor.DarkBlue, 3, 8, 2);
        DrawPixels(ConsoleColor.Red, 5, 8, 1);
        DrawPixels(ConsoleColor.DarkBlue, 6, 8, 3);
        DrawPixels(ConsoleColor.Blue, 9, 8, 5);

        DrawPixels(ConsoleColor.Blue, 0, 9, 2);
        DrawPixels(ConsoleColor.DarkBlue, 2, 9, 3);
        DrawPixels(ConsoleColor.Red, 5, 9, 1);
        DrawPixels(ConsoleColor.DarkBlue, 6, 9, 2);
        DrawPixels(ConsoleColor.Red, 8, 9, 1);
        DrawPixels(ConsoleColor.DarkBlue, 9, 9, 3);
        DrawPixels(ConsoleColor.Blue, 12, 9, 2);

        DrawPixels(ConsoleColor.Blue, 0, 10, 1);
        DrawPixels(ConsoleColor.DarkBlue, 1, 10, 4);
        DrawPixels(ConsoleColor.Red, 5, 10, 1);
        DrawPixels(ConsoleColor.DarkBlue, 6, 10, 2);
        DrawPixels(ConsoleColor.Red, 8, 10, 1);
        DrawPixels(ConsoleColor.DarkBlue, 9, 10, 4);
        DrawPixels(ConsoleColor.Blue, 13, 10, 1);

        DrawPixels(ConsoleColor.Blue, 0, 11, 1);
        DrawPixels(ConsoleColor.White, 1, 11, 2);
        DrawPixels(ConsoleColor.DarkBlue, 3, 11, 2);
        DrawPixels(ConsoleColor.Red, 5, 11, 4);
        DrawPixels(ConsoleColor.DarkBlue, 9, 11, 2);
        DrawPixels(ConsoleColor.White, 11, 11, 2);
        DrawPixels(ConsoleColor.Blue, 13, 11, 1);

        DrawPixels(ConsoleColor.Blue, 0, 12, 1);
        DrawPixels(ConsoleColor.White, 1, 12, 3);
        DrawPixels(ConsoleColor.Red, 4, 12, 1);
        DrawPixels(ConsoleColor.Yellow, 5, 12, 1);
        DrawPixels(ConsoleColor.Red, 6, 12, 2);
        DrawPixels(ConsoleColor.Yellow, 8, 12, 1);
        DrawPixels(ConsoleColor.Red, 9, 12, 1);
        DrawPixels(ConsoleColor.White, 10, 12, 3);
        DrawPixels(ConsoleColor.Blue, 13, 12, 1);

        DrawPixels(ConsoleColor.Blue, 0, 13, 1);
        DrawPixels(ConsoleColor.White, 1, 13, 2);
        DrawPixels(ConsoleColor.Red, 3, 13, 8);
        DrawPixels(ConsoleColor.White, 11, 13, 2);
        DrawPixels(ConsoleColor.Blue, 13, 13, 1);

        DrawPixels(ConsoleColor.Blue, 0, 14, 3);
        DrawPixels(ConsoleColor.Red, 3, 14, 3);
        DrawPixels(ConsoleColor.Blue, 6, 14, 2);
        DrawPixels(ConsoleColor.Red, 8, 14, 3);
        DrawPixels(ConsoleColor.Blue, 11, 14, 3);

        DrawPixels(ConsoleColor.Blue, 0, 15, 2);
        DrawPixels(ConsoleColor.DarkYellow, 2, 15, 3);
        DrawPixels(ConsoleColor.Blue, 5, 15, 3);
        DrawPixels(ConsoleColor.DarkYellow, 8, 15, 3);
        DrawPixels(ConsoleColor.Blue, 11, 15, 3);

        DrawPixels(ConsoleColor.Blue, 0, 16, 1);
        DrawPixels(ConsoleColor.DarkYellow, 1, 16, 4);
        DrawPixels(ConsoleColor.Blue, 5, 16, 3);
        DrawPixels(ConsoleColor.DarkYellow, 8, 16, 4);
        DrawPixels(ConsoleColor.Blue, 12, 16, 2);

        DrawPixels(ConsoleColor.Blue, 0, 17, 14);

        Console.BackgroundColor = ConsoleColor.Black;
    }
    public static void DrawPixels(ConsoleColor consoleColor, int startX, int startY, int width)
    {
        Console.BackgroundColor = consoleColor;
        Console.SetCursorPosition(startX * 3, startY);

        for (int i = 0; i < width; i++)
        {
            Console.Write("   ");
        } 
    }
}