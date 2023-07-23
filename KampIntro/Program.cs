namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type safety 
            string kategoriEtiketi = "Kategori";

            int ogrenciSayisi = 32000;

            double faizOrani = 1.45;

            bool sistemeGirisYapmisMi= true;

            

            if (sistemeGirisYapmisMi)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }else
            {
                Console.WriteLine("Giriş yap butonu");

            }


            Console.WriteLine(kategoriEtiketi);
            

            
        }

    }
}