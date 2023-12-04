// See https://aka.ms/new-console-template for more information
using ricksGuitars_start;

Inventory inventory = new Inventory();
initializeInventory(inventory);

Guitar whatErinLikes = new Guitar("", 0, "fender", "Stratocastor",
                                  "electric", "Alder", "Alder");
Guitar guitar = inventory.Search(whatErinLikes);
if (guitar != null)
{
    Console.WriteLine("Erin, you might like this " +
      guitar.GetBuilder() + " " + guitar.GetModel() + " " +
      guitar.GetTypee() + " guitar:\n   " +
      guitar.GetBackWood() + " back and sides,\n   " +
      guitar.GetTopWood() + " top.\nYou can have it for only $" +
      guitar.GetPrice() + "!");
}
else
{
    Console.WriteLine("Sorry, Erin, we have nothing for you.");
}

static void initializeInventory(Inventory inventory)
{
    inventory.AddGuitar("11277", 3999.95M, "Collings", "CJ", "acoustic",
                        "Indian Rosewood", "Sitka");
    inventory.AddGuitar("V95693", 1499.95M, "Fender", "Stratocastor", "electric",
                        "Alder", "Alder");
    inventory.AddGuitar("V9512", 1549.95M, "Fender", "Stratocastor", "electric",
                        "Alder", "Alder");
    inventory.AddGuitar("122784", 5495.95M, "Martin", "D-18", "acoustic",
                        "Mahogany", "Adirondack");
    inventory.AddGuitar("76531", 6295.95M, "Martin", "OM-28", "acoustic",
                        "Brazilian Rosewood", "Adriondack");
    inventory.AddGuitar("70108276", 2295.95M, "Gibson", "Les Paul", "electric",
                        "Mahogany", "Maple");
    inventory.AddGuitar("82765501", 1890.95M, "Gibson", "SG '61 Reissue",
                        "electric", "Mahogany", "Mahogany");
    inventory.AddGuitar("77023", 6275.95M, "Martin", "D-28", "acoustic",
                        "Brazilian Rosewood", "Adirondack");
    inventory.AddGuitar("1092", 12995.95M, "Olson", "SJ", "acoustic",
                        "Indian Rosewood", "Cedar");
    inventory.AddGuitar("566-62", 8999.95M, "Ryan", "Cathedral", "acoustic",
                        "Cocobolo", "Cedar");
    inventory.AddGuitar("6 29584", 2100.95M, "PRS", "Dave Navarro Signature",
                        "electric", "Mahogany", "Maple");
}
