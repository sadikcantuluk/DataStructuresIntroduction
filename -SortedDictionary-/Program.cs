using System.Collections;

var kitapIndex = new SortedDictionary<string, List<int>>()
{
    {"FTP",new List<int>{3, 5, 7} },
    {"HTML",new List<int>{8,10,12} },
    {"ASP.NET",new List<int>{50,60} },
    {"CSS",new List<int>{70,80,90} },
};

kitapIndex.Add("UQuery", new List<int> { 3, 5, 15 });
kitapIndex.Add("SQL", new List<int> { 70, 80 });


foreach (var kavram in kitapIndex)
{
    Console.Write($"{kavram.Key} => ");
    foreach (var sayfa in kavram.Value)
    {
        Console.Write($"{sayfa} ");
    }
    Console.WriteLine();
}


Console.ReadKey();