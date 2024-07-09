Console.Title = "Packing Inventory";
Console.Clear();

public class Pack
{
    public InventoryItem[] Items {get; set;}
    public int MaxItems {get; set;}
    public double MaxWeight {get; set;}
    public double MaxVolume {get; set;}
    public int CurrentCount { get; set; }
    public double CurrentVolume { get; set; }
    public double CurrentWeight { get; set; }
    public Pack(int maxItems, double maxWeight, double maxVolume)
    {
        Items = new InventoryItem[maxItems];
        MaxItems = maxItems;
        MaxWeight = maxWeight;
        MaxVolume = maxVolume;
    }

    public bool Add(InventoryItem item)
    {
        double currentWeight = 0;
        double currentVolume = 0;

        foreach (var x in Items)
        {
            currentVolume += item.Volume;
            currentWeight += item.Weight;
            
        }

        if (currentWeight + item.Weight > MaxWeight ||
            currentVolume + item.Volume > MaxVolume ||
            Items.Length >= MaxItems) 
        {
            return false;
        }

        for (int i = 0; i < Items.Length; i++)
        {
            if (Items[i] == null)
            {
                Items[i] = item;
                CurrentCount++;
                CurrentVolume += item.Volume;
                CurrentWeight += item.Weight;
                return true;
            }
        }
        return false;
    }
}

public class InventoryItem
{
    public double Weight { get; set; }
    public double Volume { get; set; }

    public InventoryItem(double weight, double volume)
    {
        Weight = weight;
        Volume = volume;
    }
    
}

public class Arrow : InventoryItem
{
    public Arrow() : base(0.1, 0.05){}
}
public class Bow : InventoryItem
{
    public Bow() : base(1.0, 4.0){}
}
public class Rope : InventoryItem
{
    public Rope() : base(1.0, 1.5){}
}
public class Water : InventoryItem
{
    public Water() : base(2.0, 3.0){} 
}
public class Food : InventoryItem
{
    public Food() : base(1.0, .5){}
}
public class Sword : InventoryItem
{
    public Sword() : base(5.0, 3.0){}
}












