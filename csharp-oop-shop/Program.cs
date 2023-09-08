

using csharp_oop_shop;

Prodotto gunpla = new Prodotto("Gundam Calibarn", "Modellino da assemblare", 100, 22);

Console.WriteLine($"il Codice: {gunpla.Codice} si riferisce al prodotto {gunpla.Nome} che è {gunpla.Descrizione} dal prezzo di {gunpla.Prezzo} euro e con iva costa {gunpla.PrezzoIvato} euro, l'iva attualmente e' al {gunpla.Iva}%");
