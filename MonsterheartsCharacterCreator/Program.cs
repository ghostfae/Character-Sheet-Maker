namespace Monsterhearts;


internal class CharacterCreator
{
   static void Main()
   {
      Console.WriteLine("Welcome to your Monsterhearts 2 character creator.");
      Console.WriteLine("This works by typing the number of your selection.");
      Console.WriteLine("Let's begin.");
   }

   static void /*SkinSheet*/ CreateSkin(SkinBase skinBase)
   {
      Console.WriteLine("First, please select a skin to learn more.");
      var userInput = Console.ReadLine();


   }
}

public class SkinSheet
{
   public Skins SkinType;

   public string Name;
   public string Look;
   public string Eyes;
   public string Origin;

   public Stats Stats;

   public string Backstory;
   public string DarkestSelf;
   public string SexMove;

   public List<Moves> Moves;
   public List<string> Experience;
}