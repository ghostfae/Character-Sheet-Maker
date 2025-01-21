namespace DnDCharacterSheet;

internal class CharacterCreator
{
   static void Main(string[] args)
   {
      var characterSheet = new CharacterSheet();

      Console.WriteLine("welcome to character creation");
      Console.WriteLine("please enter your character's name");

      var name = Console.ReadLine();
      characterSheet.Name = name;

      Console.WriteLine("please choose a race from the following options by typing the corresponding number");
      Console.WriteLine("1. Human");
      Console.WriteLine("2. Elf");
      Console.ReadLine();

      Console.WriteLine("please choose a class in the same manner");
      Console.WriteLine("1. Barbarian");
      Console.WriteLine("2. Wizard");
      Console.ReadLine();
   }
}