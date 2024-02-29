using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enrico Spagnoli, 3G, Prova singola array");
        Console.Write("Inserire la dimensione del vettore: ");
        int dim = Convert.ToInt32(Console.ReadLine());
        double[] voti = new double[dim];
        int[] pesi = new int[dim];
        int nVoti = 0;
        StampaVotiPesi(voti, pesi, nVoti);
    }
    static void StampaVotiPesi(double[] voti, int[] pesi, int nVoti)
    {
        for (int i = 0; i < pesi.Length; i++)
        {
            Console.WriteLine($"Voto: {voti[i]} Peso: {pesi[i]}");
        }
    }
}
