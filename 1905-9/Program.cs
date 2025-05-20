using System;
class Program
{
    static void Main()
    {
        // 1. Creare una lista di stringhe
        List<string> listaSpesa = new List<string>();
        // 2. Chiedere all'utente di inserire 5 prodotti
        Console.WriteLine("Inserisci 5 prodotti per la lista della spesa:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Prodotto {i + 1}: ");
            string prodotto = Console.ReadLine();
            listaSpesa.Add(prodotto);
        }
        // 3. Dopo l’inserimento, stampare tutti gli elementi della lista uno per riga
        Console.WriteLine("Lista della Spesa:");
        foreach (string prodotto in listaSpesa)
        {
            Console.WriteLine(prodotto);
        }
    }
}
