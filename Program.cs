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
        int nVoti = dim;
        StampaVotiPesi(voti, pesi, nVoti);
    }
    static void StampaVotiPesi(double[] voti, int[] pesi, int nVoti)
    {
        CaricaVettori(ref voti, ref pesi, nVoti);
        for (int i = 0; i < pesi.Length; i++)
        {
            Console.WriteLine($"Voto: {voti[i]} Peso: {pesi[i]}");
        }
    }
    static void CaricaVettori(ref double[] voti, ref int[] pesi, int nVoti)
    {
        Random random = new Random();
        for (int i = 0; i < nVoti; i++)
        {
            voti[i] = random.Next(1, 11);
            pesi[i] = random.Next(0, 101);
        }
    }
}
