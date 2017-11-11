using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class DeckOfCards
    {
        private Card[] deck;
        private const int NUMBER_OF_CARDS = 52;
        private int currentCard;
        private Random randomNumber;

        public DeckOfCards()
        {
            string[] faces = { "Ace", "Deuce", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King"};
            string[] suits = { "Hearts", "Spades", "Diamonds", "Clubs"};

            deck = new Card[NUMBER_OF_CARDS];
            currentCard = 0;
            randomNumber = new Random();

            for (int count = 0; count < deck.Length; ++count)
            {
                deck[count] =
                    new Card(faces[count % 13], suits[count / 13]);
            }
        }

        public void Shuffle()
        {
            currentCard = 0;

            for (int first = 0; first < deck.Length; first++)
            {
                int second = randomNumber.Next(NUMBER_OF_CARDS);

                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            }
        }
        public Card DealCards()
        {
            if (currentCard < deck.Length)
            {
                return deck[currentCard++];
            }
            else
            {
                return null;
            }
        }
    }
}
