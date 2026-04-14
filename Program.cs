using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

class FilmFavorit_103022400079
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

    public void ReadJSON()
    {
        string jsonString = File.ReadAllText("../../../"+"jurnal7_1_103022400079.json");
        FilmFavorit_103022400079 film = JsonSerializer.Deserialize<FilmFavorit_103022400079>(jsonString);
        Console.WriteLine($"Nama Film: {film.title} Tahun: {film.year} Genre: {film.genre} Rating: {film.rating} Jamdilihat: {film.durationMinutes} apakah dilihat? {film.isWatched}");
    }

}



class Program
{
    static void Main(string[] args)
    {
        FilmFavorit_103022400079 film = new FilmFavorit_103022400079();
        film.ReadJSON();
    }
}
