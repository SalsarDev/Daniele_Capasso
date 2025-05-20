using System;

class Macchina
{
    public string Motore;
    public float VelocitaMac;
    public int SospensioniMax;
    public int NrModifiche;

    public Macchina(string motore)
    {
        Motore = motore;
        VelocitaMac = 100.0f;
        SospensioniMax = 3;
        NrModifiche = 0;
    }

    public void AumentaVelocita()
    {
        VelocitaMac += 10;
        NrModifiche++;
    }

    public void CambiaMotore(string nuovoMotore)
    {
        Motore = nuovoMotore;
        NrModifiche++;
    }

    public void AumentaSospensioni()
    {
        SospensioniMax += 1;
        NrModifiche++;
    }

    public void StampaInfo(string nomeUtente)
    {
        Console.WriteLine($"Utente: {nomeUtente}");
        Console.WriteLine($"Motore: {Motore}");
        Console.WriteLine($"Velocità: {VelocitaMac}");
        Console.WriteLine($"Sospensioni Max: {SospensioniMax}");
        Console.WriteLine($"Numero modifiche: {NrModifiche}");

    }
}

class Utente
{
    public string Nome;
    public int Credito;

    public Utente(string nome, int credito)
    {
        Nome = nome;
        Credito = credito;
    }

    public bool HaCredito()
    {
        return Credito > 0;
    }

    public void UsaCredito()
    {
        Credito--;
    }
}

class Program
{

static void Main()
{
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine($"Inserisci il nome dell'utente {i + 1}:");
        string nome = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("Il nome non può essere vuoto.");
            i--; // Resta sullo stesso utente per rifare l'input
            continue;
        }

        Utente utente = new Utente(nome, 5);

        int numeroMacchine = 0;
        while (true)
        {
            Console.WriteLine("Quante macchine vuoi creare?");
            string inputNum = Console.ReadLine();
            if (int.TryParse(inputNum, out numeroMacchine) && numeroMacchine > 0)
            {
                break; // input valido, esce dal ciclo
            }
            Console.WriteLine("Inserisci un numero valido maggiore di zero.");
        }

        for (int j = 0; j < numeroMacchine; j++)
        {
            Console.WriteLine($"Inserisci tipo di motore iniziale per la macchina {j + 1}:");
            string motore = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(motore))
            {
                Console.WriteLine("Il motore non può essere vuoto. Riprova.");
                j--; // rifai la macchina corrente
                continue;
            }

            Macchina macchina = new Macchina(motore);

            // Resetta il credito per ogni nuova macchina
            utente.Credito = 5;

            while (utente.HaCredito())
            {
                Console.WriteLine("Scegli una modifica (1: Velocità +10, 2: Cambia Motore, 3: Sospensioni +1, 0: Esci):");
                string scelta = Console.ReadLine();

                if (scelta == "0")
                    break;

                switch (scelta)
                {
                    case "1":
                        macchina.AumentaVelocita();
                        utente.UsaCredito();
                        break;
                    case "2":
                        Console.WriteLine("Inserisci nuovo tipo di motore:");
                        string nuovoMotore = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(nuovoMotore))
                        {
                            Console.WriteLine("Motore non valido.");
                            continue;
                        }
                        macchina.CambiaMotore(nuovoMotore);
                        utente.UsaCredito();
                        break;
                    case "3":
                        macchina.AumentaSospensioni();
                        utente.UsaCredito();
                        break;
                    default:
                        Console.WriteLine("Scelta non valida.");
                        break;
                }
            }

            macchina.StampaInfo(utente.Nome);
        }
    }
}
}

