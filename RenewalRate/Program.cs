Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration <= 10)
{
  if (daysUntilExpiration <= 5)
  {
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days. Renew now and save {discountPercentage}%");
  }
  Console.WriteLine("Your subscriptionwillexpire soon. Renew now!");
}

