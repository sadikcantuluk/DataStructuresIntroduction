var sehirler = new LinkedList<String>();

sehirler.AddFirst("Samsun");
sehirler.AddFirst("Sinop");

sehirler.AddLast("Trabzon");
sehirler.AddLast("Artvin");

sehirler.AddAfter(sehirler.Find("Samsun"), "Giresun");

sehirler.AddBefore(sehirler.First.Next.Next, "Ordu"); //(Adres,Değer)

sehirler.AddAfter(sehirler.Last.Previous, "Rize");

var x = sehirler.First.Value;

Console.WriteLine(x);

Console.WriteLine(new String('*', 5));

var y = sehirler.First;

Console.WriteLine("GİDİŞ");

while (y != null)
{
    Console.WriteLine(y.Value);
    y = y.Next;
}

Console.WriteLine(new String('*', 5));

var d = sehirler.Last;

Console.WriteLine("DÖNÜŞ");

while (d != null)
{
    Console.WriteLine(d.Value);
    d = d.Previous;
}


Console.ReadKey();


