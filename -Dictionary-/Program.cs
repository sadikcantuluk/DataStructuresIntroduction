using _Dictionary_;

var personelListesi = new Dictionary<int, Personel>()
{
    {123,new Personel("SADIK","TULUK",5000) },
    {236,new Personel("MEHTAP","TULUK",12000) },
    {789,new Personel("AYŞEGÜL","TULUK",7000) },
    {1012,new Personel("EDANUR","TULUK",9000) }
};

personelListesi.Add(567,new Personel("ÇINAR","BEYAZGÜL",20000));
personelListesi.Add(874,new Personel("ARAS","BEYAZGÜL",19000));

personelListesi.Remove(123);

foreach (var item in personelListesi)
{
    Console.WriteLine(item);
}


Console.ReadKey();

static void Ornek_1()
{
    var telefonKodlari = new Dictionary<int, string>()
{
    {212,"İSTANBUL"},
    {312,"ANKARA"},
    {356,"TOKAT"},
    {322,"ADANA"}
};


    telefonKodlari.Add(362, "SAMSUN");
    telefonKodlari.Add(282, "TEKİRDAĞ");
    telefonKodlari.Add(474, "KARS");

    if (!telefonKodlari.ContainsKey(326))
    {
        Console.WriteLine("\aHatay telefon kodu bulunamadı!");
        telefonKodlari.Add(326, "HATAY");
        Console.WriteLine("HATAY telefon kodu eklendi.");
    }

    Console.WriteLine(new string('-', 10));

    if (!telefonKodlari.ContainsValue("KAYSERİ"))
    {
        Console.WriteLine("\aKAYSERİ telefon kodu bulunamadı!");
        telefonKodlari.Add(352, "KAYSERİ");
        Console.WriteLine("KAYSERİ telefon kodu eklendi.");
    }
    Console.WriteLine();

    telefonKodlari.Remove(474);


    foreach (var item in telefonKodlari)
    {
        Console.WriteLine(item);
    }
}