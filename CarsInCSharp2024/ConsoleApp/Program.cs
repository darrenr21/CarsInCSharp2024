//Show menu

Console.WriteLine("Welcome to Jeremy's Dealership");
Console.WriteLine("");
Console.WriteLine("-----------------");
Console.WriteLine("1. Add a new car");
Console.WriteLine("2. List all cars");
Console.WriteLine("3. Remove a car ");
Console.WriteLine("4. Exit");
string userInput = "";
try
{
    userInput = Console.ReadLine();
    userInput = int.Parse(usersInput);
} catch (Exception ex)
{
}
switch (userInput)
{
    case 0:
        break;
    case 1:
        Console.WriteLine("Add a new car");
        break;
    case 2:
        Console.WriteLine("List all cars");
        break;
    case 3:
        Console.WriteLine("Remove a car");
        break;
}