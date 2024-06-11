//create new instance of System.Random and store the reference to object in a variable named dice
Random dice = new Random();

//call Random.Next() on dice object 3 times with an upper and lower bounds to restrict the possible values - save to individual variables
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

// sum 3 rolls into one variable
int total = roll1 + roll2 + roll3;

//.WriteLine() t display using string interpolation
Console.WriteLine($"Dice Roll: {roll1} {roll2} {roll3} = {total}");

// write logic if 2 dice match - compound condition - 
// add 2 to total
if(roll1 == roll2 || roll2 == roll3 || roll1 == roll3) 
{
  // write logic for triples game feature
  if(roll1 == roll2 && roll2 == roll3)
  {
    Console.WriteLine("You rolls triples! +6 bonus to total!");
    total += 6;
  }
  else
  {
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
  }
  
}


// if logic to handle different scenarios - will update as we learn else
// if keyword - (boolean expression) - {code block}
if (total >= 16)
{
  Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
  Console.WriteLine("You win a new laptop!");
}
else if (total == 10)
{
  Console.WriteLine("You win a trip for two!");
}
else
{
  Console.WriteLine("You win a kitten!");
}

// //Bool example of true
// string message = "The quick brown fox jumps over the lazy dog.";
// bool result = message.Contains("dog");
// Console.WriteLine(result);

// if (message.Contains("fox"))
// {
//   Console.WriteLine("What does the fox say?");
// }