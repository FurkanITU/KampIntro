using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "python";
            string kurs2 = "Java";
            string kurs3 = "Angular";

            string[] kurslar = new string[] { "python","Java" ,"Angular" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu");
        }
    }
}
