using System;


namespace GammaProjekt
{

    public class Runtime
    {
        string output = "0";
        string op = " ";
        double numberOne = 0;
        double operatorRepeatNumber = 0;
        bool newNumber = false;
        internal void Start()
        {
            CalculatorGraphics();
            ControlsGraphics();
            Console.CursorVisible = false;
            while (true)
            {
                ShowNumbers();
                var input = Console.ReadKey(true);
                if ((input.Modifiers & ConsoleModifiers.Shift) != 0 && input.Key == ConsoleKey.D7 || input.Key == ConsoleKey.Divide)
                {
                    ChangeOperator("/");
                }
                else if ((input.Modifiers & ConsoleModifiers.Shift) != 0 && input.Key == ConsoleKey.D0 || input.Key == ConsoleKey.Enter)
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
                            if (!output.Contains(".") && output.Length < 9) output += ".";
                            break;
                        case ConsoleKey.OemPlus:
                        case ConsoleKey.Add:
                            ChangeOperator("+");
                            break;
                        case ConsoleKey.OemMinus:
                        case ConsoleKey.Subtract:
                            ChangeOperator("-");
                            break;
                        case ConsoleKey.X:
                        case ConsoleKey.Multiply:
                            ChangeOperator("x");
                            break;
                        case ConsoleKey.C:
                            if (output == "0")
                            {
                                numberOne = 0;
                                op = " ";
                            }
                            operatorRepeatNumber = 0;
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
                        case ConsoleKey.S:
                            try
                            {
                                output = (double.Parse(output) * double.Parse(output)).ToString();
                            }
                            catch (Exception)
                            {

                                output = (double.Parse(output.Replace(".", ",")) * double.Parse(output.Replace(".", ","))).ToString();
                            }
                            break;
                        case ConsoleKey.R:
                            try
                            {
                                output = SquareRoot(double.Parse(output)).ToString();
                            }
                            catch (Exception)
                            {
                                output = SquareRoot(double.Parse(output.Replace(".", ","))).ToString();
                            }
                            break;
                    }
                }
            }
        }

        public double SquareRoot(double input)
        {
            return Math.Sqrt(input);
        }

        private void ChangeOperator(string newOperator)
        {
            if (op == newOperator)
            {
                if (operatorRepeatNumber == 0)
                    try
                    {
                        operatorRepeatNumber = double.Parse(output);
                    }
                    catch (Exception)
                    {
                        output = output.Replace(".", ",");
                        operatorRepeatNumber = double.Parse(output);
                    }
                if (newOperator == "+") numberOne += operatorRepeatNumber;
                else if (newOperator == "-") numberOne -= operatorRepeatNumber;
                else if (newOperator == "/") numberOne /= operatorRepeatNumber;
                else if (newOperator == "x") numberOne *= operatorRepeatNumber;
                output = numberOne.ToString();
            }
            else if (op == " ")
            {
                try
                {
                    numberOne = double.Parse(output);
                }
                catch (Exception)
                {
                    output = output.Replace(".", ",");
                    numberOne = double.Parse(output);
                }
            }

            op = newOperator;
            newNumber = true;
        }

        private void Enter()
        {
            var secondNumber = 0.0;
            try
            {
                secondNumber = double.Parse(output);
            }
            catch (Exception)
            {
                output = output.Replace(".", ",");
                secondNumber = double.Parse(output);
            }
            if (op == "+")
                output = (numberOne + secondNumber).ToString();
            else if (op == "-")
                output = (numberOne - secondNumber).ToString();
            else if (op == "x")
                output = (numberOne * secondNumber).ToString();
            else if (op == "/" && numberOne == 0)
                output = "0";
            else if (op == "/" && numberOne != 0 && output != "0")
                output = (numberOne / secondNumber).ToString();
            else if (op == "/" && numberOne != 0 && output == "0")
            {
                Console.SetCursorPosition(3, 2);
                Console.WriteLine("        NaN");
                output = "0";
                numberOne = 0;
                Console.ReadKey(true);
            }
            op = " ";
            newNumber = false;
        }
        private void CheckIfNumber(ConsoleKey input)
        {
            switch (input)
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
            Console.WriteLine("{0}         ", op);

            if (output.Length < 11)
            {
                Console.SetCursorPosition(14 - output.Length, 2);
                Console.WriteLine(output.Replace(",", "."));
            }
            else
            {
                var isDecimal = false;

                if (output.Contains("."))
                    isDecimal = true;

                if (isDecimal)
                {
                    output = output.Remove(10);
                    Console.SetCursorPosition(14 - output.Length, 2);
                    Console.WriteLine(output.Replace(",", "."));
                }
                else
                {
                    Console.SetCursorPosition(3, 2);
                    Console.WriteLine("           ");
                    Console.SetCursorPosition(6, 2);
                    Console.WriteLine("Error");
                    output = "0";
                    numberOne = 0;
                }
            }
            Console.SetCursorPosition(0, 15);
        }
        private void CalculatorGraphics()
        {
            Console.WriteLine("╭───────────────╮");
            Console.WriteLine("│ ┌───────────┐ │");
            Console.WriteLine("│ │           │ │");
            Console.WriteLine("│ └───────────┘ │");
            Console.WriteLine("├───┬───┬───┬───┤");
            Console.WriteLine("│ x²│ √ │ ← │ + │");
            Console.WriteLine("├───┼───┼───┼───┤");
            Console.WriteLine("│ 1 │ 2 │ 3 │ - │");
            Console.WriteLine("├───┼───┼───┼───┤");
            Console.WriteLine("│ 4 │ 5 │ 6 │ x │");
            Console.WriteLine("├───┼───┼───┼───┤");
            Console.WriteLine("│ 7 │ 8 │ 9 │ / │");
            Console.WriteLine("├───┼───┼───┼───┤");
            Console.WriteLine("│ C │ 0 │ . │ = │");
            Console.WriteLine("╰───┴───┴───┴───╯");
        }

        private void ControlsGraphics()
        {
            Console.WriteLine("Controls:");
            Console.WriteLine("\"+\" for addition");
            Console.WriteLine("\"-\" for subtraction");
            Console.WriteLine("\"x\" for multiplication");
            Console.WriteLine("\"/\" for Division");
            Console.WriteLine("\"s\" for squared");
            Console.WriteLine("\"r\" for root");
            Console.WriteLine("\"c\" to clear (twice to clear all)");
            Console.WriteLine("\".\" or \",\" to add a decimalpoint");
            Console.WriteLine("\"←\" (backspace) to remove the last number");
        }
    }
}