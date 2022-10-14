using Classes.Classes;

namespace Classes
{
  class Program
  {
    static void Main(string[] args)
    {
      FavMovie();
      Console.ReadKey();
      anotherFavMovie();
    }
    static void FavMovie()
    {
      Movie harderTheyFall = new Movie("The Harder They Fall", 88, 2021, 90000000, 8292);
      harderTheyFall.MovieTea();
      Console.WriteLine($"The program's reflection of this movie's rating does not align with my personal opinions.{harderTheyFall.Name} was absolutely {MovieFeedback.Phenomenal.ToString()} in my opinion");
    }
    static void anotherFavMovie()
    {
      Movie sorryToBother = new Movie("Sorry to Bother You", 93, 2018, 3200000, 18200000 );
      sorryToBother.MovieTea();
    }
  }
}