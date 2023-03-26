
Console.ReadKey();

static void Ornek_1()
{
    var isimListesi = new SortedSet<string>()
{
    "SADIK","AYŞEGÜL","EDANUR","MEHTAP","ÇINAR","ARAS"
};

    //Start();

    GetList();
    isimListesi.RemoveWhere(x => x.StartsWith("Ç")); //Koşullu silme işlemi.
    GetList();


    void Start()
    {
        Console.WriteLine(new string('*', 10));
        Console.WriteLine("Listeye eleman eklemek için 'Y' tuşuna basın");
        Console.WriteLine("Listeden eleman silmek için 'R' tuşuna basın");
        Console.WriteLine("Listeyi görüntülemek için 'G' tuşuna basın");
        Console.WriteLine("İşlemi bitirmek için 'N' tuşuna basın");
        Console.WriteLine(new string('*', 10));
        var istek = Console.ReadLine();
        if (istek.ToLower() == "y")
        {
            Ekle();
        }
        else if (istek.ToLower() == "r")
        {
            Sil();
        }
        else if (istek.ToLower() == "g")
        {
            GetList();
        }
        else if (istek.ToLower() == "n")
        {
            Console.WriteLine("İşlem tamamlandı.");
        }

    }


    void Ekle()
    {
        Console.Write("Bir isim girin : ");
        var isim = Console.ReadLine();
        isimListesi.Add(isim);
        Console.WriteLine($"{isim} başarılı bir şekilde listeye eklendi.");
        Start();
    }
    void Sil()
    {
        Console.Write("Silmek istediğiniz ismi girin : ");
        var isim = Console.ReadLine();
        isimListesi.Remove(isim);
        Console.WriteLine($"{isim} başarılı bir şekilde listeden silindi..");
        Start();
    }

    void GetList()
    {
        Console.WriteLine("\nİSİM LİSTESİ");
        foreach (var item in isimListesi)
        {
            Console.WriteLine(item);
        }
        //Start();
    }
}

static void ornek_2()
{
    var sayilar = new List<int>();
    var r = new Random();

    Console.WriteLine();
    for (int i = 0; i < 100; i++)
    {
        sayilar.Add(r.Next(5, 35));
        Console.Write($"{sayilar[i],-3}");
    }
    Console.WriteLine();

    Console.WriteLine();
    //Benzersiz sayıları bulma.
    var benzersizSayilar = new SortedSet<int>(sayilar);

    Console.WriteLine("Benzersiz sayılar listesi");
    foreach (var item in benzersizSayilar)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
    Console.WriteLine($"Benzersiz sayıların sayısı : {benzersizSayilar.Count}");
}

static void Kumeler()
{
    var A = new SortedSet<int>() { 1, 2, 3 };
    //var A = new SortedSet<int>(RastgeleSayiUret(10));
    var B = new SortedSet<int>() { 1, 2, 3, 4, 5, 6 };
    //var B = new SortedSet<int>(RastgeleSayiUret(1000));

    #region Yazdırma
    Console.WriteLine();
    Console.WriteLine("A kümesi");
    foreach (var item in A)
    {
        Console.Write($"{item,5}");
    }

    Console.WriteLine();
    Console.WriteLine("B kümesi");
    foreach (var item in B)
    {
        Console.Write($"{item,5}");
    }
    Console.WriteLine();
    #endregion

    #region Birleşim
    ////Birleştirme
    //A.UnionWith(B); //Değişim A üzerinde ve kalıcı olur.(Referans tipli old. için.)

    //Console.WriteLine();
    //Console.WriteLine("A birleşim B");
    //foreach (var item in A)
    //{
    //    Console.Write($"{item,5}");
    //}
    //Console.WriteLine();
    #endregion

    #region Kesişim
    //A.IntersectWith(B); 
    //Console.WriteLine();
    //Console.WriteLine("A kesişim B");
    //foreach (var item in A)
    //{
    //    Console.Write($"{item,5}");
    //}
    //Console.WriteLine();
    #endregion

    #region Sadece A
    //A.ExceptWith(B);
    //Console.WriteLine();
    //Console.WriteLine("Sadece A kümesinde olanlar.");
    //foreach (var item in A)
    //{
    //    Console.Write($"{item,5}");
    //}
    //Console.WriteLine();
    #endregion

    #region (A-B)U(B-A)
    //A.SymmetricExceptWith(B);
    //Console.WriteLine();
    //Console.WriteLine("(A-B)U(B-A) kümesinde olanlar.");
    //foreach (var item in A)
    //{
    //    Console.Write($"{item,5}");
    //}
    //Console.WriteLine();
    #endregion

    if (A.IsSubsetOf(B)) //A B'nin alt kümesi mi?
    {
        Console.WriteLine("A B'nin alt kümesi");
    }
    else
    {
        Console.WriteLine("Değil");
    }

    List<int> RastgeleSayiUret(int x)
    {
        var list = new List<int>();
        var r = new Random();
        for (int i = 0; i < x; i++)
        {
            list.Add(r.Next(0, 1000));
        }
        return list;
    }
}