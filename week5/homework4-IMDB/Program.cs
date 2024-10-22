using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

public class Movie
{
    public string Name { get; set; }
    public double Score { get; set; }
    public Movie(string name, double score)
    {
        this.Name = name;
        this.Score = score;
    }
}
public class Program
{
    static void Main()
    {
        Console.Clear();
        List<Movie> movies = new List<Movie>();
        for (; ; ) //sonsuz döngü
        {
            Console.Write("Lütfen film adını giriniz: ");
            string movieName = Console.ReadLine();
            Console.Write("Lütfen film puanını giriniz: ");
            double movieScore = Convert.ToDouble(Console.ReadLine());
            movies.Add(new Movie(movieName, movieScore));
            Console.WriteLine("Başarıyla eklendi.");
            Console.Write("Başka bir film eklemek ister misiniz? (E/H): ");
            string answer = Console.ReadLine();
            if (answer.ToUpper() != "E")
            {
                break;
            }
        }
        Console.WriteLine("Film Listesi: ");
        foreach (var movie in movies)
        {
            Console.WriteLine($"Film Adı: {movie.Name} - Puanı: {movie.Score}");
        }
        Console.WriteLine("4 ile 9 arasındaki filmler");
        foreach (var movie in movies)
        {
            if (movie.Score > 4 && movie.Score < 9)
            {
                Console.WriteLine($"Film Adı: {movie.Name} - Puanı: {movie.Score}");
            }

        }
        Console.WriteLine("A ile başlayan filmler: ");
        foreach (var movie in movies)
        {
            if (movie.Name.StartsWith("A") || movie.Name.StartsWith("a")) //A ile başlayan filmleri yazdırır
            {
                Console.WriteLine($"Film Adı: {movie.Name} - Puanı: {movie.Score}");
            }
        }
        Console.ReadKey();
    }
}


