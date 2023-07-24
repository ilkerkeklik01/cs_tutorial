namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyList<string> isimler = new MyList<string>();

            isimler.Add("s2");
            isimler.Add("s32");
            isimler.Add("s315");
            
            foreach (var item in isimler.items) { 
            Console.WriteLine(item);
            }
        }
    }
}