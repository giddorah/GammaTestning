using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardgame.Library;
using TestLibrary;

namespace Cardgame
{
    internal class Runtime
    {
        public void Start()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Run program");
                Console.WriteLine("2. Run tests");

                var menuInput = Console.ReadKey(true).Key;

                switch (menuInput)
                {
                    case ConsoleKey.D1:
                        ProgramRunner();
                        break;

                    case ConsoleKey.D2:
                        TestRunner();
                        break;

                    default:
                        Console.WriteLine("Not a valid input.");
                        break;
                }
            }
        }

        private static void TestRunner()
        {
            var testRunning = new TestLibrary1();
            testRunning.StartModuleTests();
            Console.ReadLine();
        }

        private void ProgramRunner()
        {
            var cardgame = new Library.Library();

            Console.Write("Enter Card to check: ");

            var readLine = Console.ReadLine();
            if (readLine != null)
            {
                var input = readLine;

                Console.WriteLine(cardgame.InputChecker(input) ? cardgame.Returner(input) : "That's not a real Card.");
            }

            Console.ReadLine();
        }
    }
}
