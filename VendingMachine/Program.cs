vendingMachine v = new vendingMachine();
v.populate();
v.getList();

public class Item{
    private string name;
    private double price;
    private string location;
    private int quantity;

    public Item(string name, double price, string location, int quantity = 1){
        this.name = name;
        this.price = price;
        this.location = location;
        this.quantity = quantity;
    }

    private double totalValue(){
        return quantity * price;
    }

    public void showItem(){
        Console.WriteLine($"{name} - {price} - {location} Qty: {quantity}");
        Console.WriteLine($"Total Value: {totalValue()}");
    }
}

public class vendingMachine{
    
    private List<Item> items = new List<Item>();

    public vendingMachine(){
        Console.WriteLine("I'm a vending machine");
    }

    public void populate(){
        items.Add(new Item("Doritos", 2.5, "A1"));
        items.Add(new Item("Gummies", 0.75, "A2"));
        items.Add(new Item("Animal Crackers", 5.0, "A3"));
    }

    public void getList(){
        Console.WriteLine("Items in vending machine");
        foreach(Item item in items){
            item.showItem();
        }
    }
}