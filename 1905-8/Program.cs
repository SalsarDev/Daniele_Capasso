using System;

class Program
{
    static void Main()
    {
        int[] voti = new int[5];
        int somma = 0;

        Console.WriteLine("Inserisci i voti di 5 studenti:");

        for (int i = 0; i < voti.Length; i++)
        {
            Console.Write($"Voto {i + 1}: ");
            voti[i] = int.Parse(Console.ReadLine());
            somma += voti[i];
        }

        int votoMassimo = voti[0];
        int votoMinimo = voti[0];

        for (int i = 1; i < voti.Length; i++)
        {
            if (voti[i] > votoMassimo)
                votoMassimo = voti[i];
            if (voti[i] < votoMinimo)
                votoMinimo = voti[i];
        }

        double media = (double)somma / voti.Length;

        Console.WriteLine($"Media dei voti: {media:F2}");
        Console.WriteLine($"Voto più alto: {votoMassimo}");
        Console.WriteLine($"Voto più basso: {votoMinimo}");
    }
}
