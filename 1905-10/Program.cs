using System;
using System.Collections.Generic;

class Film
{
    public string Titolo;
    public string Regista;
    public int Anno;
    public string Genere;

    public Film(string titolo, string regista, int anno, string genere)
    {
        Titolo = titolo;
        Regista = regista;
        Anno = anno;
        Genere = genere;
    }

    public override string ToString()
    {
        return $"{Titolo}, {Regista}, {Anno}, {Genere}";
    }
}

class Program
{
    static void Main()
    {
        List<Film> listaFilm = new List<Film>();
        string continua;

        // Inserimento film da parte dell'utente
        do
        {
            Console.WriteLine("Inserisci titolo del film:");
            string titolo = Console.ReadLine();
            Console.WriteLine("Inserisci regista del film:");
            string regista = Console.ReadLine();
            Console.WriteLine("Inserisci anno del film:");
            int anno = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci genere del film:");
            string genere = Console.ReadLine();

            listaFilm.Add(new Film(titolo, regista, anno, genere));

            Console.WriteLine("Vuoi inserire un altro film? (s/n)");
            continua = Console.ReadLine();

        } while (continua.ToLower() == "s");

        // Stampa la lista dei film
        Console.WriteLine("\nLista dei film inseriti:");
        foreach (Film film in listaFilm)
        {
            Console.WriteLine(film);
        }

        // Ricerca per genere
        Console.WriteLine("\nInserisci genere da cercare:");
        string genereRicerca = Console.ReadLine();
        Console.WriteLine("Film corrispondenti:");
        foreach (Film film in listaFilm)
        {
            if (film.Genere.ToLower() == genereRicerca.ToLower())
            {
                Console.WriteLine(film);
            }
        }
    }
}
