Console.Write("Bir sayı girin :");
int sayi = Convert.ToInt32(Console.ReadLine());

var yigin = new Stack<int>();

while (sayi > 1)
{
    int x = sayi % 10;
    yigin.Push(x);
    sayi /= 10;
}

for (int i = yigin.Count - 1; i >= 0; i--)
{
    Console.WriteLine($"{yigin.Peek()} * {Math.Pow(10, i)} = {yigin.Peek() * Math.Pow(10, i)}");
    yigin.Pop();
}


Console.ReadKey();

static void Ornek_1()
{
    var karakterYiğini = new Stack<char>();

    karakterYiğini.Push('A');
    Console.WriteLine(karakterYiğini.Peek()); //Peek() yığının en üstündeki elemanı alır.
    karakterYiğini.Push('B');
    Console.WriteLine(karakterYiğini.Peek());
    karakterYiğini.Push('C');
    Console.WriteLine(karakterYiğini.Peek());

    Console.WriteLine(new String('-', 5));

    Console.WriteLine(karakterYiğini.Pop()); //Pop() yığının en üstündeki elemanı siler ve o elemanı geri döner.
    Console.WriteLine(karakterYiğini.Pop());
    Console.WriteLine(karakterYiğini.Pop());
}

static void Ornek_2()
{
    var karakterYiğini = new Stack<char>();

    for (int i = 65; i < 91; i++)
    {
        karakterYiğini.Push((char)i);
        Console.WriteLine($"{karakterYiğini.Peek()} yığına eklendi.");
    }

    Console.WriteLine(new String('-', 5));

    for (int i = 65; i < 91; i++)
    {
        Console.WriteLine($"{karakterYiğini.Pop()} yığından atıldı.");
    }

    //Yukarda süslü parantez içindeki ifade hem çalışır hem ekrana yazdırılır.

    karakterYiğini.Push('İ');

    foreach (var item in karakterYiğini)
    {
        Console.WriteLine(item);
    }
}