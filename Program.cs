using System;

namespace Console_Programlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adınızı Giriniz: ");
            string name = Console.ReadLine();
            Console.Write("Soy Adınızı Giriniz: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Hoş Geldiniz "+ name +" "+ surname+"!");
        }
    }
}
