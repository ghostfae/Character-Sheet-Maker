namespace Monsterhearts;

public class SkinBase(Skins skinType, string description, string longDescription,
   string[] names, string[] looks, string[] eyes, string[] origins,
   Stats[] stats, string backstory, string darkestSelf, string sexMove,
   Moves[] moves, string[] experience)
{
   public Skins SkinType = skinType;
   public string Description = description;
   public string LongDescription = longDescription;
   public string[] Names = names;
   public string[] Looks = looks;
   public string[] Eyes = eyes;
   public string[] Origin = origins;
   public Stats[] Stats = stats;
   public string Backstory = backstory;
   public string DarkestSelf = darkestSelf;
   public string SexMove = sexMove;
   public Moves[] Moves = moves;
   public string[] Experience = experience;
}