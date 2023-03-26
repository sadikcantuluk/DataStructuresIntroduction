var sesliHarfler = new HashSet<char>()
{
    'e','ı','i','o','ö','u','ü','b'
};

sesliHarfler.Add('a');

sesliHarfler.Remove('b');

KoleksiyonYazdir(sesliHarfler);

var alfabe = new List<char>();

for (int i = 97; i < 123; i++)
{
    alfabe.Add((char)i);
}

KoleksiyonYazdir(alfabe);

sesliHarfler.ExceptWith(alfabe);

//Console.WriteLine($"Türkçede kullanılan sesli harfler");
Console.WriteLine();
KoleksiyonYazdir(sesliHarfler);

sesliHarfler.UnionWith(alfabe);

KoleksiyonYazdir(sesliHarfler);
static void KoleksiyonYazdir(IEnumerable<char> koleksiyon)
{
    int i= 0;
    Console.WriteLine();
    foreach (char c in koleksiyon)
    {
        Console.Write($"{c,5}");
        i++;
    }
    Console.WriteLine();

    Console.WriteLine($"Eleman sayısı : {i}");
}


Console.ReadKey();