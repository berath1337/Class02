Console.WriteLine("Data Types");
//Whole numbers
int firstIntVariable = 5555; // declaration and initialization
Console.WriteLine("firstIntVariable: " + firstIntVariable);//concatenation

short firstShortVariable = 6;
Console.WriteLine($"firstShortVariable: {firstShortVariable} firstIntVariable:{firstIntVariable}!"); //interpolation

long firstLongVariable = 222;
Console.WriteLine($"firstLongVariable: " + firstLongVariable );

//decimal numbers

float firstFloatVariable = 6.3f;
Console.WriteLine("First float variable: " + firstFloatVariable);

double firstDoubleVariable = 58.6;
Console.WriteLine("First double variable: " + firstDoubleVariable);

char firstCharVariable = '*';
Console.WriteLine("The first char variable: " +  firstCharVariable);

string message = "Hello from qinshift academy";
Console.WriteLine("First string: " + message);

string singleCharacterString = "a"; //we can have only one character in string, the number of character is not limited
//char multipleCharactersChar = 'ab' is not allowed

bool firstBooleanVariable = true;
bool secondBool = false;
Console.WriteLine("First boolean variable: " + firstBooleanVariable + $" second Boolean variable: {secondBool}");

int number; //declaration
number = 5;//initalization
number = 10;//reinitalization
//number = "hello"; outputs error

//implicitly typed variables take the type of the value that is first given to the variable!

var secondNumber = 8; //int secondNumber = 8;

DateTime date = DateTime.Now;
Console.WriteLine("Today's date is : " + date.DayOfWeek);

//Operators
int sum = 5 + 5;
Console.WriteLine("sum of 5+5: " + sum);

sum += 90;
Console.WriteLine("sum:" + sum);

//Console.WriteLine("a: " + a); cannot use a here
int a;
//Console.WriteLine("a: " + a); still cannot use a here

a = 2;

Console.WriteLine("a: " + a); //we can use a now

sum++;
int secondSum = sum;
Console.WriteLine(secondSum);//we can use the value of another variable if it is from the same type


