// string[] fraudulentOrderIDs = new string[3];

// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";


// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"Reassigned First: {fraudulentOrderIDs[0]}");

// string[] initializedArray = { "A123", "B234", "C345", "D456" };

// Console.WriteLine($"First: {initializedArray[0]}");
// Console.WriteLine($"Second: {initializedArray[1]}");
// Console.WriteLine($"Third: {initializedArray[2]}");

// Console.WriteLine($"There are {initializedArray.Length} orders to process.");

// string[] names = { "Harry", "Hermione", "Ron", "Luna" };
// foreach (string name in names)
// {
//   Console.WriteLine($"Welcome to Hogwarts, {name}.");
// }

// int[] inventory = { 200, 450, 700, 175, 250 };
// int sum = 0;
// int bin = 0;

// foreach(int items in inventory) {
//   bin++;
//   sum += items;

//   Console.WriteLine($"Bin #{bin} = {items} items. Running Total: {sum}");
// }

string[] fraudOrderIdData = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach(string id in fraudOrderIdData) {
  if(id.StartsWith("B")) {
    Console.WriteLine(id);
  }
}
