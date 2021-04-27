using System;

namespace Yazı_tura
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rndm = new Random();
            string brah = "";
            string[] kelimeler = { "yazı", "tura" };
            for(int i =1; i<=2; i++)
            {
                brah = kelimeler[rndm.Next(0, 2)].ToString();  
            }

            Console.WriteLine(brah);
            }
           
        }
    }
