using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cardsGame.BL;
namespace cardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            deck deckCard = new deck();
            int option;
            bool gameStart=false;
            //                         Shall we Start game
            while (true)
            {
                option = menus.mainmenu();
                if (option == 1) { gameStart = true; break; }
            }
            
            card PlayerCard = deckCard.dealCard();
            players P1 = new players(PlayerCard);
            card nextCard = new card();
            //                         Starts game
            bool IsWin=false;
            while (gameStart)
            {

                int Playeroption = menus.PlayerPrediction();
                playerUI.displayGameStatus(P1.getCard(),deckCard.totalRemaningCardLeft());
                deckCard.suffleDeck();
                nextCard = deckCard.dealCard();
                if (Playeroption == 1)
                {
                    if (card.isHigher(P1.getCard(), nextCard))
                    {
                        P1.incrementInScoring();
                        P1.setCard(nextCard);
                    }
                    else
                    {
                        IsWin=false;
                        break;
                    }
                }
                if (Playeroption == 2)
                {
                    if (!card.isHigher(P1.getCard(), nextCard))
                    {
                        P1.incrementInScoring();
                        P1.setCard(nextCard);
                    }
                    else
                    {
                        IsWin = false;
                        break;
                    }
                }
                if(deckCard.totalRemaningCardLeft()==0)
                {
                    IsWin = true;
                }
            }
            //                                Results
            if(IsWin)
            {
                Console.WriteLine("You Win the match");
            }
            if (IsWin)
            {
                Console.WriteLine("You lose the match game ");
                Console.WriteLine("The previous card is {0} and next is {1}", P1.getCard().getStringOfCard(), nextCard.getStringOfCard());
            }
        }
    } 
}
