using System;

public class Libro
{
    public string Titolo;
    public string Autore;
    public int AnnodiPubblicazione;

    public override string ToString()
    {
        return $"Titolo: {Titolo}, Autore: {Autore}, Anno di Pubblicazione: {AnnodiPubblicazione}";
    }

    public override bool Equals(object obj)
    {
        if (obj is Libro altro)
        {
            return this.Titolo == altro.Titolo && this.Autore == altro.Autore;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(this.Titolo, this.Autore);
    }
}

public class Program
{
    public static void Main()
    {
        try
        {
            // Primo libro
            Console.WriteLine("Inserisci Titolo primo Libro:");
            string titolo1 = Console.ReadLine();

            Console.WriteLine("Inserisci Autore primo Libro:");
            string autore1 = Console.ReadLine();

            Console.WriteLine("Inserisci Anno di Pubblicazione primo Libro:");
            int anno1 = int.Parse(Console.ReadLine());

            Libro libro1 = new Libro
            {
                Titolo = titolo1,
                Autore = autore1,
                AnnodiPubblicazione = anno1
            };

            // Secondo libro
            Console.WriteLine("Inserisci Titolo secondo Libro:");
            string titolo2 = Console.ReadLine();

            Console.WriteLine("Inserisci Autore secondo Libro:");
            string autore2 = Console.ReadLine();

            Console.WriteLine("Inserisci Anno di Pubblicazione secondo Libro:");
            int anno2 = int.Parse(Console.ReadLine());

            Libro libro2 = new Libro
            {
                Titolo = titolo2,
                Autore = autore2,
                AnnodiPubblicazione = anno2
            };

            // Output
            Console.WriteLine("Dati dei libri inseriti:");
            Console.WriteLine(libro1.ToString());
            Console.WriteLine(libro2.ToString());
            Console.WriteLine("libro1 è uguale a libro2? " + libro1.Equals(libro2));
        }
        catch (FormatException)
        {
            Console.WriteLine("Errore: Hai inserito un valore non numerico dove era richiesto un numero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Errore generico: {ex.Message}");
        }
    }
}
