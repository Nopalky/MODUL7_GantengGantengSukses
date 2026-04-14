using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MODUL7_GGS
{
    public class FilmFavorite_103022400008
    {

        [JsonInclude]
        public string title;
        [JsonInclude]
        public string director;
        [JsonInclude]
        public string year;
        [JsonInclude]
        public string genre;
        [JsonInclude]
        public int rating;
        [JsonInclude]
        public int durationMinutes;
        [JsonInclude]
        public bool isWatched;

        public void ReadJSON() {
            string fileJSON = "jurnal7_1_103022400008.json";
            string stringifyJson = File.ReadAllText(fileJSON);
            var data = JsonSerializer.Deserialize<FilmFavorite_103022400008>(stringifyJson)!;

            Console.WriteLine("Data Film : \nTitle : " + data.title + " \nDirector: " + data.director + " \nYear: " + data.year + " \nGenre:" + data.genre + " \nRating" 
                + data.rating.ToString() + " \nDuration:" + data.durationMinutes.ToString() + " Ditonton : " + data.isWatched.ToString());
        }

    }
}
