Console.WriteLine("Hello!");
Console.WriteLine("Input the first number:");
string userInput = Console.ReadLine();
int firstNumber = int.Parse(userInput);

Console.WriteLine("Input the second number:");
userInput = Console.ReadLine();
int secondNumber = int.Parse(userInput);

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");
userInput = Console.ReadLine();

if (userInput == "a" || userInput == "A")
{
    Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
} 
else if (userInput == "s" || userInput == "S")
{
    Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
}
else if (userInput == "m" ||  userInput == "M")
{
    Console.WriteLine($"{firstNumber} x {secondNumber} = {firstNumber * secondNumber}");
}
else
{
    Console.WriteLine("Invalid option");
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();