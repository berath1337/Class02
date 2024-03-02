Console.WriteLine("Welcome to the number swapper application.\nInput the first number:");
var firstNum = Console.ReadLine();
Console.WriteLine("Input the second number:");
var secondNum = Console.ReadLine();

int parsedFirstNum = int.Parse(firstNum);
int parsedSecondNum = int.Parse(secondNum);


Console.WriteLine($"After Swapping:\nFirst Number: {parsedSecondNum}");
Console.WriteLine($"Second Number: {parsedFirstNum}");
