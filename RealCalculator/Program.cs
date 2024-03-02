Console.WriteLine("Welcome to the console calculator, please enter the first number for the calculation");
var firstNum= Console.ReadLine();
Console.WriteLine("Please enter the second number for calculation");
var secondNum= Console.ReadLine();
Console.WriteLine("Please enter one of the following operators for calculation: * / + -");
var operation= Console.ReadLine();

int parsedFirstNum = int.Parse(firstNum);
int parsedSecondNum = int.Parse(secondNum);



if (operation == "+")
{
    int result = parsedFirstNum + parsedSecondNum;
    Console.WriteLine("The result is: " + result);
}

else if (operation == "-")
{
    int result = parsedFirstNum - parsedSecondNum;
    Console.WriteLine("The result is: " +  result);
    
}

else if (operation == "*")
{
    int result = parsedFirstNum * parsedSecondNum;
    Console.WriteLine("The result is: " + result);
  
}

else if (operation == "/")
{
    int result = parsedFirstNum / parsedSecondNum;
    Console.WriteLine("The result is: " + result);
}

else 
{
    Console.WriteLine("Please enter a valid operator");
}