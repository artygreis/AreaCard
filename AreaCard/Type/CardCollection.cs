using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCard.Type
{
    public class CardCollection
    {
        private List<Card> cards;
        public CardCollection()
        {
            cards = new List<Card>();
        }
        public List<CardView> GetCardsAll()
        {
            if (cards.Count != 0)
            {
                var cardViews = cards.Select(c => new CardView()
                {
                    Number = c.Number,
                    LastDate = c.LastDate,
                    Name = c.CardInfos.Count() != 0 ? c.CardInfos.Last().Name : "",
                    Out = c.CardInfos.Count() != 0 ? c.CardInfos.Last().Out : null,
                    In = c.CardInfos.Count() != 0 ? c.CardInfos.Last().In : null
                }).ToList();
                cardViews.Sort();
                return cardViews;
            }
            else
                return new List<CardView>();
        }

        public void AddToColletion(List<Card> cards)
        {
            this.cards.AddRange(cards);
        }

        public List<CardView> GetCardsOnHands()
        {
            var cardsCollection = GetCardsAll();

            return cardsCollection.Where(c => !string.IsNullOrEmpty(c.Name) && c.Out != null && c.In == null).ToList();
        }

        public List<CardView> GetCardsLastDate(DateTime lastDate)
        {
            var cardsCollection = GetCardsAll();

            return cardsCollection.Where(c => c.In != null ? c.In <= lastDate : string.IsNullOrEmpty(c.Name) && c.Out == null && c.LastDate <= lastDate).ToList();
        }

        public List<CardView> GetCardsBack()
        {
            var cardsCollection = GetCardsAll();

            return cardsCollection.Where(c => c.In == null && c.Out != null && ((TimeSpan)(DateTime.Now.Date - c.Out)).TotalDays / 30 >= 4 ).ToList();
        }

        public int GetCountCards()
        {
            var cardsCollection = GetCardsAll();

            return cardsCollection.Count;
        }

        public List<string> GetNumberCards()
        {
            var cardsCollection = GetCardsAll();

            return cardsCollection.Select(c => c.Number).ToList();
        }
    }
}
