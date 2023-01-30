using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Flurl.Http;
using DeckOfCardsApi.Models;

namespace DeckOfCardsApi.Controllers
{

    public class CardDeckController : Controller
    {

        public IActionResult Cards()
        {
            string apiUriNewDeck = "https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1";
            var apiTaskNewDeck = apiUriNewDeck.GetJsonAsync<NewDeckApi>();
            apiTaskNewDeck.Wait();
            NewDeckApi deck = apiTaskNewDeck.Result;

            string apiUriDraw = $"https://deckofcardsapi.com/api/deck/{deck.deck_id}/draw/?count=5";
            var apiTaskDraw = apiUriDraw.GetJsonAsync<DrawCardApi>();
            apiTaskDraw.Wait();
            DrawCardApi cardsDrawn = apiTaskDraw.Result;
            return View(cardsDrawn.cards);
        }
    }
}
