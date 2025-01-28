

class Program
{ 
    static void Main()
    {
        // Rastgele 10 sayı oluşturma
        Random random = new Random();
        List<int> sayilar = new List<int>();

        for (int i = 0; i < 10; i++)
        {
            sayilar.Add(random.Next(-50, 51)); // -50 ile 50 arasında rastgele sayılar
        }

        // Listeyi yazdırma
        Console.WriteLine("Oluşturulan Sayılar:");
        foreach (var sayi in sayilar)
        {
            Console.Write(sayi + " ");
        }
        Console.WriteLine("\n");

        // Çift olan sayılar
        var ciftSayilar = sayilar.Where(sayi => sayi % 2 == 0).ToList();
        Console.WriteLine("Çift Olan Sayılar:");
        foreach (var sayi in ciftSayilar)
        {
            Console.Write(sayi + " ");
        }
        Console.WriteLine("\n");

        // Tek olan sayılar
        var tekSayilar = sayilar.Where(sayi => sayi % 2 != 0).ToList();
        Console.WriteLine("Tek Olan Sayılar:");
        foreach (var sayi in tekSayilar)
        {
            Console.Write(sayi + " ");
        }
        Console.WriteLine("\n");

        // Negatif sayılar
        var negatifSayilar = sayilar.Where(sayi => sayi < 0).ToList();
        Console.WriteLine("Negatif Sayılar:");
        foreach (var sayi in negatifSayilar)
        {
            Console.Write(sayi + " ");
        }
        Console.WriteLine("\n");

        // Pozitif sayılar
        var pozitifSayilar = sayilar.Where(sayi => sayi > 0).ToList();
        Console.WriteLine("Pozitif Sayılar:");
        foreach (var sayi in pozitifSayilar)
        {
            Console.Write(sayi + " ");
        }
        Console.WriteLine("\n");

        // 15'ten büyük ve 22'den küçük sayılar
        var aradaSayilar = sayilar.Where(sayi => sayi > 15 && sayi < 22).ToList();
        Console.WriteLine("15'ten Büyük ve 22'den Küçük Sayılar:");
        foreach (var sayi in aradaSayilar)
        {
            Console.Write(sayi + " ");
        }
        Console.WriteLine("\n");

        // Listedeki her bir sayının karesi
        var kareler = sayilar.Select(sayi => sayi * sayi).ToList();
        Console.WriteLine("Her Bir Sayının Karesi:");
        foreach (var kare in kareler)
        {
            Console.Write(kare + " ");
        }
        Console.WriteLine();
    }
}
