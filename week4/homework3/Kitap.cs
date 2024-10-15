using System;

namespace homework3;

public class Kitap // class : nesneleri oluşturulmasında blueprint görevi görür. blueprint : yapı kağıdı
{
    public string Adi { get; set; } // property : nesnenin özelliklerini tanımlar ve field'lara nasıl erişim sağlayacağını belirler.
    public string YazarAdi { get; set; }
    public string YazarSoyadi { get; set; }
    public int SayfaSayisi { get; set; }
    public string YayinEvi { get; set; }
    public DateTime KayitTarihi { get; set; }

    public Kitap() // parametre almayan constructor
    {
        KayitTarihi = DateTime.Now; // şu anki tarih ve saat
    }

    public Kitap(string adi, string yazarAdi, string yazarSoyadi, int sayfaSayisi, string yayinEvi) // parametre alan constructor
    {
        Adi = adi;
        YazarAdi = yazarAdi;
        YazarSoyadi = yazarSoyadi;
        SayfaSayisi = sayfaSayisi;
        YayinEvi = yayinEvi;
        KayitTarihi = DateTime.Now; // şu anki tarih ve saat
    }
    public void Bilgi() // Kitabın bilgilerini consola yazan method
    {
        Console.WriteLine($"Kitap Adı: {Adi} \nYazar Adı: {YazarAdi} \nYazar Soyadı: {YazarSoyadi} \nSayfa Sayısı: {SayfaSayisi} \nYayın Evi: {YayinEvi} \nKayıt Tarihi: {KayitTarihi}");
    }
}


