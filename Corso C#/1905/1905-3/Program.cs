using System;

public class Persona
{
    public string Nome;
    public int Eta;

    public Persona(string nome, int eta)
    {
        Nome = nome;
        Eta = eta;
    }

    public void Presentati()
    {
        Console.WriteLine($"Ciao sono {Nome} e ho {Eta} anni");
    }

    public class Programma
    {
        public static void Main()
        {
            Persona p = new Persona("Anna", 30);

            p.Presentati(); 

        }
    }
}