using System;

namespace ConsoleApp1
{
    class Firma
    {
        private string name;
        public string Name { get; set; }
        private string adress;
        public string Adress { get; set; }
        private int year_osnova;
        public int Year_osnova { get; set; }
        public Firma()
        {
            Name = "";
            Adress = "";
            Year_osnova = 0;
        }
        public void Fill()
        {
            Console.WriteLine("Введите данные");
            Name = Console.ReadLine();
            Adress = Console.ReadLine();
            Year_osnova = Convert.ToInt32(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine($"Название фирмы: {Name}, Адрес фирмы: {Adress}, Год основания фирмы: { Year_osnova}");
        }
        class program
        {
            static void Main(string[] args)
            {
                Firma Firma = new Firma();
                Firma.Fill();
                Firma.Print();
                Console.ReadKey();
            }
        }
    }
}






