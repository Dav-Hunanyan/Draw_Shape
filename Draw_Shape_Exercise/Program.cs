using System;
using System.Threading;

namespace Draw_Shape_Exercise
{
    internal class Program
    {

        static void Main(string[] args)
        {
          
        Start: Console.WriteLine("What shape do you want to Draw?");
            Console.Write("1.Rectangle 2.Triangle   ");
            string choose = Console.ReadLine();
            switch (choose)
            {
                case "1":
                case "Rectangle":
                    Rectangle rectangle = new Rectangle();
                    Color.Choose_Color();
                    Console.WriteLine("Move shape with arrow and WASD keys(Enter for exit)");
                    Thread.Sleep(3000);
                    Console.Clear();
                    rectangle.Move();
                    break;
                case "2":
                case "Triangle":
                    Triangle triangle = new Triangle();
                    Color.Choose_Color();
                    Console.WriteLine("Move shape with arrow and WASD keys(Enter for exit)");
                    Thread.Sleep(3000);
                    Console.Clear();
                    triangle.Move();
                    break;
                default:
                    Console.WriteLine("Oops,Choose right!!!   ");
                    goto Start;
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            goto Start;


        }

    }
}
