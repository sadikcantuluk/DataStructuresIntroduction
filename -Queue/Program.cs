var liste = new List<char>()
{
    'A','E','İ','I','O','Ö','U','Ü'
};

var kuyruk = new Queue<char>();

Console.Write("Sesli harfler kuyruğa eklensin mi ? :");
var x = Console.ReadLine();

if (x.ToLower() == "e")
{
    foreach (var item in liste)
    {
        kuyruk.Enqueue(item);
    }
}

foreach (var item in kuyruk)
{
    Console.WriteLine(item);
}

Console.ReadKey();

static void Ornek_1()
{
    var kuyruk = new Queue<char>();

    kuyruk.Enqueue('a');
    kuyruk.Enqueue('b');
    kuyruk.Enqueue('c');

    var dizi = kuyruk.ToArray();
    foreach (var d in dizi)
    {
        Console.WriteLine(d);
    }


    Console.WriteLine($"Kuyruk eleman sayısı : {kuyruk.Count}");
    Console.WriteLine($"Kuyruğun baş elemanı : {kuyruk.Peek()}");

    Console.WriteLine($"{kuyruk.Dequeue()} kuyruktan atıldı");
    Console.WriteLine($"Kuyruk eleman sayısı : {kuyruk.Count}");
    Console.WriteLine($"Kuyruğun baş elemanı : {kuyruk.Peek()}");

    Console.WriteLine($"{kuyruk.Dequeue()} kuyruktan atıldı");
    Console.WriteLine($"Kuyruk eleman sayısı : {kuyruk.Count}");
    Console.WriteLine($"Kuyruğun baş elemanı : {kuyruk.Peek()}");
}