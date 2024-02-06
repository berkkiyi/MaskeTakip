using Business.Concrete;
using Entities.Concrete;

SelamVer("Berk");
SelamVer("Engin");
SelamVer("Mehmet");
SelamVer();

Topla(6, 58);

//Diziler / Arrays
string[] ogrenciler = { "Engin", "Kerem", "Doğan", "İlker" };

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}
Console.WriteLine("***********************************");
string[] sehirler1 = { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = { "Bursa", "Antalya", "Diyarbakır" };

sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);

Person person1 = new Person();
person1.FirstName = "Berk";
person1.LastName = "Kıyı";
person1.DateOfBirthYear = 2001;
person1.NationalIdentity = 123456789;

Person person2 = new Person();
person2.FirstName = "Ömer";

foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}
//Array yerine generic collectionslar gerçek projelerde kullanılıyor.
List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "Kocaeli 1" };
yeniSehirler1.Add("İzmir 1");
foreach (var sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}
Console.WriteLine("***********************************");

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);



static void SelamVer(string isim = "İsimsiz")
{
    Console.WriteLine($"Merhaba {isim}");
}

static int Topla(int sayi1, int sayi2 = 10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine($"{sayi1} + {sayi2} = {sonuc.ToString()}");
    return sonuc;
}