using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocacolaCalculator
{
    public class CocacolaCal
    {
        public string CheckIfDivisibleBy3And5(int input)
        {
            //return "Cocacola";

            //if (input == 15)
            //    return "Cocacola";
            //else return "";

            //if (input % 5 == 0)
            //    return "Cocacola";
            //else return "";

            //if (input % 5 == 0 && input % 3 == 0)
            //    return "Cocacola";
            //else return "";

            if (input % 15 == 0)
                return "Cocacola";
            else return "";

            // Alternativ version 1: metoden skapar en sträng output och den fylls av metoderna som kollar om den är 
            // delbar med tre eller fem så om den inte är delbar med någon blir den tom om den bara är delbar med ena
            // så får den enas output och om den är delbar med båda så blir den cocacola sedan gör den första bokstaven stor

            //string output == "";

            //output = DivisibleBy3(input);
            //output += DivisbleBy5(input);

            //if (output != "")
            //{
            //    output = output[0].ToString().ToUpper() + output.Substring(1);
            //    return output;

            //    Alternative att metoden printar ut och returnerar en bool iställer för att returnera strängen
            //    Console.WriteLine(output);
            //    return bool;
            //}


        }

        public bool CheckIfDivisibleBy3And5Version2(int input)
        {
            //return true;

            //if (input == 15)
            //    return true;
            //else return false;

            //if (input % 5 == 0)
            //    return true;
            //else return false;

            //if (input % 5 == 0 && input % 3 == 0)
            //{
            //    return true;
            //}
            //else return false;

            if (input % 15 == 0)
            {
                // alternative version 1 att metoden skriver ut svaret och att den returnerar så att huvudprogrammet vet att inte anropa de andra metoderna.
                // Console.WriteLine("Cocacola");
                return true;
            }
            else return false;

            // alternative version 2 att metoden anropar de andra två metoderna som skulle då returnera true eller false
            // funkar inte med alternative version 1 (om de andra metoderna följer den dvs) för då kommer de att skriva ut
            // när de anropas från den här metoden 
            // if (DivisibleBy3 && DivisibleBy5)
            //{
            //    return true;
            //}
            //else return false;
        }
    }
}
