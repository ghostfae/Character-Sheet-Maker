namespace Monsterhearts;

public class SkinBaseFactory
{
   public SkinBase CreateSkinBase(Skins skinType, string description, string longDescription,
      string[] names, string[] looks, string[] eyes, string[] origins,
      Stats[] stats, string backstory, string darkestSelf, string sexMove,
      Moves[] moves, string[] experience)

   {
      var skin = new SkinBase
      (

         skinType,
         description,
         longDescription,
         names,
         looks,
         eyes,
         origins,
         stats,
         backstory,
         darkestSelf,
         sexMove,
         moves,
         experience
      );

      return skin;
   }
}

public class CoreSkins
{
   private SkinBaseFactory _skinBaseFactory = new();

   public SkinBase CreateSkinBase(Skins type)
   {
      return CreateFae();
   }

   private SkinBase CreateFae()
   {
      var description = "Fae";
      var longDescription =
         "At the edges of this world, just beyond the veil, there are colours that few mortals even dream of." +
         "Beauty enough to shatter any heart. The Fae live and breathe at the edges of this world. They keep a dusting of that magic tucked behind their ears, just in case.";

      var names = new []
         { "Anders", "Aurora", "Crow", "Gail", "Harmony", "Iris", "Lilith", "Ping", "Selene", "Sienna", "Walthus" };
      var looks = new []
         { "dainty", "girlish", "gaunt", "mysterious", "disheveled" };
      var eyes = new []
         { "quick", "lyrical", "mesmerizing", "laughing", "piercing" };
      var origins = new []
         { "fae born", "fae blooded", "swapped at birth", "stole the gift", "touched with the gift" };

      var stats = new Stats[] { new(2, -1, -1, 1), new(1, -1, 2, -1) };

      var backstory =
         "You wear your heart on your sleeve. Give everyone one String.\r\nYou’ve captured someone’s fancy. Gain 2 Strings on them.";

      var darkestSelf =
         "Everything you say seems a promise. Everything you hear seems a promise.\r\n" +
         "If a promise is broken, justice must be wrought in trickery or blood. You aren’t subject to the human rules of mercy.\r\n" +
         "To escape your Darkest Self, you must in some way re-balance the scales of justice.";

      var sexMove =
         "When you lie naked with another, you can ask them for a promise. If they refuse, take 2 Strings on them.";

      var moves = new Moves[]
      {
         new(Skins.Fae, "Faery Contract",
            "If someone breaks a promise or contract made to you, take a String on them.\r\n" +
            "When spending a String to even out the score and get justice on a broken promise, add these options to Pulling Strings:\r\n" +
            "they fuck up something simple at a crucial moment, suffering 1 Harm if appropriate\r\n " +
            "add 2 to your roll on an act of vengeance.")
      };

      var experience = new[]
      {
         "Add +1 to one of your stats", "Take another Fae move", " Take another Fae move", "Take a move from any Skin",
         "Take a move from any Skin", " You belong to a Jury of Fae"
      };

      return _skinBaseFactory.CreateSkinBase(Skins.Fae, description, longDescription,
         names, looks, eyes, origins, stats, backstory, darkestSelf, sexMove, moves, experience
      );
   }
}