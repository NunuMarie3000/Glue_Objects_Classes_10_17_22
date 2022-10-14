namespace Wellness.Classes
{
  public abstract class WellnessObjects
  {
    public virtual bool providesRelief { get; set; } = true;
    public virtual int numberNeededForRelief { get; set; } = 1;
    public abstract string typeOfObject { get; set; }
    public abstract string Category { get; set; }
    public abstract string Name { get; set; }
  }
}