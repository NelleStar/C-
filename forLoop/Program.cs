// for(int i = 0; i <= 5; i++) 
// {
//   Console.WriteLine(i);
// }

// for(int i = 5; i >= 0; i--) 
// {
//   Console.WriteLine(i);
// }

// for(int i = 0; i <= 10; i += 3) 
// {
//   Console.WriteLine(i);
// }

// for(int i = 0; i <= 5; i++) 
// {
//   Console.WriteLine(i);
//   if (i == 3) break;
// }

string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int i = names.Length -1; i >= 0; i--) 
{
  Console.WriteLine(names[i]);  
  if (names[i] == "David") names[i] = "Sammy";

  for (int j = 0; j < names[i].Length; j++)
  {
    Console.WriteLine(names[i][j]);
  }  
}
foreach( var name in names) Console.WriteLine(name);