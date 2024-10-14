using homework2;
Console.Clear();
Baby baby = new Baby(); // Baby classından baby1 nesnesi oluşturuldu.
baby.Name = "ilayda";
baby.Surname = "tas";
baby.Birthdate = new DateTime(2023, 12, 12);
Console.WriteLine($"Baby: {baby.Name} {baby.Surname}'s birthdate {baby.Birthdate}."); 
// baby field'larına property'ler aracılığıyla değer atandı ve yazdırıldı.

Baby baby1 = new Baby("Burak", "Özkan");
Console.WriteLine($"Baby: {baby1.Name} {baby1.Surname}'s birthdate {baby1.Birthdate}.");
// Baby classından baby1 nesnesi oluşturuldu ve constructor aracılığıyla field'larına değer atandı ve yazdırıldı.
Console.ReadKey();


