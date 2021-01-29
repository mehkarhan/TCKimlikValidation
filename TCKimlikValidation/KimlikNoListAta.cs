using System;
using System.Collections.Generic;
using System.Text;

namespace TCKimlikValidation
{
    class KimlikNoListAta
    {
        public List<long> ListAta(long tc,string t)
        {
            List<long> basamaklar = new List<long>();
            for (int i = 1; i <= t.Length; i++)
            {
                var sayi1 = tc % 10;
                basamaklar.Add(sayi1);
                tc -= sayi1;
                tc /= 10;
            }
            basamaklar.Reverse();// basamak değerlerini bulup aynı şekilde sıraladık.
            return basamaklar;

        }
        
        
    }
}
