using System;
using System.Collections.Generic;

namespace TCKimlikValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            TCDogrulamaManager tcDogrulamaManager = new TCDogrulamaManager();
            

            Console.Write("TC No Giriniz:");
            string t = Console.ReadLine();   //basamak sayısını saydırmak için
            long tc = long.Parse(t);        //basamak rakamları için

            tcDogrulamaManager.KimlikValid(tc, t);    
        }
    }
}
