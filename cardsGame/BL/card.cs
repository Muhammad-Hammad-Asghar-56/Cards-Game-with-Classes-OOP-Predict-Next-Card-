using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardsGame.BL
{
    class card
    {
        private int suit;
        private int value;
        public card() 
        {
        }
        public card(int value,int suit)
        {
            this.suit = suit;
            this.value = value;
        }
        public int getValueInInt()
        {
            return value;
        }
        public string getValueINstring()
        {
            switch (value)
            {
                case 1:
                    {
                        return "ace";
                    }
                case 11:
                    {
                        return "jack"; 
                    }
                case 12:
                    {
                        return "queen";
                    }
                case 13:
                    {
                        return "king";
    
                    }
            }
            return value.ToString();
        }
        public string getSuit()
        {
            switch (suit)
            {
                case 1:
                    {
                        return "Clubs";
                    }
                case 2:
                    {
                        return "Diamonds";
                    }
                case 3:
                    {
                        return "Spades";
                    }
                case 4:
                    {
                        return "Hearts";

                    }
            }
            return "";
        }
        public string getStringOfCard()
        {
            return (value +","+suit);
        }
        public static bool isHigher(card firstcard,card compareThis)
        {
            if(firstcard.getValueInInt() > compareThis.getValueInInt())
            {
                return true;
            }
            return false;
        }
    }
}
