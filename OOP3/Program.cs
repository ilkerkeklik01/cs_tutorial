namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();


            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(),
                new SmsLoggerService(),new DataBaseLoggerService());
            
            //basvuruManager.BasvuruYap(tasitKrediManager);
            //basvuruManager.BasvuruYap(ihtiyacKrediManager);

            List<IKrediManager> list = new List<IKrediManager>() { tasitKrediManager,
            ihtiyacKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(list);
             
        
        }
    }
}