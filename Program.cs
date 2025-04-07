string userName = "John Doe";
int userAge = 0;
string userAddress = "Seattle, WA";

Console.WriteLine("Enter your name:");
userName = Console.ReadLine();
Console.WriteLine("Enter your age:");
userAge = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your address:");
userAddress = Console.ReadLine();

Console.WriteLine("Name: " + userName);
Console.WriteLine("Age: " +  userAge);
Console.WriteLine("Address: " +  userAddress);