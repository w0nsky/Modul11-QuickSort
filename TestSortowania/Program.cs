    using Sortowanie;


class Program
{
    static void Main(string[] args)
    {
        int[] liczby = new int[10];
        Random r = new Random();
        Console.WriteLine($"Tablica przed sortowaniem:");
        for (int i = 0; i < liczby.Length; i++)
        {
            liczby[i] = r.Next(0, 1001);
            Console.Write(liczby[i]);
        }
        QuickSort.sortuj(liczby);

        Console.WriteLine("Tablica po sortowaniu");
        foreach (int i in liczby)
        {
            Console.WriteLine(i);
        }
        Console.ReadKey();



    }
}