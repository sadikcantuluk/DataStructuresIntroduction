using _List_;

namespace Veri_Yapilari_Giriş
{
    class Program
    {
        static void Main(string[] args)
        {
            var liste = new List<Employee>()
            {
                new Employee(60,"SADIK","TULUK"),
                new Employee(45,"AYŞEGÜL","TULUK"),
                new Employee(67,"EDA","TULUK"),
                new Employee(13,"MEHTAP","TULUK"),
            };

            liste.Add(new Employee(54, "Çınar", "Beyazgül"));

            liste.Sort();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}