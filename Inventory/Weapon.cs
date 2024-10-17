
public class Weapon : Item
{
    public int MinAtk;
    public int MaxAtk;

    public int Attak()
    {
        return Random.Shared.Next(MinAtk, MaxAtk);
    }
}