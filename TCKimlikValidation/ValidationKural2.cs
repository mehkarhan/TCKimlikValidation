using System;
using System.Collections.Generic;
using System.Text;

namespace TCKimlikValidation
{
    class ValidationKural2
    {
        public bool Kural2(List<long> list)
        {   //Doğrulama kuralı-2: 1. 2. 3. 4. 5. 6. 7. 8. 9.ve 10.hanelerin toplamından elde edilen sonucun 10’a bölümünden kalan, 
            //yani Mod10’u bize 11.haneyi verir.
            long toplaMetot2 = 0, metot2Sonuc;
            for (int i = 0; i < 10; i++)
            {
                toplaMetot2 += list[i];
            }
            metot2Sonuc = toplaMetot2 % 10;
            Console.WriteLine("\n2.Kural için 11.hane rakamı sonucu:" + metot2Sonuc);
            if (metot2Sonuc == list[10])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
