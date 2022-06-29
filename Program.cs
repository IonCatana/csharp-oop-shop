//------------ creo l'oggetto ------------
using CsharpShop;

Prodotto mioProdotto = new Prodotto("ROG Strix Scar 17", "Il laptop da gaming ROG", 2956.90, "22%");
mioProdotto.GetGeneraCodiceProdotto();
mioProdotto.GetCalcolaPrezzoIva();
mioProdotto.GetNomeEsteso();
mioProdotto.StampaDati();