using homework3;
Console.Clear();

Console.WriteLine("Patika Kütüphanesine Hoş Geldiniz!");
Kitap kitap1 = new Kitap(); // new keyword ile Kitap class'ından bir nesne oluşturuldu.
kitap1.Adi = "Adı Aylin";
kitap1.YazarAdi = "Ayşe";
kitap1.YazarSoyadi = "Kulin";
kitap1.SayfaSayisi = 398;
kitap1.YayinEvi = "Remzi Kitapevi";
kitap1.Bilgi(); // Kitabın bilgilerini consola yazan method
Console.WriteLine("-------------------------------------------------");

Kitap kitap2 = new Kitap("Bir Gün", "David", "Nicholls", 430, "Pegasus Yayınları");
kitap2.Bilgi(); // Kitabın bilgilerini consola yazan method

Console.ReadKey();



