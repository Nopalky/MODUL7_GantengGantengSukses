using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MODUL7_GGS
{

    public class movieStruc {
        [JsonInclude]
        public string id;
        [JsonInclude]
        public int year;
        [JsonInclude]
        public string genre;
        [JsonInclude]
        public double rating;
    }
    public class Watchlist_103022400008
    {
        [JsonInclude]
        public string watchList;
        [JsonInclude]
        public string createdBy;
        [JsonInclude]
        public List<movieStruc> movies;

        public void ReadJSON() {
            string fileJSON = "jurnal7_2_103022400008.json";
            string stringifyJson = File.ReadAllText(fileJSON);
            var data = JsonSerializer.Deserialize<Watchlist_103022400008>(stringifyJson)!;


                Console.WriteLine(data.watchList);
                Console.WriteLine(data.createdBy);
                foreach (var item in data.movies) {
                    Console.WriteLine("Data Film : \nId : " + item.id +  " \nTitle : " + item.year.ToString() + " \nDirector: " + item.genre + " \nRating"
                    + item.rating.ToString());
                }
            
        }
    }
}
