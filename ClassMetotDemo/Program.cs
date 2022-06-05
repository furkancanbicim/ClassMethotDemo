using ClassMetotDemo;


Musteri musteri = new Musteri() 
{
Id = 1,
Name = "Ali",
Surname = "Veli",
Phone = "0555555555" 
};

Musteri musteri1 = new Musteri()
{
    Id = 2,
    Name = "Mehmet",
    Surname = "Sura",
    Phone = "05444444444"
};

List<Musteri>musteriler = new List<Musteri>();
musteriler.Add(musteri);
musteriler.Add(musteri1);

MusteriManager MusteriM = new MusteriManager();
MusteriM.MusteriEkle(musteri);
MusteriM.MusteriEkle(musteri1);

Console.WriteLine("\nMüşteri Listesi :");
MusteriM.MusteriListele(musteriler);

Console.WriteLine("\n--------------------------------------------------------------");

MusteriM.MusteriSil(musteri);
MusteriM.MusteriSil(musteri1);