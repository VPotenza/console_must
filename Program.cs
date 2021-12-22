using System;

namespace console_must
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("İSMİNİZ NEDİR?");
            string ad = Console.ReadLine();
            Console.WriteLine("SOYİSMİNİZ NEDİR?");
            string soyad = Console.ReadLine();
            Console.WriteLine("BABA ADI NEDİR?");
            string baba = Console.ReadLine();
            Console.WriteLine("Selamlar " + baba + " evladı " + ad + " "+ soyad );
        }
    }
}
