Console.Write("Kaç sayı eklemek istiyor sunuz? : ");
int elemanSayisi = Convert.ToInt32(Console.ReadLine());

var liste = new SortedSet<int>();

while (elemanSayisi > 0)
{
    Ekle();
    elemanSayisi--;
}

void Ekle()
{
    Console.Write("Eklemek istediğiniz sayıyı girin . ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    liste.Add(sayi);
}

foreach (var item in liste)
{
    Console.Write($"{item} ");
}

Console.WriteLine();

Console.WriteLine($"En büyük eleman : {liste.Max}");

Console.ReadKey();