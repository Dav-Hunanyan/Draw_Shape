using System;

namespace Draw_Shape_Exercise
{
    internal class Triangle : IMoveable, IPrint
    {

        private int higth;
        private string[,] triangle;

        public Triangle()
        {
            higth = 7;
            triangle = new string[higth, higth];
            for (int i = 0; i < higth; i++)
            {
                for (int j = 0; j < higth; j++)
                {
                    if (i > j)
                    {
                        triangle[i, j] = "*";
                    }
                    else
                    {
                        triangle[i, j] = " ";
                    }
                }
            }
        }
        public void Print()
        {
            for (int i = 0; i < triangle.GetLength(0); i++)
            {
                for (int j = 0; j < triangle.GetLength(1); j++)
                {
                    Console.Write(triangle[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void Move()
        {
            ConsoleKey key;
            do
            {
                Console.Clear();
                Print();
                key = Console.ReadKey().Key;
                if (key == ConsoleKey.W || key == ConsoleKey.UpArrow)
                {
                    for (int i = 0; i < triangle.GetLength(1); i++)
                    {
                        if (triangle[0, i] == "*")
                        {
                            return;
                        }
                    }

                    string[,] temp = new string[triangle.GetLength(0) - 1, triangle.GetLength(1)];
                    for (int i = 0; i < triangle.GetLength(0) - 1; i++)
                    {
                        for (int j = 0; j < triangle.GetLength(1); j++)
                        {
                            temp[i, j] = triangle[i + 1, j];

                        }
                    }
                    triangle = temp;
                }
                if (key == ConsoleKey.S || key == ConsoleKey.DownArrow)
                {
                    string[,] temp = new string[triangle.GetLength(0) + 1, triangle.GetLength(1)];
                    for (int i = 0; i < triangle.GetLength(0) + 1; i++)
                    {
                        for (int j = 0; j < triangle.GetLength(1); j++)
                        {
                            if (i == 0)
                            {
                                temp[i, j] = " ";
                            }
                            else
                            {
                                temp[i, j] = triangle[i - 1, j];
                            }

                        }
                    }

                    triangle = temp;
                }
                if (key == ConsoleKey.A || key == ConsoleKey.LeftArrow)
                {
                    for (int i = 0; i < triangle.GetLength(0); i++)
                    {
                        if (triangle[i, 0] == "*")
                        {
                            return;
                        }
                    }
                    string[,] temp = new string[triangle.GetLength(0), triangle.GetLength(1) - 1];
                    for (int i = 0; i < triangle.GetLength(0); i++)
                    {
                        for (int j = 0; j < triangle.GetLength(1) - 1; j++)
                        {
                            temp[i, j] = triangle[i, j + 1];
                        }
                    }
                    triangle = temp;
                }
                if (key == ConsoleKey.D || key == ConsoleKey.RightArrow)
                {
                    string[,] temp = new string[triangle.GetLength(0), triangle.GetLength(1) + 1];
                    for (int i = 0; i < triangle.GetLength(0); i++)
                    {
                        for (int j = 0; j < triangle.GetLength(1) + 1; j++)
                        {
                            if (j == 0)
                            {
                                temp[i, j] = " ";
                            }
                            else
                            {
                                temp[i, j] = triangle[i, j - 1];
                            }
                        }
                    }
                    triangle = temp;
                }
            } while (key != ConsoleKey.Enter);

        }
    }
}
