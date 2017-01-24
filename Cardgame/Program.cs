using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cardgame.Library;

namespace Cardgame
{
    // Hearts, Diamonds, Cloves, Spades
    internal class Program
    {
        static void Main(string[] args)
        {
            var runtime = new Runtime();
            runtime.Start();
        }
    }
}
