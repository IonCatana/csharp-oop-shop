using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpShop
{
    //----------- CLASSE PRODOTTO ---------------
    internal class Prodotto
    {
        //---------- DICHIARO LE VARIABILI --------------
        private int codiceProdotto;
        private string nomeProdotto;
        private string descrizione;
        private double prezzo;
        private string iva;
        private string v;

        //---------- COSTRUTTORE --------------
        public Prodotto(string nomeProdotto, string descrizione, double prezzo, string iva)
        {
            this.nomeProdotto = nomeProdotto;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }

        public Prodotto(string v)
        {
            this.v = v;
        }

        //-------------- METODO 1 CREAZIONE CODICE -------------
        public int GetGeneraCodiceProdotto()
        {
            Random random = new Random();
            int numero = random.Next(1000000);
            return numero;
        }

        //------------ METODO 2 CALCOLA PREZZO CON IVA ------------
        public double GetCalcolaPrezzoIva()
        {
            double prezzoConIva = prezzo * 1.22;
            return prezzoConIva;
        }

        //----------- METODO 3 STAMPA NOME ESTESO ----------
        public string GetNomeEsteso()
        {
            string nomePiuCodice = nomeProdotto + " " + GetGeneraCodiceProdotto();
            return nomePiuCodice;
        }

        //------------ METODO 4 STAMPA DATI ---------------
        public void StampaDati()
        {
            Console.WriteLine("BENVENUTI NEL NOSTRO E-COMMERCE" + "\n");
            Console.WriteLine("-------- I NOSTRI PRODOTTI --------");
            Console.WriteLine("Prodotto: " + GetNomeEsteso());
            Console.WriteLine("-----------------------------------" + "\n");
            Console.WriteLine("------------DESCRIZIONE------------");
            Console.WriteLine(descrizione);
            Console.WriteLine("-----------------------------------" + "\n");
            Console.WriteLine("--------------COSTI----------------");
            Console.WriteLine("Prezzo senza IVA: " + prezzo);
            Console.WriteLine("Prezzo calcolato con IVA: " + GetCalcolaPrezzoIva());
            Console.WriteLine("...................................");
            Console.WriteLine("\n" + "\n");
        }

    }
}