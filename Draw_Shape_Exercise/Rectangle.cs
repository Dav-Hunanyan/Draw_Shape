using System;

namespace Draw_Shape_Exercise
{
    internal class Rectangle : IMoveable, IPrint
    {
        private int length;
        private int higth;
        private string[,] rect;

        public Rectangle()
        {
            length = 20;
            higth = 5;
            rect = new string[higth, length];
            for (int i = 0; i < higth; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    rect[i, j] = "*";
                }
            }
        }

        public void Print()
        {
            for (int i = 0; i < rect.GetLength(0); i++)
            {
                for (int j = 0; j < rect.GetLength(1); j++)
                {
                    Console.Write(rect[i, j]);
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
                    for (int i = 0; i < rect.GetLength(1); i++)
                    {
                        if (rect[0, i] == "*")
                        {
                            return;
                        }
                    }

                    string[,] temp = new string[rect.GetLength(0) - 1, rect.GetLength(1)];
                    for (int i = 0; i < rect.GetLength(0) - 1; i++)
                    {
                        for (int j = 0; j < rect.GetLength(1); j++)
                        {
                            temp[i, j] = rect[i + 1, j];
                        }
                    }
                    rect = temp;
                }
                if (key == ConsoleKey.S || key == ConsoleKey.DownArrow)
                {
                    string[,] temp = new string[rect.GetLength(0) + 1, rect.GetLength(1)];
                    for (int i = 0; i < rect.GetLength(0) + 1; i++)
                    {
                        for (int j = 0; j < rect.GetLength(1); j++)
                        {
                            if (i == 0)
                            {
                                temp[i, j] = " ";
                            }
                            else
                            {
                                temp[i, j] = rect[i - 1, j];
                            }
                        }
                    }

                    rect = temp;
                }
                if (key == ConsoleKey.A || key == ConsoleKey.LeftArrow)
                {
                    for (int i = 0; i < rect.GetLength(0); i++)
                    {
                        if (rect[i, 0] == "*")
                        {
                            return;
                        }
                    }
                    string[,] temp = new string[rect.GetLength(0), rect.GetLength(1) - 1];
                    for (int i = 0; i < rect.GetLength(0); i++)
                    {
                        for (int j = 0; j < rect.GetLength(1) - 1; j++)
                        {
                            temp[i, j] = rect[i, j + 1];
                        }
                    }
                    rect = temp;
                }
                if (key == ConsoleKey.D || key == ConsoleKey.RightArrow)
                {
                    string[,] temp = new string[rect.GetLength(0), rect.GetLength(1) + 1];
                    for (int i = 0; i < rect.GetLength(0); i++)
                    {
                        for (int j = 0; j < rect.GetLength(1) + 1; j++)
                        {
                            if (j == 0)
                            {
                                temp[i, j] = " ";
                            }
                            else
                            {
                                temp[i, j] = rect[i, j - 1];
                            }
                        }
                    }
                    rect = temp;
                }

            } while (key != ConsoleKey.Enter);



        }
    }
}
