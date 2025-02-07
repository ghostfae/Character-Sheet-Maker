namespace Monsterhearts;

public record Stats(int hot, int cold, int vol, int dark)
{
   public int Hot = hot;
   public int Cold = cold;
   public int Volatile = vol;
   public int Dark = dark;
}