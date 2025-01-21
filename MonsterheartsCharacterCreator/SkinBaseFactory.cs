namespace Monsterhearts;

public class SkinBaseFactory
{
   public SkinBase CreateSkinBase(Skins skinType, string description, string longDescription,
      string[] names, string[] looks, string[] eyes, string[] origins,
      Stats[] stats, string backstory, string darkestSelf, string sexMove,
      Moves[] moves, string[] experience)

   {
      var skin = new SkinBase
      {
         SkinType = skinType,
         Description = description,
         LongDescription = longDescription,
         Names = names,
         Looks = looks,
         Eyes = eyes,
         Origin = origins,
         Stats = stats,
         Backstory = backstory,
         DarkestSelf = darkestSelf,
         SexMove = sexMove,
         Moves = moves,
         Experience = experience
      };

      return skin;
   }
}