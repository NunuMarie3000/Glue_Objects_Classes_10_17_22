using Wellness.Classes;

namespace Wellness
{
  class Program
  {
    static void Main(string[] args)
    {
      // MyWellnessObjectOfChoice();
      ChooseYourOwnWellness();
    }

    static void ChooseYourOwnWellness()
    {
      Console.WriteLine("***Hello! I believe in mental wellness for everyone! What's do you use to take care of your mental health?\nPrescription Medication, Weighted Objects, or Recreational Activities?");
      string wellnessChoice = Console.ReadLine();
      if (wellnessChoice.ToLower() == "prescription medication" || wellnessChoice.ToLower() == "prescription" || wellnessChoice.ToLower() == "medication")
      {
        inCaseOfPrescription();
      }
      else if (wellnessChoice.ToLower() == "weighted objects" || wellnessChoice.ToLower() == "weighted")
      {
        inCaseOfWeighted();
      }
      else if (wellnessChoice.ToLower() == "recreational activities " || wellnessChoice.ToLower() == "recreation" || wellnessChoice.ToLower() == "activity")
      {
        inCaseOfRecreational();
      }
      else
        Console.WriteLine("Okay! That's all right!");
      Closing();
    }

    static void inCaseOfRecreational()
    {
      Console.WriteLine("Great! Do you prefer emotional intimacy or physical contact?");
      string emotionalOrPhysical = Console.ReadLine();
      Console.WriteLine("And what activity do you like doing to support that?");
      string activity = Console.ReadLine();
      Recreational userRecreation;
      // instantiating new weighted class
      if (emotionalOrPhysical.ToLower() == "emotional" || emotionalOrPhysical.ToLower() == "imtimacy" || emotionalOrPhysical.ToLower() == "emotion" || emotionalOrPhysical.ToLower() == "emotional intimacy")
      {
        userRecreation = new EmotionalIntimacy(activity);
        Console.WriteLine($"Okay, I have your comfort of choice as being the {userRecreation.typeOfObject} activity of {userRecreation.Name} to take care of your mental health!");
      }
      else if(emotionalOrPhysical.ToLower() == "physical" || emotionalOrPhysical.ToLower() == "physical contact" || emotionalOrPhysical.ToLower() == "contact")
      {
        userRecreation = new PhysicalContact(activity);
        Console.WriteLine($"Okay, I have your comfort of choice as being the {userRecreation.typeOfObject} activity of {userRecreation.Name} to take care of your mental health!");
      }
      
    }

    static void inCaseOfWeighted()
    {
      Console.WriteLine("Great! Do you have a blanket or stuffed animal?");
      string blanketOrAnimal = Console.ReadLine();
      Console.WriteLine("And how much does it weight in pounds?");
      double weight = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Awesome! And what's their name?");
      string name = Console.ReadLine();
      Weighted userTool;
      // instantiating new weighted class
      if (blanketOrAnimal.ToLower() == "blanket")
        userTool = new WeightedBlanket(weight, name);
      else
      {
        Console.WriteLine("Cute! What type of animal are they?");
        string type = Console.ReadLine();
        userTool = new WeightedStuffedAnimal(weight, type, name);
      }
      Console.WriteLine($"Okay, I have your comfort of choice as being a {userTool.Weight} pound {userTool.typeOfObject} named {userTool.Name} to take care of your mental health!");
    }

    static void inCaseOfPrescription()
    {
      Console.WriteLine("Great! What's the name of your medication?");
      string name = Console.ReadLine();
      Console.WriteLine("And the dosage?");
      int dosage = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("I know this feels invasive, just one more question. How much were you allotted?");
      int amount = Convert.ToInt32(Console.ReadLine());
      // instantiating new capsule class
      Prescription userMedication = new Capsule(amount, dosage, name);
      Console.WriteLine($"I have you down for taking {userMedication.numberNeededForRelief} mL of {userMedication.Name} to take care of your mental health!");
    }

    static void Closing()
    {
      Console.WriteLine($"Thank you for sharing! Take care of yourself, life is hard, but we can do it!");
    }

    static void MyWellnessObjectOfChoice()
    {
      Weighted myBlanket = new WeightedBlanket(15.5, "Rainbow Blankie");
      Prescription myPills = new Capsule(15, 1, "Sertraline");
      Recreational gameNight = new EmotionalIntimacy("Playing board games");

      Console.WriteLine($"Hey, my name is Storm and I love to sleep with my {myBlanket.Weight} pound {myBlanket.typeOfObject}. Her name is {myBlanket.Name}. I used to be on prescription medication, but I'm doing much better now. I was taking {myPills.PrescriptionAmount} mL of {myPills.Name} for depression, but being home with my family has been so good for my mental health. Something that makes me happy is {gameNight.Name} with my mom and sister! Take care of yourselves, life is hard, but we can do it!");
    }
  }
}
