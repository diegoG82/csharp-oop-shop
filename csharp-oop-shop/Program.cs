

using csharp_oop_shop;
//CREO 5 PRODOTTI


Prodotto gunpla = new Prodotto("Gundam Calibarn", "Modellino da assemblare", 100, 22);

Prodotto fumetto = new Prodotto("Bleach", "Manga", 5, 10);

Prodotto figure = new Prodotto("Going Merry", "Diorama", 120, 22);

Prodotto fumettousa = new Prodotto("Iron man", "Comic", 6, 10);

Prodotto gadget = new Prodotto("Spada Laser", "Replica Spada", 150, 22);





//CREAZIONE ARRAY PRODOTTI
Prodotto[] prodotti = new Prodotto[] { gunpla, fumetto, figure, fumettousa, gadget };

//INVOCAZIONE FUNZIONE ArrayProdotti
ArrayProdotti(args, prodotti);

//Template literal iterazione singolo prodotto

//Console.WriteLine($"il Codice: {gunpla.Codice} si riferisce al prodotto {gunpla.Nome} che è {gunpla.Descrizione} dal prezzo di {gunpla.Prezzo} euro e con iva costa {gunpla.PrezzoIvato} euro, l'iva attualmente e' al {gunpla.Iva}%");

static void ArrayProdotti(string[] args, Prodotto[] prodotti)
{

    foreach (Prodotto prod in prodotti)
    {
        Console.WriteLine($"Codice prodotto: {prod.Codice}");
        Console.WriteLine($"Nome prodotto: {prod.Nome}");
        Console.WriteLine($"Descrizione del prodotto: {prod.Descrizione}");
        Console.WriteLine($"Prezzo: {prod.PrezzoBase} euro");
        Console.WriteLine($"Prezzo con iva: {prod.PrezzoIvato} euro");
        Console.WriteLine();
    }
}

