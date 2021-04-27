using System;

namespace Name_generator
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("kaç harfli olsun");
            int kaçharf = int.Parse(Console.ReadLine());

            Random rndm = new Random();
            string sj = "";
            char[] harfler = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'ı', 'j', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z' };

            for (int i = 1; i <= kaçharf; i++)
            {
                sj += harfler[rndm.Next(0, 25)].ToString();
            }
            Console.WriteLine(sj);
            
        }
    }
}