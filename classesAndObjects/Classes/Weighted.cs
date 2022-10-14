namespace Wellness.Classes
{
  public abstract class Weighted : WellnessObjects
  {
    public override string Category { get; set; } = "Weighted";
    public abstract double Weight { get; set; }

  }

  public class WeightedBlanket : Weighted
  {
    public override string typeOfObject { get; set; } = "Weighted Blanket";
    public override double Weight { get; set; }
    public override string Name { get; set; }
    public WeightedBlanket(double weight, string name)
    {
      Weight = weight;
      Name = name;
    }
  }

  public class WeightedStuffedAnimal : Weighted
  {
    public override string typeOfObject { get; set; } = "Weighted Stuffed Animal";
    public override double Weight { get; set; }
    public string typeOfCreature { get; set; }
    public override string Name { get; set; }
    public WeightedStuffedAnimal(double weight, string creature, string name)
    {
      Weight = weight;
      typeOfCreature = creature;
      Name = name;
    }
  }
}