namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java Kursu";

            string[] kurslar = new string[] {kurs1,kurs2,kurs3 ,"Python Kursu"};



            for( int i = 0; i<kurslar.Length ; i++ )
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("\n");

            foreach (string each in kurslar)
            {
                Console.WriteLine("for each "+each);
            }
            
            Console .WriteLine("sayfa sonu - footer");



        }
    }
}