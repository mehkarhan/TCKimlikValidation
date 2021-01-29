using System;
using System.Collections.Generic;
using System.Text;

namespace TCKimlikValidation
{
    class TCDogrulamaManager
    {
        public void KimlikValid(long tc, string t)
        {
            KimlikNoListAta kimlikNoListAta = new KimlikNoListAta();
            ValidationKural1 kural1 = new ValidationKural1();
            ValidationKural2 kural2 = new ValidationKural2();
            List<long> basamaklar = new List<long>();

            if (t.Length == 11)
            {       // TC No daki rakamları list atama
                basamaklar = kimlikNoListAta.ListAta(tc, t);
                if (basamaklar[0] != 0)
                {   
                    if (kural1.Kural1(basamaklar))
                    {
                        if (kural2.Kural2(basamaklar))
                        {
                            Console.WriteLine("T.C Kimlik No doğrulanmıştır.");
                        }
                        else
                        {
                            Console.WriteLine("2-Hatalı TC Kimlik No");
                        }
                    }
                    else
                    {
                        Console.WriteLine("1-Hatalı TC Kimlik No");
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı TC Kimlik No");
                }
            }
            else
            {
                Console.WriteLine("\nGirilen rakamlar 11 haneli olmalıdır....");
            }
        }
    }
}
