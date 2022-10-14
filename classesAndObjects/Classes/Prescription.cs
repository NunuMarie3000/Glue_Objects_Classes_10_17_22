namespace Wellness.Classes
{
  public abstract class Prescription : WellnessObjects
  {
    public override string Category { get; set; } = "Prescription";
    public abstract int PrescriptionAmount { get; set; }
  }

  public class Capsule : Prescription
  {
    public override int PrescriptionAmount { get; set; }
    public override int numberNeededForRelief { get; set; }
    public override string typeOfObject { get; set; } = "Prescription Capsule";
    public override string Name { get; set; }
    public Capsule(int amount, int dosage, string name)
    {
      PrescriptionAmount = amount;
      numberNeededForRelief = dosage;
      Name = name;
    }
  }
}