
using System.Text.Json.Serialization;
using System.Text.Json;

class FilmFavorit_103022400014
{
    [JsonInclude]
    public string title { get; set; }
    [JsonInclude]
    public string director { get; set; }
    [JsonInclude]
    public string year { get; set; }
    [JsonInclude]
    public string genre { get; set; }
    [JsonInclude]
    public int rating { get; set; }
    [JsonInclude]
    public int durationMinutes { get; set; }
    [JsonInclude]
    public Boolean isWatched { get; set; }

    public void ReadJSON() {

        string jsonString = File.ReadAllText("jurnal7_1_103022400014.json");
        FilmFavorit_103022400014 film = JsonSerializer.Deserialize<FilmFavorit_103022400014>
            (jsonString);

        Console.WriteLine($"Judul: {film.title} \nDirector: {film.director} \nYear: {film.year} " +
            $"\nGenre: {film.genre}" +
            $"\nRating: {film.rating} \nDurasi: {film.durationMinutes} \nIsWatched?: {film.isWatched}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        FilmFavorit_103022400014 film = new FilmFavorit_103022400014();
        film.ReadJSON();
    }
}
