using System;

public class Persona
{
    public string Name;
    public string Cognome;
    public int Anno;

    public Persona(string name, string cognome, int anno)
    {
        Name = name;
        Cognome = cognome;
        Anno = anno;
    }

    public void Stampa()
    {
        Console.WriteLine($"{Name} {Cognome} è nato il {Anno}");
    }

    public static void Main()
    {
        try
        {
            int count = 0;
            Persona persona1 = null;
            Persona persona2 = null;

            while (count < 2)
            {
                Console.WriteLine($"Inserisci nome persona :");
                string nome = Console.ReadLine();

                Console.WriteLine("Inserisci cognome persona:");
                string cognome = Console.ReadLine();

                foreach (char c in nome + cognome)
                {
                    if (!char.IsLetter(c) && c != ' ')
                    {
                        throw new Exception("Errore. Il nome e cognome devono contenere solo lettere e spazi.");
                    }
                }

                Console.WriteLine("Inserisci anno di nascita:");
                int anno = int.Parse(Console.ReadLine());

                Persona nuovapersona = new Persona(nome, cognome, anno);

                if (count == 0)
                {
                    persona1 = nuovapersona;
                }
                else if (count == 1)
                {
                    persona2 = nuovapersona;
                }

                count++;
            }

            Console.WriteLine("Dati inseriti:");
            persona1.Stampa();
            persona2.Stampa();
        }
        catch (FormatException)
        {
            Console.WriteLine("Errore. Inserisci un anno valido in formato numerico.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Errore: {ex.Message}");
        }
    }
}

