using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardsGame
{
    class menus
    {
        public static int mainmenu()
        {
            Console.Clear();
            Console.WriteLine(">------------------------------------------------------------<");
            Console.WriteLine(">                  CARD Prediction Game");
            Console.WriteLine(">------------------------------------------------------------<");
            Console.WriteLine();
            Console.WriteLine("Enter 1 For START game ");
            Console.WriteLine("Enter 2 For EXIT game ");
            int option = int.Parse(Console.ReadLine());
            return option;
        }
        public static int PlayerPrediction()
        {
            Console.WriteLine("Enter 1 if the next card will be small");
            Console.WriteLine("Enter 2 if the next card will be Higher");
            int Playeroption = int.Parse(Console.ReadLine());
            return Playeroption;
        }
    }
}
