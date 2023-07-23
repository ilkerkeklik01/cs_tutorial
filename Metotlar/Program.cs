namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun urun3 = new Urun();
            urun3.Adi = "Elma";
            urun3.Fiyati = 15;
            urun3.Aciklama = "Amasya Elması";

            Urun[] urunler = new Urun[] {urun1,urun2,urun3};
                
            foreach (Urun each in urunler)
            {
                Console.WriteLine(each.Adi+" "+each.Fiyati+" "+each.Aciklama);
                Console.WriteLine("-----------------------------------");

            }

            Console.WriteLine("\n-------------Metotlar--------------\n");

            SepetManager sepetManager1 = new SepetManager();
            sepetManager1.Ekle(urun1);
            sepetManager1.Ekle(urun2);
            sepetManager1.Ekle(urun3);


        }//main method end
    
    }//Program class end
}
// Do not repeat yourself - DRY - Clean Code - Best Practice

