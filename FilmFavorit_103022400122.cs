using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MODUL7_GGS
{
    internal class FilmFavorit_103022400122
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
        public bool isWatched { get; set; }
       
        public void ReadJson()
        {
            string filePath = "jurnal7_1_103022400122.json";
            try
            {
                string jsonString = System.IO.File.ReadAllText("../../../"+filePath);
                FilmFavorit_103022400122 film = JsonSerializer.Deserialize<FilmFavorit_103022400122>(jsonString);

                Console.WriteLine($"Judul {film.title} dengan Director {film.director} Tahun {film.year} dengan Genre {film.genre} memiliki Rating {film.rating} dengan Durasi {film.durationMinutes} dan Sudah di Tonton {film.isWatched}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
