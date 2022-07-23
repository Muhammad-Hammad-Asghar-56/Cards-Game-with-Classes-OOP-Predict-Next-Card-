using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardsGame.BL
{
    class deck
    {
        private List<card> deckCard = new List<card>();
        public deck()
        {
            for (int j = 1; j <= 4; j++)//        control suits
            { 
                for (int i = 1; i <= 13; i++)//    controls the no. of card
                {

                    card C = new card(i,j);
                    deckCard.Add(C);
                }
            } 
        }
        public void suffleDeck()
        {
            Random randomNumber = new Random();
            for(int i=0;i<deckCard.Count();i++)
            {
                int n = randomNumber.Next();
                if(n > deckCard.Count()) { n = n % deckCard.Count(); }
                exchangeterms(i,n,deckCard);
            }
        }
        public void exchangeterms(int At,int from,List<card> deckList)
        {
            card C = deckList[At];
            deckList[At]=deckList[from];
            deckList[from] = C;
        }
        public card dealCard()
        {
            if (deckCard.Count > 0)
            {
                card returnCard = deckCard[0];
                deckCard.RemoveAt(1);
                return returnCard;
            }
            return null;
        }
        public int totalRemaningCardLeft()
        {
            return deckCard.Count();
        }
    }
}
