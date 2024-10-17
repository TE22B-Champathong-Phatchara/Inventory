public class Consumable : Item
{
  public int UsesMax;
  public int UsesCurrent;

  public void Use(Chararacter target)
  {
      if (UsesCurrent > 0)
      {
        target.Hp += 25;
        UsesCurrent--;
      }
  }
}
