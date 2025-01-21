namespace DnDCharacterSheet;

public class CharacterSheet
{
   public string Name;
   public Race Race;
   public Class Class;
   public Background Background;

   public int HitPoints;
   public int HitDie;
   public int Initiative;
   public int Speed;
   public int ProficiencyBonus;

   public int Strength;
   public int Dexterity;
   public int Constitution;
   public int Intelligence;
   public int Wisdom;
   public int Charisma;

   // skills
   public Skill Athletics;


   // proficiency - new class?
   public Proficiency[] LanguageProficiencies;
   public Proficiency[] ArmourProficiencies;
   public Proficiency[] WeaponProficiencies;
   public Proficiency[] ToolProficiencies;

   // features
   public Feature[] Features;

   public Equipment[] Equipment;
}