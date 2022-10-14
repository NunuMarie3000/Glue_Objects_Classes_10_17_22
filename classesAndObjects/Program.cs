using Wellness.Classes;

namespace Wellness
{
  class Program
  {
    static void Main(string[] args)
    {
      WellnessObjectOfChoice();
    }

    static void WellnessObjectOfChoice()
    {
      Weighted myBlanket = new WeightedBlanket(15.5, "Rainbow Blankie");
      Prescription myPills = new Capsule(15, 1, "Sertraline");
      Recreational gameNight = new FriendAndFamilyTime("Playing board games");

      Console.WriteLine($"Hey, my name is Storm and I love to sleep with my {myBlanket.Weight} pound {myBlanket.typeOfObject}. Her name is {myBlanket.Name}. I used to be on prescription medication, but I'm doing much better now. I was taking {myPills.PrescriptionAmount} mL of {myPills.Name} for depression, but being home with my family has been so good for my mental health. Something that makes me happy is {gameNight.Name} with my mom and sister! Take care of yourselves, life is hard, but we can do it!");
    }
  }
}
