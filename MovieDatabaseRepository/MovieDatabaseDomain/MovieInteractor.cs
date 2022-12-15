using MovieDatabaseDTO;
using MovieDatabaseRepository;


namespace MovieDatabaseDomain
{
    public class MovieInteractor
    {
        private MovieRepository _repository;
        public MovieInteractor()
        {
            _repository = new MovieRepository();
        }


        public bool AddNewItem(Movie movie)
        {
            if (string.IsNullOrEmpty(movie.Title) || string.IsNullOrEmpty(movie.Genre))
            {
                throw new ArgumentException("Valid title and genre required");
            }
            return _repository.AddItem(movie);
        }


        public List<Movie> GetGenres(string genre)
        {
            return _repository.GetGenres(genre);
        }
        public List<Movie> GetTitles(string title)
        {
            return _repository.GetTitles(title);
        }
    }
}