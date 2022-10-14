namespace Wellness.Classes
{
  public abstract class Recreational : WellnessObjects
  {
    public override string Category { get; set; } = "Recrational";
  }

  public class Hug : Recreational
  {
    public override string typeOfObject { get; set; } = "Physical Contact";
    public override string Name { get; set; } = "Hug";
    public override int numberNeededForRelief { get; set; } = 8;
  }

  public class FriendAndFamilyTime : Recreational
  {
    public override string typeOfObject { get; set; } = "Emotional Intimacy";
    public override string Name { get; set; }
    public FriendAndFamilyTime(string activity)
    {
      Name = activity;
    }
  }
}