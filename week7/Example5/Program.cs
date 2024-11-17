Console.Clear();
static async Task PerformOperation() //async Task dönüyor.(istediğimiz şeyi dönebiliriz(void,int...))
{
    await Task.Delay(3000);
    Console.WriteLine("Operation completed.");
    //3 saniye bekleme yapar.
    //await: asenkron işlemleri yapmamızı sağlar. await kullanıldığında metot asenkron hale gelir.
    // task: asenkron işlemleri yapmamızı sağlayan bir class.
    //task.delay: bekleme fonksiyonu. task.delay(3000) 3 saniye bekleme yapar.
}
await PerformOperation(); // PerformOperation metodu çağrıldı. await kullanıldığı için bu satır çalıştıktan sonra PerformOperation metodu çalışır.
Console.WriteLine("Operation started."); // PerformOperation metodu çağrıldıktan sonra bu satır çalışır.

string result = await FetchData(); // FetchData metodu çağrıldı. await kullanıldığı için bu satır çalıştıktan sonra FetchData metodu çalışır.
Console.WriteLine(result); // FetchData metodu çalıştıktan sonra bu satır çalışır.

static async Task <string> FetchData()
{
    HttpClient client = new HttpClient();
    string result = await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts/1"); //getstringasync: verilen url'den veri çeker.
    return result; // veriyi döndürür.
}