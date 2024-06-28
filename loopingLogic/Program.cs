// Random random = new Random();

// int current = 0;

// do
// {
//   current = random.Next(1, 11);
//   Console.WriteLine(current);
// } while (current != 7);

// Random random = new Random();

// int current = random.Next(1, 11);
// while (current >= 3)
// {
//   Console.WriteLine(current);
//   current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");


// Random random = new Random();

// int current = random.Next(1, 11);
// do
// {
//   current = random.Next(1, 11);

//   if (current >= 8) continue;

//   Console.WriteLine(current);
// } while (current != 7);

Random random = new Random();

int hero = 10;
int monster = 10;

int attack = random.Next(1, 11);

do{
  attack = random.Next(1, 11);
  monster -= attack;  

  Console.WriteLine($"Hero attacked for: {attack} - Monster health: {monster} - Hero health: {hero}");

  if (monster > 0) 
  {
    attack = random.Next(1, 11);
    hero -= attack;  

  Console.WriteLine($"Uh Oh! Monster attacked for: {attack} - Monster health: {monster} - Hero health: {hero}");
  };

  if (monster > 0) continue;

} while (monster >= 0 && hero >= 0);

if (hero >= monster)
{
  Console.WriteLine("Hero Wins!");
}
else
{
  Console.WriteLine("Hero Lost!");
}

string? readIntResult;
bool validIntEntry = false;
int result = 0;

Console.WriteLine("Enter a whole number between 5 - 10.");
do
{
  readIntResult = Console.ReadLine();
  if (readIntResult != null)
  {
    validIntEntry = int.TryParse(readIntResult, out result);
    if (!validIntEntry || result > 10 || result < 5) 
    {
      validIntEntry = false;
      Console.WriteLine("Please type a whole number between 5 and 10.");
    }
  }
} while (!validIntEntry);
// ========================================================

string? readStringResult;
bool validStringEntry = false;


Console.WriteLine("Please enter your role name(Administrator, Manager, User).");
do{
  readStringResult = Console.ReadLine();
  if(readStringResult != null) 
  {
    if(readStringResult.Trim().ToLower() != "adminstrator" && readStringResult.Trim().ToLower() != "manager" && readStringResult.Trim().ToLower() != "user")
    {
      Console.WriteLine($"The role you entered {readStringResult} is not valid. Enter your role name (Administrator, Manager, or User).");
    }
    else
    {
      validStringEntry = true;
      Console.WriteLine($"Your input value ({readStringResult}) has been accepted.");
    }
  }
} while (!validStringEntry);

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

int periodLocation;

foreach (string myString in myStrings)
{
  string tempString = myString;

  periodLocation = tempString.IndexOf(".");
}