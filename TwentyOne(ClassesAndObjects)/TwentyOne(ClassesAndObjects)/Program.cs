using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne_ClassesAndObjects_
{
    class Program
    {
        static void Main(string[] args)
        {

            Deck deck = new Deck();
            //deck.Shuffle(times: 3);


            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();





            //LABMDA FUNCTION EXAMPLES FOR REFERENCE
            //int count = deck.Cards.Count(x => x.Face == Face.Ace);

            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();

            //List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };

            ////Me playing around with lambda functions 
            ////List<int> newNumList = numberList.Where(x => x > 20).ToList();
            ////foreach (int num in newNumList)
            ////{
            ////    Console.WriteLine(num);
            ////}
            //int sum = numberList.Where(x => x > 20).Sum();
            //Console.WriteLine(sum);
        }
    }
}
