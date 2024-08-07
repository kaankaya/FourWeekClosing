using FourWeekClosing;

class Program
{

    public static void Main(string[] args)
    {
        //while ile sürekli yeni ürün istiyormu istemiyormu sorusu
        while (true)
        {
            Console.WriteLine("[1] Telefon üretmek için 1 e\n[2] Bilgisayar üretmek için 2'ye basın:");
            var choice = Console.ReadLine();
            //class değişken tanımı
            BaseClass device;
            if (choice == "1")
            {
                //nesne üretimi
                device = new Phone();
                //method ile dolumu
                CollectTelefonInfo((Phone)device);
            }
            else if (choice == "2")
            {
                device = new Computer();
                CollectBilgisayarInfo((Computer)device);
            }
            else
            {
                Console.WriteLine("Geçersiz seçim.");
                continue;
            }
            //bilgi mesajı ve gösterme methodları
            Console.WriteLine("Ürün başarıyla üretildi.");
            device.WriteInfo();
            device.GetName();
            //yeni ürün üretmek istemiyorsa while break
            Console.WriteLine("Başka bir ürün üretmek ister misiniz? (evet/hayir)");
            var again = Console.ReadLine().ToLower();
            if (again != "evet")
            {
                Console.WriteLine("İyi günler!");
                break;
            }
        }
    }
    //telefon nesnenesi için kulanıcıdan alınacak bilgiler
    public static void CollectTelefonInfo(Phone telefon)
    {
        Console.Write("Seri Numarası: ");
        telefon.SerialNumber = Console.ReadLine();

        Console.Write("Ad: ");
        telefon.Name = Console.ReadLine();

        Console.Write("Açıklama: ");
        telefon.Description = Console.ReadLine();

        Console.Write("İşletim Sistemi: ");
        telefon.OperatingSystem = Console.ReadLine();

        Console.Write("Türkiye'de lisanslı mı? (evet/hayir): ");
        telefon.TrLicense = Console.ReadLine().ToLower() == "evet";
    }
    //bilgisayar için kullanıcıdan alınacak bilgiler
    public static void CollectBilgisayarInfo(Computer computer)
    {
        Console.Write("Seri Numarası: ");
        computer.SerialNumber = Console.ReadLine();

        Console.Write("Ad: ");
        computer.Name = Console.ReadLine();

        Console.Write("Açıklama: ");
        computer.Description = Console.ReadLine();

        Console.Write("İşletim Sistemi: ");
        computer.OperatingSystem = Console.ReadLine();

        while (true)
        {
            Console.Write("USB Giriş Sayısı (2 veya 4): ");
            if (int.TryParse(Console.ReadLine(), out int usbPort))
            {
                computer.UsbPorts = usbPort;
                if (computer.UsbPorts != -1)
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("Geçersiz giriş, lütfen bir sayı girin.");
            }
        }

        Console.Write("Bluetooth var mı? (evet/hayir): ");
        computer.Bluetooth = Console.ReadLine().ToLower() == "evet";
    }
}