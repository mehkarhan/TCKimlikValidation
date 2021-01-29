using System;
using System.Collections.Generic;
using System.Text;

namespace TCKimlikValidation
{
    class ValidationKural1
    {
        public bool Kural1(List<long> list)
        {

            long toplaTek = 0;
            long toplaCift = 0;
            //Doğrulama Kuralı-1 :1. 3. 5. 7. ve 9. hanelerin toplamının 7 katından, 2. 4. 6. ve 8. hanelerin toplamı çıkartıldığında, 
            //elde edilen sonucun 10’a bölümünden kalan, yani Mod 10’u bize 10. haneyi verir
            for (int i = 0; i <= 9; i += 2)
            {
                toplaTek += list[i];
                //Console.WriteLine("i={0} - {1}", i+1, toplaTek); // sağlamasını yaptık
            }
            for (int i = 1; i < 9; i += 2)
            {
                toplaCift += list[i];
                //Console.WriteLine("i={0} - {1}",i+1,toplaCift);   
            }
            toplaTek *= 7;
            long sonuc = (toplaTek - toplaCift) % 10;
            Console.WriteLine("\n1.Kural için 10.hane rakamı sonucu:" + sonuc);
            if (sonuc==list[9])
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
