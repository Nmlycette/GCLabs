using Newtonsoft.Json;

namespace DeckOfCardsApi.Models
{
    public class DrawCardApi
    {
        public bool success { get; set; }
        public string deck_id { get; set; }
        public int remaining { get; set; }
        public List<Card> cards { get; set; }
    }
}
