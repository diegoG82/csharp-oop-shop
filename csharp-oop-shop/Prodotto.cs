namespace csharp_oop_shop
{
    public class Prodotto
    {
        //PROPRIETA'
        public int Codice { get; private set; } = new Random().Next(00000001, 99999999);
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public int Iva { get; set; }

        //COSTRUTTORI

        public Prodotto(string nome, string descrizione, double prezzo, int iva)
        {
          
            this.Nome = nome;
            this.Descrizione = descrizione;
            this.Prezzo = prezzo;
            this.Iva = iva;
        }

        //GETTER
    
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



