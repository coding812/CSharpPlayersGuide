Console.Title = "Packing Inventory";
Console.Clear();

Pack pack = new Pack(10, 10, 10);

while (true)
{
    Console.WriteLine($"Pack is currently at {pack.CurrentVolume}/{pack.MaxVolume} volume, {pack.CurrentWeight}/{pack.MaxWeight} weight, and {pack.CurrentItems}/{pack.MaxItems} items.");
    Console.WriteLine(pack.ToString);
    Console.WriteLine("What would you like to add to your pack? ");
    Console.WriteLine("Enter 1 for an Arrow");
    Console.WriteLine("2 for Bow");
    Console.WriteLine("3 for Rope");
    Console.WriteLine("4 for Water");
    Console.WriteLine("5 for Food");
    Console.WriteLine("6 for Sword");

    int userInput = Convert.ToInt32(Console.ReadLine());
    
    InventoryItem item = userInput switch
    {
        1 => new Arrow(),
        2 => new Bow(),
        3 => new Rope(),
        4 => new Water(),
        5 => new Food(),
        6 => new Sword(),
    };

    
    if (!pack.Add(item))
    {
        Console.WriteLine("Too to add at this time.");
    }
    
}


public class Pack
{
    public InventoryItem[] Items {get; set;}
    public int MaxItems {get; set;}
    public double MaxWeight {get; set;}
    public double MaxVolume {get; set;}
    public int CurrentItems { get; set; }
    public double CurrentVolume { get; set; }
    public double CurrentWeight { get; set; }
    public Pack(int maxItems, double maxWeight, double maxVolume)
    {
        Items = new InventoryItem[maxItems];
        MaxItems = maxItems;
        MaxWeight = maxWeight;
        MaxVolume = maxVolume;
    }
    public override string ToString()
    {
        return this.ToString();
    }

    public bool Add(InventoryItem item)
    {
        if (CurrentWeight + item.Weight > MaxWeight ||
            CurrentVolume + item.Volume > MaxVolume ||
            CurrentItems >= MaxItems)
        {
            return false;
        }

        Items[CurrentItems] = item;
        CurrentItems++;
        CurrentVolume += item.Volume;
        CurrentWeight += item.Weight;
        return true;
    }
}

public class InventoryItem
{
    public double Weight { get; }
    public double Volume { get; }

    public InventoryItem(double weight, double volume)
    {
        Weight = weight;
        Volume = volume;
    }
    
}

public class Arrow : InventoryItem
{ 
    public Arrow() : base(0.1, 0.05) {} 
    public override string ToString()
    {
        return this.ToString();
    }
}
public class Bow : InventoryItem 
{ 
    public Bow() : base(1.0, 4.0) { } 
    public override string ToString()
    {
        return this.ToString();
    }
}
public class Rope : InventoryItem 
{ 
    public Rope() : base(1.0, 1.5) { } 
    public override string ToString()
    {
        return this.ToString();
    }
}
public class Water : InventoryItem 
{ 
    public Water() : base(2.0, 3.0) { } 
    public override string ToString()
    {
        return this.ToString();
    }
}
public class Food : InventoryItem 
{ 
    public Food() : base(1.0, .5) { }
    public override string ToString()
    {
        return this.ToString();
    } 
}
public class Sword : InventoryItem 
{ 
    public Sword() : base(5.0, 3.0) { } 
    public override string ToString()
    {
        return this.ToString();
    }
}



