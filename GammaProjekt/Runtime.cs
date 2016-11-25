using System;

namespace GammaProjekt
{
    internal class Runtime
    {
        string output = "0";
        string thingiee = " ";
        double numberOne = 0;
        bool newNumber = false;
        internal void Start()
        {
            Graphics();
            Console.CursorVisible = false;
            while (true)
            {
                ShowNumbers();
                var input = Console.ReadKey(true);
                if ((input.Modifiers & ConsoleModifiers.Shift) != 0 && input.Key == ConsoleKey.D7 || input.Key == ConsoleKey.Divide)
                {
                    thingiee = "/";
                    numberOne = double.Parse(output);
                    newNumber = true;
                }
                else if ((input.Modifiers & ConsoleModifiers.Shift) !=0 && input.Key == ConsoleKey.D0 || input.Key == ConsoleKey.Enter)
                {
                    Enter();
                }
                else
                {
                    CheckIfNumber(input.Key);
                    switch (input.Key)
                    {

                        case ConsoleKey.OemComma:
                        case ConsoleKey.OemPeriod:
                            if (!output.Contains(",") && output.Length < 9) output += ",";
                            break;
                        case ConsoleKey.OemPlus:
                        case ConsoleKey.Add:
                            thingiee = "+";
                            numberOne = double.Parse(output);
                            newNumber = true;
                            break;

                        case ConsoleKey.OemMinus:
                    case ConsoleKey.Subtract:
                            thingiee = "-";
                            numberOne = double.Parse(output);
                            newNumber = true;
                            break;
                        case ConsoleKey.X:
                        case ConsoleKey.Multiply:

                            thingiee = "x";
                            numberOne = double.Parse(output);
                            newNumber = true;
                            break;
                        case ConsoleKey.C:
                            if (output == "0")
                            {
                                numberOne = 0;
                                thingiee = " ";
                            }
                            output = "0";
                            break;
                        case ConsoleKey.Backspace:
                            if (!newNumber)
                            {
                                output = output.Remove(output.Length - 1);
                            }
                            else output = "0";
                            if (output.Length == 0)
                                output = "0";
                            break;
                    }
                }
            }
        }

        private void Enter()
        {
            if (thingiee == "+")
                output = (numberOne + double.Parse(output)).ToString();
            else if (thingiee == "-")
                output = (numberOne - double.Parse(output)).ToString();
            else if (thingiee == "x")
                output = (numberOne * double.Parse(output)).ToString();
            else if (thingiee == "/" && numberOne != 0 && output != "0")
                output = (numberOne / double.Parse(output)).ToString();

            else if (thingiee == "/" && numberOne != 0 && output == "0")
            {
                Console.SetCursorPosition(3, 2);
                Console.WriteLine("        NaN");
                Console.ReadKey(true);
            }
                thingiee = " ";
                newNumber = true;
        }
        private void CheckIfNumber(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.D0:
                case ConsoleKey.NumPad0:
                    Number(0);
                    break;
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Number(1);
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Number(2);
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Number(3);
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    Number(4);
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    Number(5);
                    break;
                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    Number(6);
                    break;
                case ConsoleKey.D7:
                case ConsoleKey.NumPad7:
                    Number(7);
                    break;
                case ConsoleKey.D8:
                case ConsoleKey.NumPad8:
                    Number(8);
                    break;
                case ConsoleKey.D9:
                case ConsoleKey.NumPad9:
                    Number(9);
                    break;
            }
        }

        public void Number(int number)
        {
            if (newNumber)
            {
                output = number.ToString();
                newNumber = false;
            }

            else if (output == "0")
            {
                output = number.ToString();
            }
            else if (output.Length < 10)
            {
                output += number.ToString();

            }
        }
        private void ShowNumbers()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("{0}         ", thingiee);
            
            
            Console.WriteLine(output.Length);
            if (output.Length < 11)
            {
                Console.SetCursorPosition(14 - output.Length, 2);
                Console.WriteLine(output);
            }
            else
            {
                var isDecimal = false;
                for (int i = 0; i < 9; i++)
                {
                    if (output[i] == '.')
                        isDecimal = true;
                }

                if (isDecimal)
                {
                    output = output.Remove(10);
                    Console.SetCursorPosition(14 - output.Length, 2);
                    Console.WriteLine(output);
                }
                else
                {
                    Console.SetCursorPosition(3, 2);
                    Console.WriteLine("           ");
                    Console.SetCursorPosition(6, 2);
                    Console.WriteLine("Error");
                }
            }
            Console.SetCursorPosition(0, 15);
        }
        private void Graphics()
        {
            Console.WriteLine("┌───────────────┐");
            Console.WriteLine("│ ┌───────────┐ │");
            Console.WriteLine("│ │           │ │");
            Console.WriteLine("│ └───────────┘ │");
            Console.WriteLine("├───┬───┬───┬───┤");
            Console.WriteLine("│ 1 │ 2 │ 3 │ + │");
            Console.WriteLine("├───┼───┼───┼───┤");
            Console.WriteLine("│ 4 │ 5 │ 6 │ - │");
            Console.WriteLine("├───┼───┼───┼───┤");
            Console.WriteLine("│ 7 │ 8 │ 9 │ x │");
            Console.WriteLine("├───┼───┼───┼───┤");
            Console.WriteLine("│ C │ 0 │ = │ / │");
            Console.WriteLine("└───┴───┴───┴───┘");
        }
    }
}