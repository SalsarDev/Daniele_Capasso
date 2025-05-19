using System;

class Program
{
    // Metodo Somma
    static int Somma(int a, int b)
    {
        return a + b;
    }

    // Metodo Moltiplica
    static int Moltiplica(int a, int b)
    {
        return a * b;
    }

    // Metodo Risultato
    static void Risultato(string operazione, int risultato)
    {
        Console.WriteLine($"Il risultato dell'operazione {operazione} è: {risultato}");
    }

    static void Main()
    {
        try
        {
            // ReadLine dei numeri
            Console.WriteLine("Inserisci primo numero:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci secondo numero:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Specifica operazione (+ o *):");
            string operazione = Console.ReadLine();

            int risultato;

            // Ciclo if per creazione menu e scelta operazione
            if (operazione == "+")
            {
                risultato = Somma(a, b);
                Risultato(operazione, risultato);
            }
            else if (operazione == "*")
            {
                risultato = Moltiplica(a, b);
                Risultato(operazione, risultato);
            }
            else
            {
                Console.WriteLine("Operazione non valida.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Errore: inserisci solo numeri validi.");
        }
        }
    }