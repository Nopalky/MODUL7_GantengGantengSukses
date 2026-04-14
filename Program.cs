namespace MODUL7_GGS
{
    public class Program {
        public static void Main(string[] args) {
            var dataFilm = new FilmFavorite_103022400008();
            dataFilm.ReadJSON();

            var wl = new Watchlist_103022400008();
            wl.ReadJSON();
        }
    }
}