using System;
using System.Collections.Generic;
using System.Text;

namespace TCKimlikValidation
{
    class TCDogrulamaManager
    {
        public void KimlikValid(long tc, string t)
        {
            List<long> basamaklar = new List<long>();
            if (t.Length == 11)
            {
                //long tc = long.Parse(t);
                //ilk rakamı 0 girse bile tür dönüşümü gerçekleştiği için ilk rakamı kabul etmeyecektir. Eksik rakam girildi diyecek
                for (int i = 1; i <= t.Length; i++)
                {
                    var sayi1 = tc % 10;
                    basamaklar.Add(sayi1);
                    tc -= sayi1;
                    tc /= 10;
                }
                basamaklar.Reverse();// basamak değerlerini bulup aynı şekilde sıraladık.
                if (basamaklar[0] != 0) // buradan sonra sırayla Kimlik Doğrulamada geçerli kuralları uygulayacağız.
                {
                    long toplaTek = 0;
                    long toplaCift = 0;
                    //Doğrulama Kuralı-1 :1. 3. 5. 7. ve 9. hanelerin toplamının 7 katından, 2. 4. 6. ve 8. hanelerin toplamı çıkartıldığında, 
                    //elde edilen sonucun 10’a bölümünden kalan, yani Mod 10’u bize 10. haneyi verir
                    for (int i = 0; i <= 9; i += 2)
                    {
                        toplaTek += basamaklar[i];
                        //Console.WriteLine("i={0} - {1}", i+1, toplaTek); // sağlamasını yaptık
                    }
                    for (int i = 1; i < 9; i += 2)
                    {
                        toplaCift += basamaklar[i];
                        //Console.WriteLine("i={0} - {1}",i+1,toplaCift);   
                    }
                    toplaTek *= 7;
                    long sonuc = (toplaTek - toplaCift) % 10;
                    Console.WriteLine("\n1.Kural için 10.hane rakamı sonucu:"+ sonuc);
                    if (sonuc == basamaklar[9])
                    {
                        //Doğrulama kuralı-2: 1. 2. 3. 4. 5. 6. 7. 8. 9.ve 10.hanelerin toplamından elde edilen sonucun 10’a bölümünden kalan, 
                        //yani Mod10’u bize 11.haneyi verir.
                        long toplaMetot2 = 0, metot2Sonuc;
                        for (int i = 0; i < 10; i++)
                        {
                            toplaMetot2 += basamaklar[i];
                        }
                        metot2Sonuc = toplaMetot2 % 10;
                        Console.WriteLine("\n2.Kural için 11.hane rakamı sonucu:"+metot2Sonuc);
                        if (metot2Sonuc == basamaklar[10])
                        {
                            Console.WriteLine("\nTC No girişi Doğru yapıldı....");
                        }
                        else
                        {
                            Console.WriteLine("\nHatalı TC NO");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nHatalı TC NO");
                    }
                }
                else
                {
                    Console.WriteLine("\nGirilen sayının başlangıcı 0 olamaz.");
                }
            }
            else
            {
                Console.WriteLine("\nEksik Rakam yada 0 ile baslayan TC girdiniz....");
            }
        }
    }
}
