

using csharp_oop_shop;

Prodotto gunpla = new Prodotto("Modellino Robot", "Il Gunpla", 100, 22);

Console.WriteLine($"il Codice: {gunpla.Codice} si riferisce al prodotto {gunpla.Nome} che è {gunpla.Descrizione} dal prezzo di {gunpla.Prezzo} e con iva costa {gunpla.PrezzoIvato}, l'iva attualmente e' al {gunpla.Iva}%");
