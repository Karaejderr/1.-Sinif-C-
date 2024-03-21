using System;

namespace ATM_Sorusu_gelişmiş
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cevap3;
            int cevap2; // 0 ise işlemi iptal eder 1 ise (tutar-kalan) tl ödeme yapar.
            int cevap4; //hesaplar arası transfer seçeneğinde hangi hesaptan işlem yapılacağının belirler
            int tutar;
            int kalan;
            int yatırılan;
            int hesap1 = 1800;
            int hesap2 = 1650;
            int hesap3 = 1500;
            Console.WriteLine("Lütfen hesap bakiyenizi giriniz");
            int bakiye = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İşleme devam etmek için 2'ye basınız");
            cevap3 = Convert.ToInt32(Console.ReadLine());
            while (cevap3 == 2)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi tuşlayınız.");
                Console.WriteLine("Para çekmek için 1'e basınız.\nPara yatırmak için 2' ye basınız.\nHesaplar arası transfer yapmak için 3'e basınız.\nİşlemi sonlandırmak için 4'e basınız.");
                int cevap1 = Convert.ToInt32(Console.ReadLine());
                if (cevap1 == 1)
                {
                    Console.WriteLine($"Hesap bakiyeniz {bakiye}TL");
                    Console.WriteLine("Bankamız sadece 10 ve katları tutarları için ödeme yapabilir.\nLütfen çekmek istediğiniz tutarı giriniz.");
                    tutar = Convert.ToInt32(Console.ReadLine());
                    if (bakiye >= tutar)
                    {
                        kalan = tutar % 10;
                        if (kalan == 0)
                        {
                            bakiye -= tutar;
                            Console.WriteLine($"İşleminiz gerçekleşmiştir.\nKalan bakiyeniz {bakiye}TL'dir.Devam etmek için 0'a basınız"); //ÇALIŞIYOR
                        }
                        else
                        {
                            Console.WriteLine($"{kalan}TL ödeme yapılamamaktadır.\n{tutar - kalan}TL ödeme yapılmasını istiyorsanız 1'e basınız, devam etmek için 0'a basınız.");
                        }
                        cevap2 = Convert.ToInt32(Console.ReadLine());
                        if (cevap2 == 1)
                        {
                            tutar -= kalan;

                            bakiye -= tutar;
                            Console.WriteLine($"İşleminiz gerçekleşmiştir.\nGüncel bakiyeniz {bakiye}TL dir.\nDevam etmek için 0' basınız.");
                            cevap2 = Convert.ToInt32(Console.ReadLine());
                        }
                        if (cevap2 == 0)
                        {
                            Console.WriteLine("Başka işlem yapmak için 2'ye, işlemi iptal etmek için 0'a basınız"); //2,0 çalışıyor
                        }
                        cevap3 = Convert.ToInt32(Console.ReadLine());
                        if (cevap3 == 0)
                            Console.WriteLine("İşleminiz sonlandırıldı.İyi günler");
                    }
                    else
                    {
                        Console.WriteLine($"Hesabınızın bekiyesi yetersiz.\nŞu an size {bakiye}TL verebiliriz.\nOnaylıyorsanız 1'e davam etmek için 0'a basınız.");
                        cevap2 = Convert.ToInt32(Console.ReadLine());
                        if (cevap2 == 1)
                        {
                            Console.WriteLine("İşleminiz gerçekleşmiştir\nGüncel bakiyeniz 0 TL'dir\nDevam etmek için 0'a basınız.");
                            cevap2 = Convert.ToInt32(Console.ReadLine());
                        }
                        if (cevap2 == 0)
                        {
                            Console.WriteLine("Başka işlem yapmak için 2'ye, işlemi iptal etmek için 0'a basınız");
                            cevap3 = Convert.ToInt32(Console.ReadLine());
                        }
                        if (cevap3 == 0)
                            Console.WriteLine("İşleminiz sonlandırıldı.İyi günler");
                    }
                }
                if (cevap1 == 2)
                {
                    Console.WriteLine("Lütfen yatırmak istediğiniz paraları içinde 5'lik banknot olmayacak şekilde para yatırma bölmesine yerleştiriniz");
                    yatırılan = Convert.ToInt32(Console.ReadLine());
                    kalan = yatırılan % 10;

                    if (kalan == 0)
                    {
                        bakiye += yatırılan;
                        Console.WriteLine($"İşleminiz gerçekleşmiştir.\nGüncel bakiyeniz {bakiye}TL'dir.");

                    }
                    else
                    {
                        Console.WriteLine($"{kalan}TL ödeme yapılamamaktadır\n{yatırılan - kalan}TL ödeme yapılmasını istiyorsanız 1'e basınız. Devam etmek istiyorsanız 0'a basınız");
                        cevap3 = Convert.ToInt32(Console.ReadLine());
                        if (cevap3 == 1)
                        {
                            bakiye += (yatırılan - kalan);
                            Console.WriteLine($"İşleminiz gerçekleşmiştir.\nGüncel bakiyeniz {bakiye}TL dir");
                        }
                    }
                    Console.WriteLine("Başka bir işlem yapmak için 2'ye basınız.\nİşlemi iptal etmek için 0'a basınız.");
                    cevap3 = Convert.ToInt32(Console.ReadLine());
                    if (cevap3 == 0)
                    {
                        Console.WriteLine("İşleminiz sonlandırıldı.İyi günler");
                    }

                    if (cevap1 == 3)
                    {


                        Console.WriteLine($"1 numaralı hesabınızın bakiyesi {hesap1} TL\n2numaralı hesabınızın bakiyesi {hesap2}\n3numaralı hesabınızın bakiyesi {hesap3}");

                        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz.");
                        Console.WriteLine("1 numaralı hesap ile ana hesap arasında işlem yapmak için 1'e basınız.");
                        Console.WriteLine("1 numaralı hesap ile 2 numaralı hesap arasında işlem yapmak için 2'ye basınızı.");
                        Console.WriteLine("1 numaralı hesap ile 3 numaralı hesap arasında işlem yapmak için 3'e basınızı.");

                        Console.WriteLine("2 numaralı hesap ile ana hesap arasında işlem yapmak için 4'e basınız.");
                        Console.WriteLine("2 numaralı hesap ile 3 numaralı hesap arasında işlem yapmak için 5'e basınız.");

                        Console.WriteLine("3 numaralı hesap ile ana hesap arasında işlem yapmak için 6'ya basınız.");
                        cevap4 = Convert.ToInt32(Console.ReadLine());

                        if (cevap4 == 1)//1-ana
                        {
                            Console.WriteLine("1 numaralı hesabınızdan ana hesaba para aktarmak için 1'e basınız\nAna hesaptan 1 numaralı hesaba para aktarmak için 2'ye basınız\nİşlemi sonlandırmak için 0'a basınız");
                            cevap3 = Convert.ToInt32(Console.ReadLine());
                            if (cevap3 == 1)
                            {
                                Console.WriteLine($"1 numaralı hesabınızın bakiyesi {hesap1} TL");
                                Console.WriteLine($"Ana hesabın bakiyesi {bakiye}");
                                Console.WriteLine("Lütfen ana hesaba aktarmak istediğiniz tutarı giriniz");
                                tutar = Convert.ToInt32(Console.ReadLine());
                                if (hesap1 >= tutar)
                                {
                                    hesap1 -= tutar;
                                    bakiye += tutar;
                                    Console.WriteLine($"İşleminiz gerçekleştirildi.\nHesap 1'in yeni bakiyesi {hesap1} TL\nAna hesabın yeni bekiyesi {bakiye}TL.");
                                }

                            }
                            if (cevap3 == 2)
                            {
                                Console.WriteLine($"1 numaralı hesabınızın bakiyesi {hesap1} TL");
                                Console.WriteLine($"Ana hesabın bakiyesi {bakiye}");
                                Console.WriteLine("Lütfen 1 numaralı hesaba aktarmak istediğiniz tutarı giriniz.");
                                tutar = Convert.ToInt32(Console.ReadLine());
                                if (bakiye >= tutar)
                                {
                                    hesap1 += tutar;
                                    bakiye -= tutar;
                                    Console.WriteLine($"İşleminiz gerçekleştirildi.\nHesap 1'in yeni bakiyesi {hesap1} TL\nAna hesabın yeni bekiyesi {bakiye}TL.");
                                }
                            }
                        }
                        if (cevap4 == 2)//1-2
                        {
                            Console.WriteLine("1 numaralı hesabınızdan 2 numaralı hesabınıza para aktarmak için 1'e basınız\n2 numaralı hesabınızdan 1 numaralı hesaba para aktarmak için 2'ye basınız\nİşlemi sonlandırmak için 0'a basınız");
                            cevap3 = Convert.ToInt32(Console.ReadLine());
                            if (cevap3 == 1)
                            {
                                Console.WriteLine($"1 numaralı hesabınızın bakiyesi {hesap1} TL");
                                Console.WriteLine($"2 numarlaı hesabınızı bakiyesi {hesap2} TL");
                                Console.WriteLine("Lütfen 2 numaralı hesaba aktarmak istediğiniz tutarı giriniz");
                                tutar = Convert.ToInt32(Console.ReadLine());
                                if (hesap1 >= tutar)
                                {
                                    hesap1 -= tutar;
                                    hesap2 += tutar;
                                    Console.WriteLine($"İşleminiz gerçekleştirildi.\nHesap 1'in yeni bakiyesi {hesap1} TL\nHesap 2'nin yeni bekiyesi {hesap2}TL.");
                                }

                            }
                            if (cevap3 == 2)
                            {
                                Console.WriteLine($"1 numaralı hesabınızın bakiyesi {hesap1} TL");
                                Console.WriteLine($"2 numarlaı hesabınızı bakiyesi {hesap2}");
                                Console.WriteLine("Lütfen 1 numaralı hesaba aktarmak istediğiniz tutarı giriniz.");
                                tutar = Convert.ToInt32(Console.ReadLine());
                                if (hesap2 >= tutar)
                                {
                                    hesap1 += tutar;
                                    hesap2 -= tutar;
                                    Console.WriteLine($"İşleminiz gerçekleştirildi.\nHesap 1'in yeni bakiyesi {hesap1} TL\nHesap 2'nin yeni bekiyesi {hesap2}TL.");
                                }
                            }

                        }
                        if (cevap4 == 3)//1-3
                        {
                            Console.WriteLine("1 numaralı hesabınızdan 3 numaralı hesabınıza para aktarmak için 1'e basınız\n3 numaralı hesabınızdan 1 numaralı hesaba para aktarmak için 2'ye basınız\nİşlemi sonlandırmak için 0'a basınız");
                            cevap3 = Convert.ToInt32(Console.ReadLine());
                            if (cevap3 == 1)
                            {
                                Console.WriteLine($"1 numaralı hesabınızın bakiyesi {hesap1} TL");
                                Console.WriteLine($"3 numarlaı hesabınızı bakiyesi {hesap3} TL");
                                Console.WriteLine("Lütfen 3 numaralı hesaba aktarmak istediğiniz tutarı giriniz");
                                tutar = Convert.ToInt32(Console.ReadLine());
                                if (hesap1 >= tutar)
                                {
                                    hesap1 -= tutar;
                                    hesap3 += tutar;
                                    Console.WriteLine($"İşleminiz gerçekleştirildi.\nHesap 1'in yeni bakiyesi {hesap1} TL\nHesap 3'ün yeni bekiyesi {hesap3}TL.");
                                }

                            }
                            if (cevap3 == 2)
                            {
                                Console.WriteLine($"1 numaralı hesabınızın bakiyesi {hesap1} TL");
                                Console.WriteLine($"3 numarlaı hesabınızı bakiyesi {hesap3}");
                                Console.WriteLine("Lütfen 1 numaralı hesaba aktarmak istediğiniz tutarı giriniz.");
                                tutar = Convert.ToInt32(Console.ReadLine());
                                if (hesap3 >= tutar)
                                {
                                    hesap1 += tutar;
                                    hesap3 -= tutar;
                                    Console.WriteLine($"İşleminiz gerçekleştirildi.\nHesap 1'in yeni bakiyesi {hesap1} TL\nHesap 3'ün yeni bekiyesi {hesap3}TL.");
                                }
                            }

                        }
                        if (cevap4 == 4)//2-ana
                        {
                            Console.WriteLine("2 numaralı hesabınızdan ana hesaba para aktarmak için 1'e basınız\nAna hesaptan 2 numaralı hesaba para aktarmak için 2'ye basınız\nİşlemi sonlandırmak için 0'a basınız");
                            cevap3 = Convert.ToInt32(Console.ReadLine());
                            if (cevap3 == 1)
                            {
                                Console.WriteLine($"Ana hesabın bakiyesi {bakiye}");
                                Console.WriteLine($"2 numaralı hesabınızın bakiyesi {hesap2} TL");
                                Console.WriteLine("Lütfen ana hesaba aktarmak istediğiniz tutarı giriniz");
                                tutar = Convert.ToInt32(Console.ReadLine());
                                if (hesap2 >= tutar)
                                {
                                    hesap2 -= tutar;
                                    bakiye += tutar;
                                    Console.WriteLine($"İşleminiz gerçekleştirildi.\nHesap 2'in yeni bakiyesi {hesap2} TL\nAna hesabın yeni bekiyesi {bakiye}TL.");
                                }

                            }
                            if (cevap3 == 2)
                            {
                                Console.WriteLine($"2 numaralı hesabınızın bakiyesi {hesap2} TL");
                                Console.WriteLine($"Ana hesabın bakiyesi {bakiye}");
                                Console.WriteLine("Lütfen 2 numaralı hesaba aktarmak istediğiniz tutarı giriniz.");
                                tutar = Convert.ToInt32(Console.ReadLine());
                                if (bakiye >= tutar)
                                {
                                    hesap2 += tutar;
                                    bakiye -= tutar;
                                    Console.WriteLine($"İşleminiz gerçekleştirildi.\nHesap 2'nin yeni bakiyesi {hesap2} TL\nAna hesabın yeni bekiyesi {bakiye}TL.");
                                }
                            }

                        }
                        if (cevap4 == 5)//2-3
                        {
                            Console.WriteLine("2 numaralı hesabınızdan 3 numaralı hesaba para aktarmak için 1'e basınız\nAna hesaptan 2 numaralı hesaba para aktarmak için 2'ye basınız\nİşlemi sonlandırmak için 0'a basınız");
                            cevap3 = Convert.ToInt32(Console.ReadLine());
                            if (cevap3 == 1)
                            {
                                Console.WriteLine($"2 numaralı hesabınızın bakiyesi {hesap2} TL");
                                Console.WriteLine($"3 numaralı hesabın bakiyesi {hesap3}");
                                Console.WriteLine("Lütfen 3 numaralı hesaba aktarmak istediğiniz tutarı giriniz");
                                tutar = Convert.ToInt32(Console.ReadLine());
                                if (hesap2 >= tutar)
                                {
                                    hesap2 -= tutar;
                                    hesap3 += tutar;
                                    Console.WriteLine($"İşleminiz gerçekleştirildi.\nHesap 2'in yeni bakiyesi {hesap2} TL\n3 numaralı hesabın yeni bekiyesi {hesap3}TL.");
                                }

                            }
                            if (cevap3 == 2)
                            {
                                Console.WriteLine($"2 numaralı hesabınızın bakiyesi {hesap2} TL");
                                Console.WriteLine($"3 numaralı hesabın bakiyesi {hesap3}");
                                Console.WriteLine("Lütfen 2 numaralı hesaba aktarmak istediğiniz tutarı giriniz.");
                                tutar = Convert.ToInt32(Console.ReadLine());
                                if (hesap3 >= tutar)
                                {
                                    hesap2 += tutar;
                                    hesap3 -= tutar;
                                    Console.WriteLine($"İşleminiz gerçekleştirildi.\nHesap 2'nin yeni bakiyesi {hesap2} TL\n3 numaralı hesabın yeni bekiyesi {hesap3}TL.");
                                }
                            }
                        }
                        if (cevap4 == 6)//3-ana
                        {
                            Console.WriteLine("3 numaralı hesabınızdan ana hesaba para aktarmak için 1'e basınız\nAna hesaptan 3 numaralı hesaba para aktarmak için 2'ye basınız\nİşlemi sonlandırmak için 0'a basınız");
                            cevap3 = Convert.ToInt32(Console.ReadLine());
                            if (cevap3 == 1)
                            {
                                Console.WriteLine($"Ana hesabın bakiyesi {bakiye}");
                                Console.WriteLine($"3 numaralı hesabınızın bakiyesi {hesap3} TL");
                                Console.WriteLine("Lütfen ana hesaba aktarmak istediğiniz tutarı giriniz");
                                tutar = Convert.ToInt32(Console.ReadLine());
                                if (hesap3 >= tutar)
                                {
                                    hesap3 -= tutar;
                                    bakiye += tutar;
                                    Console.WriteLine($"İşleminiz gerçekleştirildi.\nHesap 3'ün yeni bakiyesi {hesap3} TL\nAna hesabın yeni bekiyesi {bakiye}TL.");
                                }

                            }
                            if (cevap3 == 2)
                            {
                                Console.WriteLine($"3 numaralı hesabınızın bakiyesi {hesap3} TL");
                                Console.WriteLine($"Ana hesabın bakiyesi {bakiye}");
                                Console.WriteLine("Lütfen 3 numaralı hesaba aktarmak istediğiniz tutarı giriniz.");
                                tutar = Convert.ToInt32(Console.ReadLine());
                                if (bakiye >= tutar)
                                {
                                    hesap3 += tutar;
                                    bakiye -= tutar;
                                    Console.WriteLine($"İşleminiz gerçekleştirildi.\nHesap 3'ün yeni bakiyesi {hesap3} TL\nAna hesabın yeni bekiyesi {bakiye}TL.");
                                }
                            }
                        }
                        Console.WriteLine("Başka bir işlem yapmak için 2'ye basınız.\nİşlemi iptal etmek için 0'a basınız.");
                        cevap3 = Convert.ToInt32(Console.ReadLine());
                        if (cevap3 == 0)
                        {
                            Console.WriteLine("İşleminiz sonlandırıldı.İyi günler");
                        }


                    }

                    if (cevap1 == 4)
                    {
                        Console.WriteLine("İşleminiz sonlandırılmıştır.İyi günler.");
                    }


                }

            }
        }
    }
}
