using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cardsGame.BL;
namespace cardsGame
{
    class playerUI
    {
        public static  void displayGameStatus(card previousCard,int n)
        {
            Console.WriteLine("The Card is {0} and Remaining is {1} ", previousCard.getStringOfCard(), n);
        }

    }
}
