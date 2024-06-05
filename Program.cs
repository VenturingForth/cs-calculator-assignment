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

if (EqualsCaseInsensitive(userInput, "A"))
{
    int sum = firstNumber + secondNumber;
    PrintFinalEquation(firstNumber, secondNumber, sum, "+");
} 
else if (EqualsCaseInsensitive(userInput, "S"))
{
    int difference = firstNumber - secondNumber;
    PrintFinalEquation(firstNumber, secondNumber, difference, "-");
}
else if (EqualsCaseInsensitive(userInput, "M"))
{
    int multiplied = firstNumber * secondNumber;
    PrintFinalEquation(firstNumber, secondNumber, multiplied, "x");
}
else
{
    Console.WriteLine("Invalid option");
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();

void PrintFinalEquation(
    int number1, int number2, int result, string @operator)
{
    Console.WriteLine(
        $"{number1} {@operator} {number2} = {result}");
}

bool EqualsCaseInsensitive(string left, string right)
{
    return left.ToUpper() == right.ToUpper();
}