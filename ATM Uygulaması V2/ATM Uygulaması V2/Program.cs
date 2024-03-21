using System;

namespace ATM_Uygulaması_V2
{
    internal class Program
    {
        static int YeniBakiyeEksiltme(int k, int l)
        {
            k -= l;
            return k;
        }
        static int YeniBakiyeArtırma(int k, int l)
        {
            k += l;
            return k;
        }

        static void Main(string[] args)
        {
            int hesap1 = 1800;
            int hesap2 = 1650;
            int hesap3 = 1500;
            int kalan, tutar, cevap,cevap2, a, b;

            Console.WriteLine("Lütfen hesap bakiyenizi giriniz");
            int bakiye = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Devam etmek için 1'e basınız.");
            cevap = Convert.ToInt32(Console.ReadLine());
            while (cevap == 1)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi tuşlayınız.");
                Console.WriteLine("Para çekmek için 2'ye basınız.\nPara yatırmak için 3'e basınız.\nHesaplar arası transfer yapmak için 4'e basınız.\nİşlemi sonlandırmak için 4'e basınız.");
                cevap = Convert.ToInt32(Console.ReadLine());

                while (cevap == 2)
                {
                    Console.WriteLine($"Hesap bakiyeniz {bakiye} TL'dir");
                    Console.WriteLine("Lütfen işlem yapmak istediğiniz hesabı seçiniz.");
                    Console.WriteLine($"1) Ana Hesap = {bakiye}TL");
                    Console.WriteLine($"2) 1 Numaralı Hesap = {hesap1}TL");
                    Console.WriteLine($"3) 2 Numaralı Hesap = {hesap2}TL");
                    Console.WriteLine($"4) 3 Numaralı Hesap = {hesap3}TL");
                    cevap = Convert.ToInt32(Console.ReadLine());

                    if(cevap==1)
                    {
                        Console.WriteLine("Bankamız sadece 10 TL ve katlarını vermektedir.\nLütfen çekmek istediğiniz tutarı giriniz.");
                        tutar = Convert.ToInt32(Console.ReadLine());
                        kalan = tutar % 10;
                        if(kalan==0)
                        {
                            YeniBakiyeEksiltme(bakiye, tutar);
                            Console.WriteLine($"Ana hesabınızın yeni bakiyesi {bakiye} TL'dir.");
                        }
                    }
                    
                }
                if (cevap == 2)
                {
                    Console.WriteLine("Lütfen yatırmak istediğiniz paraları içinde 5'lik banknot olmayacak şekilde para yatırma bölmesine yerleştiriniz");
                    tutar = Convert.ToInt32(Console.ReadLine());
                    kalan = tutar % 10;
                    if (kalan == 0)
                    {
                        a = YeniBakiyeArtırma(bakiye, tutar);
                        Console.WriteLine($"İşleminiz gerçekleşmiştir\nGüncel bakiyeniz {a} TL'dir");
                    }
                    else
                    {
                        Console.WriteLine($"{kalan}TL ödeme yapılamamaktadır\n{tutar - kalan}TL ödeme yapılmasını istiyorsanız 1'e basınız. Devam etmek istiyorsanız 0'a basınız");
                        cevap = Convert.ToInt32(Console.ReadLine());
                        if (cevap == 1)
                        {

                            a = YeniBakiyeArtırma(bakiye, tutar - kalan);
                            Console.WriteLine($"İşleminiz gerçekleşmiştir.\nGüncel bakiyeniz {a}TL dir");
                        }
                    }
                    Console.WriteLine("Başka bir işlem yapmak için 1'ye basınız.\nİşlemi iptal etmek için 0'a basınız.");
                    cevap = Convert.ToInt32(Console.ReadLine());
                    if (cevap == 0)
                    {
                        Console.WriteLine("İşleminiz sonlandırıldı.İyi günler");
                    }

                }
                while (cevap == 4)
                {
                    Console.WriteLine($"1 numaralı hesabınızın bakiyesi {hesap1} TL\n2numaralı hesabınızın bakiyesi {hesap2}\n3numaralı hesabınızın bakiyesi {hesap3}");
                    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz.");
                    Console.WriteLine("1 numaralı hesap ile ana hesap arasında işlem yapmak için 1'e basınız.");
                    Console.WriteLine("1 numaralı hesap ile 2 numaralı hesap arasında işlem yapmak için 2'ye basınızı.");
                    Console.WriteLine("1 numaralı hesap ile 3 numaralı hesap arasında işlem yapmak için 3'e basınızı.");
                    Console.WriteLine("2 numaralı hesap ile ana hesap arasında işlem yapmak için 4'e basınız.");
                    Console.WriteLine("2 numaralı hesap ile 3 numaralı hesap arasında işlem yapmak için 5'e basınız.");
                    Console.WriteLine("3 numaralı hesap ile ana hesap arasında işlem yapmak için 6'ya basınız.");
                    cevap = Convert.ToInt32(Console.ReadLine());

                    if (cevap == 1)
                    {
                        Console.WriteLine("1 numaralı hesabınızdan ana hesaba para aktarmak için 2'ye basınız\nAna hesaptan 1 numaralı hesaba para aktarmak için 3'e basınız\nİşlemi sonlandırmak için 0'a basınız");
                        cevap = Convert.ToInt32(Console.ReadLine());



                        if (cevap == 2)
                        {
                            Console.WriteLine($"1 numaralı hesabınızın bakiyesi {hesap1} TL");
                            Console.WriteLine($"Ana hesabın bakiyesi {bakiye}");
                            Console.WriteLine("Lütfen ana hesaba aktarmak istediğiniz tutarı giriniz");
                            tutar = Convert.ToInt32(Console.ReadLine());


                            if (hesap1 >= tutar)
                            {
                                a = YeniBakiyeEksiltme(hesap1, tutar);
                                b = YeniBakiyeArtırma(bakiye, tutar);
                                Console.WriteLine($"İşleminiz gerçekleştirildi.\nHesap 1'in yeni bakiyesi {a} TL\nAna hesabın yeni bekiyesi {b}TL.");
                            }
                            else
                            {
                                Console.WriteLine($"Hesabınızda yeterli bakiye yok.\nHesap bakiyeniz {hesap1}");

                            }

                        }


                        if (cevap == 3)
                        {
                            Console.WriteLine($"Ana hesabınızın bakiyesi {bakiye} TL");
                            Console.WriteLine($"1 numaralı hesabın bakiyesi {hesap1}");
                            Console.WriteLine("Lütfen 1 numaralı hesaba aktarmak istediğiniz tutarı giriniz");
                            tutar = Convert.ToInt32(Console.ReadLine());

                            if (bakiye >= tutar)
                            {
                                a = YeniBakiyeEksiltme(bakiye, tutar);
                                b = YeniBakiyeArtırma(hesap1, tutar);
                                Console.WriteLine($"İşleminiz gerçekleştirildi.\nHesap 1'in yeni bakiyesi {a} TL\nAna hesabın yeni bekiyesi {b}TL.");
                            }
                            else
                            {
                                Console.WriteLine($"Hesabınızda yeterli bakiye yok.\nHesap bakiyeniz {hesap1}");

                            }


                        }



                    }
                    if (cevap == 2)
                    {
                        Console.WriteLine("1 numaralı hesabınızdan 2 numaralı hesabınız para aktarmak için 2'ye basınız.\n2 numaralı hesabınızdan 1 numaralı hesaba para aktarmak için 3'e basınız.\nİşlemi sonlandırmak için 0'a basınız.");
                        cevap = Convert.ToInt32(Console.ReadLine());



                        if (cevap == 2)
                        {
                            Console.WriteLine($"1 numaralı hesabınızın bakiyesi {hesap1} TL");
                            Console.WriteLine($"2 numaralı hesabınızın bakiyesi {hesap2}");
                            Console.WriteLine("Lütfen 2 numaralı hesabınıza aktarmak istediğiniz tutarı giriniz");
                            tutar = Convert.ToInt32(Console.ReadLine());


                            if (hesap1 >= tutar)
                            {
                                a = YeniBakiyeEksiltme(hesap1, tutar);
                                b = YeniBakiyeArtırma(hesap2, tutar);
                                Console.WriteLine($"İşleminiz gerçekleştirildi.\n1 numaralı hesabınızın yeni bakiyesi {a} TL\n2 numaralı hesabınızın yeni bekiyesi {b}TL.");
                            }
                            else
                            {
                                Console.WriteLine($"Hesabınızda yeterli bakiye yok.\nHesap bakiyeniz {hesap1}");

                            }

                        }


                        if (cevap == 3)
                        {
                            Console.WriteLine($"2 numaralı hesabınızın bakiyesi {hesap2} TL");
                            Console.WriteLine($"1 numaralı hesabın bakiyesi {hesap1}");
                            Console.WriteLine("Lütfen 1 numaralı hesaba aktarmak istediğiniz tutarı giriniz");
                            tutar = Convert.ToInt32(Console.ReadLine());

                            if (hesap2 >= tutar)
                            {
                                a = YeniBakiyeEksiltme(hesap2, tutar);
                                b = YeniBakiyeArtırma(hesap1, tutar);
                                Console.WriteLine($"İşleminiz gerçekleştirildi.\n1 numaralı hesabınızın yeni bakiyesi {a} TL\n2 numaralı hesabınızın yeni bekiyesi {b}TL.");
                            }
                            else
                            {
                                Console.WriteLine($"Hesabınızda yeterli bakiye yok.\nHesap bakiyeniz {hesap2}");

                            }


                        }



                    }
                    if (cevap == 3)
                    {
                        Console.WriteLine("1 numaralı hesabınızdan 3 numaralı hesabınız para aktarmak için 2'ye basınız.\n3 numaralı hesabınızdan 1 numaralı hesaba para aktarmak için 3'e basınız.\nİşlemi sonlandırmak için 0'a basınız.");
                        cevap = Convert.ToInt32(Console.ReadLine());



                        if (cevap == 2)
                        {
                            Console.WriteLine($"1 numaralı hesabınızın bakiyesi {hesap1} TL");
                            Console.WriteLine($"3 numaralı hesabınızın bakiyesi {hesap3}");
                            Console.WriteLine("Lütfen 3 numaralı hesabınıza aktarmak istediğiniz tutarı giriniz");
                            tutar = Convert.ToInt32(Console.ReadLine());


                            if (hesap1 >= tutar)
                            {
                                a = YeniBakiyeEksiltme(hesap1, tutar);
                                b = YeniBakiyeArtırma(hesap3, tutar);
                                Console.WriteLine($"İşleminiz gerçekleştirildi.\n1 numaralı hesabınızın yeni bakiyesi {a} TL\n3 numaralı hesabınızın yeni bekiyesi {b}TL.");
                            }
                            else
                            {
                                Console.WriteLine($"Hesabınızda yeterli bakiye yok.\nHesap bakiyeniz {hesap1}");

                            }

                        }


                        if (cevap == 3)
                        {
                            Console.WriteLine($"3 numaralı hesabınızın bakiyesi {hesap3} TL");
                            Console.WriteLine($"1 numaralı hesabın bakiyesi {hesap1}");
                            Console.WriteLine("Lütfen 1 numaralı hesaba aktarmak istediğiniz tutarı giriniz");
                            tutar = Convert.ToInt32(Console.ReadLine());

                            if (hesap3 >= tutar)
                            {
                                a = YeniBakiyeEksiltme(hesap3, tutar);
                                b = YeniBakiyeArtırma(hesap1, tutar);
                                Console.WriteLine($"İşleminiz gerçekleştirildi.\n1 numaralı hesabınızın yeni bakiyesi {a} TL\n3 numaralı hesabınızın yeni bekiyesi {b}TL.");
                            }
                            else
                            {
                                Console.WriteLine($"Hesabınızda yeterli bakiye yok.\nHesap bakiyeniz {hesap3}");

                            }


                        }



                    }
                    if (cevap == 4)
                    {
                        Console.WriteLine("2 numaralı hesabınızdan ana hesabınıza para aktarmak için 2'ye basınız.\nAna hesabınızdan 2 numaralı hesabınıza para aktarmak için 3'e basınız.\nİşlemi sonlandırmak için 0'a basınız.");
                        cevap = Convert.ToInt32(Console.ReadLine());



                        if (cevap == 2)
                        {
                            Console.WriteLine($"2 numaralı hesabınızın bakiyesi {hesap2} TL");
                            Console.WriteLine($"Ana hesabınızın bakiyesi {bakiye}");
                            Console.WriteLine("Ana hesabınıza aktarmak istediğiniz tutarı giriniz");
                            tutar = Convert.ToInt32(Console.ReadLine());


                            if (hesap2 >= tutar)
                            {
                                a = YeniBakiyeEksiltme(hesap2, tutar);
                                b = YeniBakiyeArtırma(bakiye, tutar);
                                Console.WriteLine($"İşleminiz gerçekleştirildi.\n2 numaralı hesabınızın yeni bakiyesi {a} TL\nAna hesabınızın yeni bekiyesi {b}TL.");
                            }
                            else
                            {
                                Console.WriteLine($"Hesabınızda yeterli bakiye yok.\nHesap bakiyeniz {hesap2}");

                            }

                        }


                        if (cevap == 3)
                        {
                            Console.WriteLine($"Ana hesabınızın bakiyesi {bakiye} TL");
                            Console.WriteLine($"2 numaralı hesabın bakiyesi {hesap2}");
                            Console.WriteLine("Lütfen 2 numaralı hesaba aktarmak istediğiniz tutarı giriniz");
                            tutar = Convert.ToInt32(Console.ReadLine());

                            if (bakiye >= tutar)
                            {
                                a = YeniBakiyeEksiltme(bakiye, tutar);
                                b = YeniBakiyeArtırma(hesap2, tutar);
                                Console.WriteLine($"İşleminiz gerçekleştirildi.\nAna hesabınızın yeni bakiyesi {a} TL\n2 numaralı hesabınızın yeni bekiyesi {b}TL.");
                            }
                            else
                            {
                                Console.WriteLine($"Hesabınızda yeterli bakiye yok.\nHesap bakiyeniz {hesap1}");

                            }


                        }



                    }
                    if (cevap == 5)
                    {
                        Console.WriteLine("2 numaralı hesabınızdan 3 numaralı hesabınıza para aktarmak için 2'ye basınız.\n3 numaralı hesabınızdan 2 numaralı hesabınıza para aktarmak için 3'e basınız.\nİşlemi sonlandırmak için 0'a basınız.");
                        cevap = Convert.ToInt32(Console.ReadLine());



                        if (cevap == 2)
                        {
                            Console.WriteLine($"2 numaralı hesabınızın bakiyesi {hesap2} TL");
                            Console.WriteLine($"3 numaralı hesabınızın bakiyesi {hesap3}");
                            Console.WriteLine("3 numaralı hesabınıza aktarmak istediğiniz tutarı giriniz");
                            tutar = Convert.ToInt32(Console.ReadLine());


                            if (hesap2 >= tutar)
                            {
                                a = YeniBakiyeEksiltme(hesap2, tutar);
                                b = YeniBakiyeArtırma(hesap3, tutar);
                                Console.WriteLine($"İşleminiz gerçekleştirildi.\n2 numaralı hesabınızın yeni bakiyesi {a} TL\n3 numaralı hesabınızın yeni bekiyesi {b}TL.");
                            }
                            else
                            {
                                Console.WriteLine($"Hesabınızda yeterli bakiye yok.\nHesap bakiyeniz {hesap2}");

                            }

                        }


                        if (cevap == 3)
                        {
                            Console.WriteLine($"3 numaralı hesabınızın bakiyesi {hesap3} TL");
                            Console.WriteLine($"2 numaralı hesabın bakiyesi {hesap2}");
                            Console.WriteLine("Lütfen 2 numaralı hesaba aktarmak istediğiniz tutarı giriniz");
                            tutar = Convert.ToInt32(Console.ReadLine());

                            if (bakiye >= tutar)
                            {
                                a = YeniBakiyeEksiltme(hesap3, tutar);
                                b = YeniBakiyeArtırma(hesap2, tutar);
                                Console.WriteLine($"İşleminiz gerçekleştirildi.\n3 numaralı hesabınızın yeni bakiyesi {a} TL\n2 numaralı hesabınızın yeni bekiyesi {b}TL.");
                            }
                            else
                            {
                                Console.WriteLine($"Hesabınızda yeterli bakiye yok.\nHesap bakiyeniz {hesap1}");

                            }


                        }



                    }
                    if (cevap == 6)
                    {
                        Console.WriteLine("3 numaralı hesabınızdan ana hesabınıza para aktarmak için 2'ye basınız.\nAna hesabınızdan 3 numaralı hesabınıza para aktarmak için 3'e basınız.\nİşlemi sonlandırmak için 0'a basınız.");
                        cevap = Convert.ToInt32(Console.ReadLine());



                        if (cevap == 2)
                        {
                            Console.WriteLine($"3 numaralı hesabınızın bakiyesi {hesap3} TL");
                            Console.WriteLine($"Ana hesabınızın bakiyesi {bakiye}");
                            Console.WriteLine("Ana hesabınıza aktarmak istediğiniz tutarı giriniz");
                            tutar = Convert.ToInt32(Console.ReadLine());


                            if (hesap3 >= tutar)
                            {
                                a = YeniBakiyeEksiltme(hesap3, tutar);
                                b = YeniBakiyeArtırma(bakiye, tutar);
                                Console.WriteLine($"İşleminiz gerçekleştirildi.\n3 numaralı hesabınızın yeni bakiyesi {a} TL\nAna hesabınızın yeni bekiyesi {b}TL.");
                            }
                            else
                            {
                                Console.WriteLine($"Hesabınızda yeterli bakiye yok.\nHesap bakiyeniz {hesap2}");

                            }

                        }


                        if (cevap == 3)
                        {
                            Console.WriteLine($"Ana hesabınızın bakiyesi {bakiye} TL");
                            Console.WriteLine($"3 numaralı hesabın bakiyesi {hesap3}");
                            Console.WriteLine("Lütfen 3 numaralı hesaba aktarmak istediğiniz tutarı giriniz");
                            tutar = Convert.ToInt32(Console.ReadLine());

                            if (bakiye >= tutar)
                            {
                                a = YeniBakiyeEksiltme(bakiye, tutar);
                                b = YeniBakiyeArtırma(hesap3, tutar);
                                Console.WriteLine($"İşleminiz gerçekleştirildi.\nAna hesabınızın yeni bakiyesi {a} TL\n3 numaralı hesabınızın yeni bekiyesi {b}TL.");
                            }
                            else
                            {
                                Console.WriteLine($"Hesabınızda yeterli bakiye yok.\nHesap bakiyeniz {hesap1}");

                            }


                        }

                    }
                    Console.WriteLine("Başka transfer yapmak için 4'e basınız.\nAna menüye dönmek için 1'e basınız.\nİşlemi sonlandırmak için 0'a basınız.");
                    cevap = Convert.ToInt32(Console.ReadLine());
                    if (cevap == 0)
                    {
                        Console.WriteLine("İşleminiz sonlandırıldı.");
                    }
                }

            }




        }

    }

}
