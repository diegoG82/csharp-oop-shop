namespace csharp_oop_shop
{
    public class Prodotto
    {
        //ATTRIBUTI
        private int codice;
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public int Iva { get; set; }

        //STATI

        //COSTRUTTORI

        public Prodotto(string nome, string descrizione, double prezzo, int iva)
        {
            //codice per generare il codice del prodotto casuale di 8 cifre comprese tra 00000001 e 99999999
            this.codice = new Random().Next(00000001, 99999999);
            this.Nome = nome;
            this.Descrizione = descrizione;
            this.Prezzo = prezzo;
            this.Iva = iva;
        }

        //GETTER

        public int Codice
        {
            get { return codice; }
        }
        public double PrezzoBase
        {
            get { return Prezzo; }
        }

        public double PrezzoIvato

        {
            get { return Prezzo + (Prezzo / 100 * Iva); }
        }

    }
}



