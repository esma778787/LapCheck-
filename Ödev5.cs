using System;
using System.Collections.Generic;

class Laptop
{
    public string Islemci { get; set; }
    public string Ram { get; set; }
    public string Anakart { get; set; }
    public string Disk { get; set; }
    public string EkranKarti { get; set; }
    public double EkranBoyutu { get; set; }
    public string RamVeriYoluHizi { get; set; }
    public string DiskOkumaYazmaHizi { get; set; }
    public bool EkranKartiPaylasimli { get; set; }
    public double MonitorBoyutu { get; set; }
    public void DisplayDetails()
    {
        Console.WriteLine("\nGirilen Bilgisayarın Özellikleri:");
        Console.WriteLine($"Ekran Boyutu: {EkranBoyutu}\" - İşlemci: {Islemci} - RAM: {Ram} - Anakart: {Anakart} - Disk: {Disk} - Ekran Kartı: {EkranKarti}");
        if (!string.IsNullOrEmpty(RamVeriYoluHizi))
            Console.WriteLine($"RAM Veri Yolu Hızı: {RamVeriYoluHizi}");
        if (!string.IsNullOrEmpty(DiskOkumaYazmaHizi))
            Console.WriteLine($"Disk Okuma/Yazma Hızı: {DiskOkumaYazmaHizi}");
        if (EkranKartiPaylasimli)
            Console.WriteLine("Ekran Kartı Paylaşımlı: Evet");
        if (MonitorBoyutu > 0)
            Console.WriteLine($"Monitör Boyutu: {MonitorBoyutu}\"");
    }
}

class Program
{
    static void Main()
    {
        List<Laptop> laptops = new List<Laptop>();

        string[] markalar = { "Lenovo", "Sony", "Dell", "Asus" };

        foreach (string marka in markalar)
        {
            Laptop laptop = new Laptop();
            laptop.EkranBoyutu = 0; // Varsayılan değer

            Console.WriteLine($"Lütfen {marka} marka bilgisayarın özelliklerini girin:");

            if (marka == "Lenovo")
            {
                Console.Write("Ekran Boyutu (inç cinsinden) - 17.3 olmalıdır: ");
                laptop.EkranBoyutu = Convert.ToDouble(Console.ReadLine());
                Console.Write("İşlemci: ");
                laptop.Islemci = Console.ReadLine();



                Console.Write("RAM: ");
                laptop.Ram = Console.ReadLine();

                Console.Write("Anakart: ");
                laptop.Anakart = Console.ReadLine();

                Console.Write("Ekran Kartı: ");
                laptop.EkranKarti = Console.ReadLine();
            }
            else if (marka == "Sony")
            {
                Console.Write("İşlemci (en az i5): ");
                laptop.Islemci = Console.ReadLine();
                Console.Write("Ekran Boyutu (inç cinsinden): ");
                laptop.EkranBoyutu = Convert.ToDouble(Console.ReadLine());
                



                Console.Write("RAM: ");
                laptop.Ram = Console.ReadLine();

                Console.Write("Anakart: ");
                laptop.Anakart = Console.ReadLine();

                Console.Write("Ekran Kartı: ");
                laptop.EkranKarti = Console.ReadLine();
            }
            else if (marka == "Dell")
            {
                Console.Write("Disk (SSD olmalıdır): ");
                laptop.Disk = Console.ReadLine();
                Console.Write("Ekran Boyutu (inç cinsinden) : ");
                laptop.EkranBoyutu = Convert.ToDouble(Console.ReadLine());
                Console.Write("İşlemci: ");
                laptop.Islemci = Console.ReadLine();



                Console.Write("RAM: ");
                laptop.Ram = Console.ReadLine();

                Console.Write("Anakart: ");
                laptop.Anakart = Console.ReadLine();

                Console.Write("Ekran Kartı: ");
                laptop.EkranKarti = Console.ReadLine();
            }
            else if (marka == "Asus")
            {
                Console.Write("İşlemci (sadece i7 serisi üretiliyor): ");
                laptop.Islemci = Console.ReadLine();
                Console.Write("Ekran Boyutu (inç cinsinden) :");
                laptop.EkranBoyutu = Convert.ToDouble(Console.ReadLine());
                



                Console.Write("RAM: ");
                laptop.Ram = Console.ReadLine();

                Console.Write("Anakart: ");
                laptop.Anakart = Console.ReadLine();

                Console.Write("Ekran Kartı: ");
                laptop.EkranKarti = Console.ReadLine();
            }
           

            laptops.Add(laptop);
            Console.Write("RAM Veri Yolu Hızı (varsa, yoksa boş bırakın): ");
            laptop.RamVeriYoluHizi = Console.ReadLine();

            Console.Write("Disk Okuma/Yazma Hızı (varsa, yoksa boş bırakın): ");
            laptop.DiskOkumaYazmaHizi = Console.ReadLine();

            Console.Write("Ekran Kartı Paylaşımlı mı? (true/false, varsa): ");
            laptop.EkranKartiPaylasimli = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Monitör Boyutu (inç cinsinden, varsa): ");
            laptop.MonitorBoyutu = Convert.ToDouble(Console.ReadLine());

            laptop.DisplayDetails();

            Console.ReadLine();
        }

        Console.WriteLine("\nGirilen Bilgiler:");

        foreach (var laptop in laptops)
        {
            Console.WriteLine($"Ekran Boyutu: {laptop.EkranBoyutu}\" - İşlemci: {laptop.Islemci} - RAM: {laptop.Ram} - Anakart: {laptop.Anakart} - Disk: {laptop.Disk} - Ekran Kartı: {laptop.EkranKarti}");
        }


        string islemci, markas;
        double hiz, fiyat, karOrani = 0;

        Console.Write("İşlemci: ");
        islemci = Console.ReadLine();

        Console.Write("Hız: ");
        hiz = Convert.ToDouble(Console.ReadLine());

        Console.Write("Marka (lenovo, sony, dell, asus): ");
        markas = Console.ReadLine();

        // İşlemci ve hız koşullarına göre fiyat belirleme
        if (islemci == "i3 5.nesil 2.4GHz" && hiz == 2.4)
        {
            fiyat = 100;

            // Marka bazlı kar oranlarını kontrol etme
            switch (markas)
            {
                case "lenovo":
                    karOrani = 0.10;
                    break;
                case "sony":
                    karOrani = 0.09;
                    break;
                case "dell":
                    karOrani = 0.13;
                    break;
                case "asus":
                    karOrani = 0.15;
                    break;
                default:
                    Console.WriteLine("Geçersiz marka!");
                    return;
            }

            // Kar oranına göre fiyatı hesaplama
            fiyat += fiyat * karOrani;

            Console.WriteLine($"Fiyat: {fiyat:C}"); // C formatı ile $ cinsinden fiyatı yazdırır
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Belirtilen işlemci ve hız özelliklerine göre fiyatlandırma yapamıyoruz!");
            Console.ReadLine();
        }
    }
}



