namespace Classes.Classes
{
  public class Movie
  {
    // NEEDS
    // name, rating, year released, budget, income
    public string Name { get; set;}
    public int Rating { get; set; }
    public int YearReleased { get; set; }
    public decimal Budget { get; set; }
    public decimal Income { get; set; }
    // i could create a constructor or no...
    public Movie(string name, int rating, int year, decimal budget, decimal income)
    {
      Name = name;
      Rating = rating;
      YearReleased = year;
      Budget = budget;
      Income = income;
    }
    public void MovieTea()
    {
      Console.WriteLine($"My favorite movie is {Name} and it came out in {YearReleased}");
      Console.WriteLine($"The budget for {Name} was ${Budget.ToString("#,##0")}, but it made ${Income.ToString("#,##0")}");
      WasItGood();
    }
    public void WasItGood()
    {
      if(Rating <= 30)
        Console.WriteLine($"{Name} was {MovieFeedback.Terrible.ToString()}. It only scored {Rating}% on Rotten Tomatoes");
      else if(Rating >= 95)
        Console.WriteLine($"{Name} was absolutely {MovieFeedback.Phenomenal.ToString()}! It scored {Rating}% on Rotten Tomatoes");
      else if(Rating >= 60)
        Console.WriteLine($"Honestly, {Name} was sort of {MovieFeedback.Mediocre.ToString()}. It only scored {Rating}% on Rotten Tomatoes");
      else
        Console.WriteLine($"{Name} was pretty {MovieFeedback.Good.ToString()}. It scored {Rating}% on Rotten Tomatoes");
    }

  }

  public enum MovieFeedback
  {
    Terrible,
    Mediocre,
    Good,
    Phenomenal
  }
}