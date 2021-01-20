using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Emre");
            Console.WriteLine(isimler.Length);
            isimler.Add("engin");
            Console.WriteLine(isimler.Length);
            Console.WriteLine("Hello World!");

        }
    }
}
