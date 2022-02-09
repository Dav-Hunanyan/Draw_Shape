using System;

namespace Draw_Shape_Exercise
{
    static class Color
    {
        enum Colors
        {
            Red = ConsoleColor.Red,
            Green = ConsoleColor.Green,
            Blue = ConsoleColor.Blue,
            Yellow = ConsoleColor.Yellow
        }

        public static void Choose_Color()
        {
            Console.WriteLine("\nWhat Color do you like to use for shape?");
            Console.WriteLine("1.Red 2.Green 3.Blue 4.Yellow");
            string color = Console.ReadLine();
            switch (color)
            {
                case "1":
                case "Red":
                    Console.ForegroundColor = (ConsoleColor)Colors.Red;
                    break;
                case "2":
                case "Green":
                    Console.ForegroundColor = (ConsoleColor)Colors.Green;
                    break;
                case "3":
                case "Blue":
                    Console.ForegroundColor = (ConsoleColor)Colors.Blue;
                    break;
                case "4":
                case "Yellow":
                    Console.ForegroundColor = (ConsoleColor)Colors.Yellow;
                    break;
                default:
                    break;
            }
        }
    }
}
