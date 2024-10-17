
public class Inventory
{
    public List<Item> items = new();


    public void Display()
    {
        for (int i = 1; i < items.Count; i++)
        {
        Console.WriteLine($" {items[i].Name}");
        }
    }   
}
