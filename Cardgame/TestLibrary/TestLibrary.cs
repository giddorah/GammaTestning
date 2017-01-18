using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardgame.Tester;
using System.IO;
using Cardgame.Library;

namespace TestLibrary
{
    public class TestLibrary1
    {
        public void StartModuleTests()
        {
            var cardgame = new Library();

            var filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var fileName = "\\testresults.txt";
            var totalPath = filePath + fileName;

            List<string> cardCollection = new List<string> { "ah", "kh", "qh", "jh", "10h", "9h", "8h", "7h", "6h", "5h", "4h", "3h", "2h",
               "as", "ks", "qs", "js", "10s", "9s", "8s", "7s", "6s", "5s", "4s", "3s", "2s",
               "ad", "kd", "qd", "jd", "10d", "9d", "8d", "7d", "6d", "5d", "4d", "3d", "2d",
               "ac", "kc", "qc", "jc", "10c", "9c", "8c", "7c", "6c", "5c", "4c", "3c", "2c", "korv",
            "AH", "KH", "QH", "JH", "10H", "9H", "8H", "7H", "6H", "5H", "4H", "3H", "2H",
            "AD", "KS", "QS", "JS", "10S", "9S", "8S", "7S", "6S", "5S", "4S", "3S", "2S",
            "AD", "KD", "QD", "JD", "10D", "9D", "8D", "7D", "6D", "5D", "4D", "3D", "2D",
            "AC", "KC", "QC", "JC", "10C", "9C", "8C", "7C", "6C", "5C", "4C", "3C", "2C", "KORV", "09", "4", "33"};

            List<string> logCollection = new List<string> ();

            int i = 1;

            foreach (var card in cardCollection)
            {
                if (cardgame.InputChecker(card))
                {
                    logCollection.Add(String.Format("{0}. {1} - Passed.", i, card));
                }
                else
                {
                    logCollection.Add(String.Format("{0}. {1} - Failed.", i, card));
                }
                i++;
            }

            File.WriteAllLines(totalPath, logCollection);
            Console.WriteLine("All tests run.");
            
        }
    }
}

               