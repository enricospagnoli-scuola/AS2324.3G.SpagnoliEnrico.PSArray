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
        double min = 0, max = 0;
        int posMin = 0, posMax = 0;
        StampaVotiPesi(voti, pesi, nVoti);
        StampaVotiDispariMaggiori4(ref voti, ref pesi, nVoti);
        double ris = MediaPonderata(voti, pesi, ref max, ref posMax, ref min, ref posMin);
        Console.WriteLine($"Media ponderata: {ris} Min: {min} Max: {max}");
        Console.Write("Inserire il voto da cercare: ");
        int voto = Convert.ToInt32(Console.ReadLine());
        ElencoVotiNellIntorno(voti, pesi, nVoti, voto);
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
    static void StampaVotiDispariMaggiori4(ref double[] voti, ref int[] pesi, int nVoti)
    {
        Console.WriteLine("Voti in posizione dispari e maggiori di 4:");
        for (int i = 0; i < pesi.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (voti[i] > 4)
                {
                    Console.WriteLine($"{voti[i]}");
                }
            }
        }
    }
    static double MediaPonderata(double[] voti, int[] pesi, ref double max, ref int posMax, ref double min, ref int posMin)
    {
        double sommaVotiPesati = 0;
        double sommaPesi = 0;
        max = voti[0];
        min = voti[0];
        for (int i = 0; i < pesi.Length; i++)
        {
            sommaVotiPesati += voti[i] * pesi[i];
            sommaPesi += pesi[i];
            if (voti[i] > max)
            {
                max = voti[i];
                posMax = i;
            }
            if (voti[i] < min)
            {
                min = voti[i];
                posMin = i;
            }
        }
        double ris = sommaVotiPesati / sommaPesi;
        return ris;
    }
    static void ElencoVotiNellIntorno(double[] voti, int[] pesi, int nVoti, int voto)
    {
        Console.WriteLine("Voti nell'intorno:");
        for (int i = 0; i < pesi.Length; i++)
        {
            if ((voti[i] >= (voto - 0.5) && voti[i] <= voto) || (voti[i] <= (voto + 0.5) && voti[i] >= voto))
            {
                Console.WriteLine($"{voti[i]}");
            }
        }
    }
}
