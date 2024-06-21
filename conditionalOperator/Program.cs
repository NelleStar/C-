int saleAmount = 1001;
int discount = saleAmount > 100 ? 100 : 50;

Console.WriteLine($"Discount: {discount}");

Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine($"You got {(flip == 0 ? "Heads" : "Tails")}");

string permission = "Manager";
int level = 16;

/*
contains Admin >55 == "Welcome, Super Admin user."
contains Admin <=55 == "Welcome, Admin user."
contains Manager >=20 == "Contact an Admin for access."
contains Manager <20 || does not contain Admin or Manager== "You do not have sufficient privileges."
*/

if(permission.Contains("Admin")) 
{
  Console.WriteLine(level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user.");
}
else
{
  Console.WriteLine(level >= 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.");
}