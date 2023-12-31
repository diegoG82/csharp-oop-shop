﻿namespace csharp_oop_shop
{
    public class Prodotto
    {
        //PROPRIETA' e STATI
        public int Codice { get; private set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public int Iva { get; set; }

        //COSTRUTTORI

        public Prodotto(string nome, string descrizione, double prezzo, int iva)
        {

            this.Codice = new Random().Next(1, 99999999);
            this.Nome = nome;
            this.Descrizione = descrizione;
            this.Prezzo = prezzo;
            this.Iva = iva;
        }

        //GETTERS

        public double GetPrezzoBase()
        {
            return this.Prezzo;
        }

        public double GetPrezzoIvato()

        {
            return Prezzo + (Prezzo / 100 * Iva);
        }

        public string GetNomeEsteso()

        {
            return this.Codice + " " + this.Nome;
        }

    }
}



