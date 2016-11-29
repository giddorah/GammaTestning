using System;


namespace GammaProjekt
{
    public class Runtime
    {
        // Classvariables used in more methods than one.
        string output = "0";
        string op = " ";
        double numberOne = 0;
        double operatorRepeatNumber = 0;
        bool newNumber = false;
        // End of class variables.
        internal void Start()
        {
            CalculatorGraphics(); // Shows the user interface (the caluculator)
            ControlsGraphics(); // Shows a guide for what is possible.
            Console.CursorVisible = false; // Hides the user cursor from the console.
            while (true) // Loops through the entire project indefinately
            {
                ShowNumbers(); // Shows the current numbers that have been entered in the right position
                var input = Console.ReadKey(true); // Accepts input from user.
                if ((input.Modifiers & ConsoleModifiers.Shift) != 0 && input.Key == ConsoleKey.D7 || input.Key == ConsoleKey.Divide)
                { // If input is shift + 7 (/) or the /-key on numpad.
                    ChangeOperator("/"); // Sets the visible operator to /
                }
                else if ((input.Modifiers & ConsoleModifiers.Shift) != 0 && input.Key == ConsoleKey.D0 || input.Key == ConsoleKey.Enter)
                { // If input is shift + 0 (=) or enter
                    Enter(); // Makes calculation
                }
                else // If input is not one of the above
                {
                    CheckIfNumber(input.Key); // Checks what input is entered by the user
                    switch (input.Key)
                    {
                        case ConsoleKey.OemComma: // If user presses . or ,
                        case ConsoleKey.OemPeriod:
                            if (!output.Contains(".") && output.Length < 9) output += ".";
                            break; // If output does NOT contain . and has a length shorter than 9. Output is set to .
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
                            if (output == "0") // If output is 0
                            {
                                numberOne = 0; // Sets numberone to 0
                                op = " "; // Clears the operator
                            }
                            operatorRepeatNumber = 0; // Sets the last entered number to 0
                            output = "0"; // Shows a 0 on the screen
                            break;
                        case ConsoleKey.Backspace:
                            if (!newNumber) // If notnumber is not true
                            {
                                output = output.Remove(output.Length - 1); // Remove the last entered number
                            }
                            else output = "0"; // If output is 0
                            if (output.Length == 0)
                                output = "0"; // Sets output to 0
                            break;
                        case ConsoleKey.S:
                            try // Tries the below operation
                            { // multiplicates output with output
                                output = (double.Parse(output) * double.Parse(output)).ToString();
                            }
                            catch (Exception) // Runs if above throws an exception
                            {
                                // Changes the . to , (neccessary if the keyboard region is another than swedish)
                                output = (double.Parse(output.Replace(".", ",")) * double.Parse(output.Replace(".", ","))).ToString();
                            }
                            break;
                        case ConsoleKey.R:
                            try // Tries below
                            { // Tries to find the root from input
                                output = SquareRoot(double.Parse(output)).ToString();
                            }
                            catch (Exception)
                            { // Changes . to ,
                                output = SquareRoot(double.Parse(output.Replace(".", ","))).ToString();
                            }
                            break;
                    }
                }
            }
        }

        public double SquareRoot(double input)
        { // Finds the square root out of input.
            return Math.Sqrt(input);
        }

        private void ChangeOperator(string newOperator)
        { // If user enters a new operator (changes from + to - or so)
            if (op == newOperator)
            {
                if (operatorRepeatNumber == 0)
                    try // Try/catch to see that it works.
                    {
                        operatorRepeatNumber = double.Parse(output);
                    }
                    catch (Exception)
                    {
                        output = output.Replace(".", ",");
                        operatorRepeatNumber = double.Parse(output);
                    } // Makes the calculations based on what operator the user chose.
                if (newOperator == "+") numberOne = Addition(numberOne, operatorRepeatNumber);
                else if (newOperator == "-") numberOne = Subtraction(numberOne, operatorRepeatNumber);
                else if (newOperator == "x") numberOne = Multiplication(numberOne, operatorRepeatNumber);
                else if (newOperator == "/") numberOne = Division(numberOne, operatorRepeatNumber);
                output = numberOne.ToString();
            }
            else if (op == " ")
            { // If the operator is empty.
                try
                { // Try/catch to see if numberOne can be caught
                    numberOne = double.Parse(output);
                }
                catch (Exception)
                { // Changes . to , if not a swedish region.
                    output = output.Replace(".", ",");
                    numberOne = double.Parse(output);
                }
            }

            op = newOperator;
            newNumber = true;
        }

        private void Enter()
        { // Method if the user clicks enter or =
            
            var numberTwo = 0.0; // Resets numbertwo to 0
            try // Try/catch to check input
            {
                numberTwo = double.Parse(output);
            }
            catch (Exception)
            { // Replaces . with , on non-swedish regions.
                output = output.Replace(".", ",");
                numberTwo = double.Parse(output);
            } // Changes operator
            if (op == "+")
                output = Addition(numberOne, numberTwo).ToString();
            else if (op == "-")
                output = Subtraction(numberOne, numberTwo).ToString();
            else if (op == "x")
                output = Multiplication(numberOne, numberTwo).ToString();
            else if (op == "/")
                output = Division(numberOne, numberTwo).ToString();

            op = " ";
            newNumber = false;
        }

        public double Division(double firstNumber, double secondNumber)
        {
            if (firstNumber == 0) return 0;
            else if (secondNumber == 0)
            {
                Console.SetCursorPosition(3, 2);
                Console.WriteLine("        NaN");
                output = "0";
                numberOne = 0;
                //Console.ReadKey(true); // Why is this here?
                return 0;
            }
            return firstNumber / secondNumber;
        }

        public double Multiplication(double numberOne, double numberTwo)
        {
            return numberOne * numberTwo;
        }

        public double Subtraction(double numberOne, double numberTwo)
        {
            return (numberOne - numberTwo);
        }

        public double Addition(double numberOne, double numberTwo)
        {
            return (numberOne + numberTwo);
        }

        public void CheckIfNumber(ConsoleKey input)
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