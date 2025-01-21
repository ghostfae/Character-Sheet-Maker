namespace DnDCharacterSheet;

public class Class
{
   public int HitDie;
   public int ProficiencyBonus;

   public Stat[] SavingThrows;
   public Skill[] SkillProficiencies;
   public Proficiency[] Proficiencies;
   public Feature[] Features;
   public StarterEquipment[] Equipment;

   public Class(int hitDie, int proficiencyBonus, Stat[] savingThrows,
      Skill[] skillProficiencies, Proficiency[] proficiencies,
      Feature[] features, StarterEquipment[] equipment)
   {
      HitDie = hitDie;
      ProficiencyBonus = proficiencyBonus;
      SavingThrows = savingThrows;
      SkillProficiencies = skillProficiencies;
      Proficiencies = proficiencies;
      Features = features;
      Equipment = equipment;
   }
}

public class ClassList
{
   public Class Barbarian 
      = new Class(12, 2, new Stat[2],
         new Skill[6], new Proficiency[2],
         new Feature[2], new StarterEquipment[4]);
   
   public Class Wizard
      = new Class(8, 2, new Stat[2],
         new Skill[6], new Proficiency[2],
         new Feature[2], new StarterEquipment[4]);
}