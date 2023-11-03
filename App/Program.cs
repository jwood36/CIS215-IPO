using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App {
    internal class Program {
        static void Main(string[] args) {
            Output.Line("Enter Input: ");
			Console.SetIn ( new StreamReader ( Console.OpenStandardInput ( 2048 ) ) );
			var inp = Console.ReadLine();
            int WordCnt, CharCnt, NumCnt, SpecCnt;
            /********************** DO NOT EDIT ABOVE THIS LINE **********************************/



            // THIS SHOULD BE THE LAST STATEMENT FOR MAIN
            Console.Read();
        }

    }
}
