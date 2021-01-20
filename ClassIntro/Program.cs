using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "furkan";
            int age = 20;

            Kurs kurs1 = new Kurs();
            kurs1.KursName = "C#";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.WatchRate = 61;

            Kurs kurs2 = new Kurs();
            kurs2.KursName = "java";
            kurs2.Egitmen = "berkay";
            kurs2.WatchRate = 76;

            Kurs kurs3 = new Kurs();
            kurs3.KursName = "python";
            kurs3.Egitmen = "makevelli";
            kurs3.WatchRate = 90;

            //Console.WriteLine(kurs1.KursName + ": " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursName + ": " + kurs.Egitmen);
            }

            Console.WriteLine("Hello World!");
        }
    }
    class Kurs
    {
        public string KursName { get; set; }

        public string Egitmen { get; set; }

        public int WatchRate { get; set; }

    }
}
