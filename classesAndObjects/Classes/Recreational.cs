namespace Wellness.Classes
{
  public abstract class Recreational : WellnessObjects
  {
    public override string Category { get; set; } = "Recrational";
  }

  public class PhysicalContact : Recreational
  {
    public override string typeOfObject { get; set; } = "Physical Contact";
    public override string Name { get; set; }
    public override int numberNeededForRelief { get; set; }
    public PhysicalContact(string activity)
    {
      Name = activity;
    }
  }

  public class EmotionalIntimacy : Recreational
  {
    public override string typeOfObject { get; set; } = "Emotional Intimacy";
    public override string Name { get; set; }
    public EmotionalIntimacy(string activity)
    {
      Name = activity;
    }
  }
}