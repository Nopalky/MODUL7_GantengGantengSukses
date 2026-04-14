using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MODUL7_GGS
{
    class FilmFavorit_103022400052
    {
        [JsonInclude]
        public String title { get; set; }
        [JsonInclude]
        public String director { get; set; }
        [JsonInclude]
        public String year { get; set; }
        [JsonInclude]
        public String genre { get; set; }
        [JsonInclude]
        public double rating { get; set; }
        [JsonInclude]
        public int durationMinutes { get; set; }
        [JsonInclude]
        public bool isWatched { get; set; }

        public void ReadJSON() {
            String jsonString = File.ReadAllText("../../../jurnal7_1_103022400052.json");
            FilmFavorit_103022400052 filmfav = JsonSerializer.Deserialize<FilmFavorit_103022400052>(jsonString);

            Console.WriteLine($"Judul film {filmfav.title} dengan director {filmfav.director} tahun {filmfav.year} dengan genre {filmfav.genre} Rating {filmfav.rating.ToString()} durasi {filmfav.durationMinutes.ToString()} Tertonton: {filmfav.isWatched}");

        }
    }

    class main {
        public static void Main(string[] args)
        {
            FilmFavorit_103022400052 film = new FilmFavorit_103022400052();
            film.ReadJSON();
        }
    }
}
