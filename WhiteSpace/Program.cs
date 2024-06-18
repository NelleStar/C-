
string firstName = "Bob";
int widgetsPurchased = 7;
// testing a change to the message.
// int widgetsSold = 7;
// Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");


/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}
/*
Take a string - converts to a char array and reverse the letters

Declare variable to count how many times certain letter appears
Count letters in Array

Declare a new String that is the reversed message

Print out both variables
*/
string str = "The quick brown fox jumps over the lazy dog.";

char[] message = str.ToCharArray();
Array.Reverse(message);

int x = 0;

foreach (char letter in message) 
{ 
  if (letter == 'o') 
    { 
      x++; 
    }
}

string new_message = new String(message);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");