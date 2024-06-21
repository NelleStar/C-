
// bool flag = true;
// int value = 0;

// if(flag)
// {
//   int value2 = 1;
//   value += value2;
//   Console.WriteLine($"Inside the code block: {value}");
// }
// value = 10;
// Console.WriteLine($"Outside the code block: {value}");

// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// int total = 0;

// foreach( int number in numbers) 
// {  
//   total += number;

//   if (number == 42) {
//     Console.WriteLine("Set contains 42");
//   }
// }
// Console.WriteLine($"Total: {total}");

// int employeeLevel = 201;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel)
// {
//   case 100:
//     title = "Junior Associate";
//     break;
//   case 200:
//     title = "Associate";
//     break;
//   case 300:
//     title = "Senior Associate";
//     break;
//   case 400:
//     title = "Manager";
//     break;
//   default:
//     title = "Employee";
//     break;
// }

// Console.WriteLine($"{employeeName}, {title}");

string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
  case "01":
    type = "Sweatshirt";
    break;
  case "02":
    type = "T-Shirt";
    break;
  case "03":
    type = "Sweatpants";
    break;
  default:
    type = "Other";
    break;
}

switch (product[1])
{
  case "BL":
    color = "Black";
    break;
  case "MN":
    color = "Maroon";
    break;
  default:
    color = "White";
    break;
}

switch(product[2])
{
  case "S":
    size = "Small";
    break;
  case "M":
    size = "Medium";
    break;
  case "L":
    size = "Large";
    break;
  default:
    size = "OSFA";
    break;
}

Console.WriteLine($"Product: {size} {color} {type}");