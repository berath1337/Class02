Console.WriteLine("Welcome to the average number calculator. \nPlease enter the first number for calculation:");
var firstNum = Console.ReadLine();
Console.WriteLine("Please enter the second number for calculation:");
var secondNum = Console.ReadLine();
Console.WriteLine("Please enter the third number for calculation:");
var thirdNum = Console.ReadLine();
Console.WriteLine("Please enter the fourth number for calculation:");
var fourthNum = Console.ReadLine();

int parsedFirstNum = int.Parse(firstNum);
int parsedSecondNum = int.Parse(secondNum);
int parsedThirdNum = int.Parse(thirdNum);
int parsedFourthNum = int.Parse(fourthNum);

var result = (parsedFirstNum + parsedSecondNum + parsedThirdNum + parsedFourthNum) / 4;

Console.WriteLine($"The average of {parsedFirstNum}, {parsedSecondNum}, {parsedThirdNum} and {parsedFourthNum} is: {result}");