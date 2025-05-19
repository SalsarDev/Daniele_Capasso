using System;

public class Studente
{
    public string Nome;
    public int Matricola;
    public double MediaVoti;

    public Studente(string nome, int matricola, double mediaVoti)
    {
        Nome = nome;
        Matricola = matricola;
        MediaVoti = mediaVoti;
    }

    public void Stampa()
    {
        Console.WriteLine($"Lo studente {Nome} con matricola {Matricola} ha la media voti di {MediaVoti}");
    }

    public static void Main()
    {
        try
        {
            int count = 0;
            Studente studente1 = null;
            Studente studente2 = null;

            while (count < 2)
            {
                Console.WriteLine($"Inserisci nome Studente {count + 1}:");
                string nome = Console.ReadLine();

                foreach (char c in nome)
                {
                    if (!char.IsLetter(c) && c != ' ')
                    {
                        throw new Exception("Errore. Il nome deve contenere solo lettere e spazi.");
                    }
                }

                Console.WriteLine("Inserisci matricola:");
                int matricola = int.Parse(Console.ReadLine());

                Console.WriteLine("Inserisci media voti:");
                double mediaVoti = double.Parse(Console.ReadLine());

                Studente nuovoStudente = new Studente(nome, matricola, mediaVoti);

                if (count == 0)
                {
                    studente1 = nuovoStudente;
                }
                else if (count == 1)
                {
                    studente2 = nuovoStudente;
                }

                count++;
            }

            Console.WriteLine("\nDati degli studenti inseriti:");
            studente1.Stampa();
            studente2.Stampa();
        }
        catch (FormatException)
        {
            Console.WriteLine("Errore. Inserisci numeri validi per matricola e media voti.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Errore: {ex.Message}");
        }
    }
}

        
    