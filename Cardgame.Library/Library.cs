using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardgame.Library
{
    public class Library
    {
        public string Color { get; private set; }
        public string Card { get; private set; }

        public string Returner(string input)
        {
            input = input.ToLower();
            if (input.Length == 3)
            {
                ColorAdder(input[2]);
                CardAdderDouble(input[0], input[1]);
                return string.Format("{0}{1}", Card, Color);
            }
            else
            {
                ColorAdder(input[1]);
                CardAdderSingle(input[0]);
                return String.Format("{0}{1}", Card, Color);
            }
        }

        private void CardAdderSingle(char number)
        {
            if (number.Equals('a'))
            {
                Card = "Ace";
            }
            else if (number.Equals('k'))
            {
                Card = "King";
            }
            else if (number.Equals('q'))
            {
                Card = "Queen";
            }
            else if (number.Equals('j'))
            {
                Card = "Jack";
            }
            else
            {
                Card = String.Format("{0}", number);
            }
        }

        private void CardAdderDouble(char firstNumber, char secondNumber)
        {
            Card = String.Format("{0}{1}", firstNumber, secondNumber);
        }

        // Hearts, Diamonds, Cloves, Spades
        private void ColorAdder(char input)
        {
            if (input == 'h')
            {
                Color = " of Hearts";
            }
            else if (input == 'd')
            {
                Color = " of Diamonds";
            }
            else if (input == 'c')
            {
                Color = " of Clubs";
            }
            else if (input == 's')
            {
                Color = " of Spades";
            }
        }

        public bool InputChecker(string input)
        {
            input = input.ToLower();
            if (input.Equals("ah") || input.Equals("kh") || input.Equals("qh") || input.Equals("jh") || input.Equals("10h") || input.Equals("9h") || input.Equals("8h") || input.Equals("7h") || input.Equals("6h") || input.Equals("5h") || input.Equals("4h") || input.Equals("3h") || input.Equals("2h") ||
                input.Equals("as") || input.Equals("ks") || input.Equals("qs") || input.Equals("js") || input.Equals("10s") || input.Equals("9s") || input.Equals("8s") || input.Equals("7s") || input.Equals("6s") || input.Equals("5s") || input.Equals("4s") || input.Equals("3s") || input.Equals("2s") ||
                input.Equals("ad") || input.Equals("kd") || input.Equals("qd") || input.Equals("jd") || input.Equals("10d") || input.Equals("9d") || input.Equals("8d") || input.Equals("7d") || input.Equals("6d") || input.Equals("5d") || input.Equals("4d") || input.Equals("3d") || input.Equals("2d") ||
                input.Equals("ac") || input.Equals("kc") || input.Equals("qc") || input.Equals("jc") || input.Equals("10c") || input.Equals("9c") || input.Equals("8c") || input.Equals("7c") || input.Equals("6c") || input.Equals("5c") || input.Equals("4c") || input.Equals("3c") || input.Equals("2c"))
            {
                return true;
            }

            return false;
        }
    }
}
