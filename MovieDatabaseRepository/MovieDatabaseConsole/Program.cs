using MovieDatabaseDomain;
using MovieDatabaseDTO;
using MovieDatabaseRepository;
using Microsoft.Extensions.Options;

MovieInteractor _movieInteractor = new MovieInteractor();

Console.WriteLine("Movie Database Lab");



Console.WriteLine("1. Movie Title Search");
Console.WriteLine("2. Movie Genre Search");

int input = int.Parse(Console.ReadLine());

switch (input)
{
    case 1:
        MovieTitleSearch(_movieInteractor);
        break;
    case 2:
        MovieGenreSearch(_movieInteractor);
        break;
    case 3:
        Environment.Exit(0);
        break;
}


static void MovieTitleSearch(MovieInteractor _movieInteractor)
{
    Console.Clear();
    Console.WriteLine("Enter a movie title to search for: ");
    string movieTitleSearch = Console.ReadLine().ToLower();
    foreach (Movie movie in _movieInteractor.GetTitles(movieTitleSearch))
    {
        Console.WriteLine($"Title: {movie.Title} Genre: {movie.Genre} Runtime: {movie.Runtime}");
    }
    Console.WriteLine("Press enter to close program");
}
static void MovieGenreSearch(MovieInteractor _movieInteractor)
{
    Console.Clear();
    Console.WriteLine("Enter a movie genre to search for: ");
    string movieGenreSearch = Console.ReadLine().ToLower();
    foreach (Movie movie in _movieInteractor.GetGenres(movieGenreSearch))
    {
        Console.WriteLine($"Title: {movie.Title} Genre: {movie.Genre} Runtime: {movie.Runtime}");
    }
    Console.WriteLine("Press enter to close program");
}

Console.ReadKey();


//void LoadStartUpData()
//{
//    foreach (Movie item in BuildItemCollection())
//    {
//        if (_movieInteractor.AddNewItem(item) == true)
//        {
//            Console.WriteLine($"{item.Title} was added to the database.");
//        }
//        else
//        {
//            Console.WriteLine($"{item.Title} was NOT added to the database.");
//        }
//    }
//}

//List<Movie> BuildItemCollection()
//{
//    List<Movie> initialItems = new List<Movie>();
//    initialItems.Add(new Movie() { Title = "Inception", Genre = "Action", Runtime = 158 });
//    initialItems.Add(new Movie() { Title = "Spirited", Genre = "Fantasy", Runtime = 127 });
//    initialItems.Add(new Movie() { Title = "Black Adam", Genre = "Action", Runtime = 125 });
//    initialItems.Add(new Movie() { Title = "Us", Genre = "Horror", Runtime = 121 });
//    initialItems.Add(new Movie() { Title = "Harry Potter", Genre = "Fantasy", Runtime = 152 });
//    initialItems.Add(new Movie() { Title = "Flubber", Genre = "Comedy", Runtime = 94 });
//    initialItems.Add(new Movie() { Title = "Nutty Professor", Genre = "Comedy", Runtime = 95 });
//    initialItems.Add(new Movie() { Title = "Frozen", Genre = "Animation", Runtime = 108 });
//    initialItems.Add(new Movie() { Title = "Little Mermaid", Genre = "Adventure", Runtime = 83 });
//    initialItems.Add(new Movie() { Title = "Nope", Genre = "Horror", Runtime = 130 });
//    initialItems.Add(new Movie() { Title = "The Northman", Genre = "Action", Runtime = 137 });
//    initialItems.Add(new Movie() { Title = "Dr. Dolittle", Genre = "Comedy", Runtime = 101 });
//    initialItems.Add(new Movie() { Title = "Fantasia", Genre = "Musical", Runtime = 125 });
//    initialItems.Add(new Movie() { Title = "Shrek", Genre = "Fantasy", Runtime = 90 });
//    initialItems.Add(new Movie() { Title = "A Quiet Place", Genre = "Thriller", Runtime = 90 });

//    return initialItems;
//}

//LoadStartUpData();













