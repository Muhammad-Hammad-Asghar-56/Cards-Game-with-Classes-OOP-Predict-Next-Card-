using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardsGame.BL
{
    class players
    {
        private int score=0;
        private card playersCard;
        
        public players(card playersCard) => this.playersCard = playersCard;
        public void setCard(card playersCard)
        {
            this.playersCard = playersCard;
        }
        public card getCard() => playersCard;
        public int getScore() => score;
        public void incrementInScoring()
        {
            score=+10;
        }
    }
}
