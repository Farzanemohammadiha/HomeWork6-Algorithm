using Practice.Task1;
using Practice.Task10;
using Practice.Task2;
using Practice.Task3;
using Practice.Task4;
using Practice.Task5;
using Practice.Task6;
using Practice.Task7;
using Practice.Task8;
using Practice.Task9;
using Practice.Task6;



Console.WriteLine("****************************FirstTask***********************************");


Console.Write("Enter number: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Fibonacci:");
Console.WriteLine(Fibonacci.Calculate(n));


Console.WriteLine("****************************SecondTask***********************************");



Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());
bool result = Aval.IsAval(number);
Console.WriteLine(result);





Console.WriteLine("*****************************ThirdTask***********************************");




int[] numbers = { 1, 2, 3, 2, 4, 5, 6, 1 };
int result1 = LISequence.Find(numbers);
Console.WriteLine(result1);




Console.WriteLine("******************************FourthTask**********************************");


int[] numbers1 = { 2, 7, 11, 15 };
int target = 9;
bool result2 = Jam.HasPair(numbers1, target);
Console.WriteLine(result2);



Console.WriteLine("*******************************FifthTask*************************************");


Console.Write("Enter number: ");

int number2 = int.Parse(Console.ReadLine());
string result3 = NumberToWords.Convert(number2);
Console.WriteLine(result3);




Console.WriteLine("*******************************SixthTask*************************************");


Console.Write("Enter text: ");

string text = Console.ReadLine();
char? result4 = AvalinHarfMonhaserbefard.Find(text);
if (result4 == null)
{
    Console.WriteLine("-1");
}
else
{
    Console.WriteLine(result4);
}



Console.WriteLine("*******************************SeventhTask*************************************");

Console.Write("Enter number: ");
int number3 = int.Parse(Console.ReadLine());
int result5 = RInteger.Reverse(number3);
Console.WriteLine(result5);





Console.WriteLine("******************************EighthTask**************************************");


int[] numbers2 = { 10, 2, 5, 3 };
bool result6 = Triangle.CanbeTriangle(numbers2);
Console.WriteLine(result6);


Console.WriteLine("******************************ninethTask**************************************");

Console.Write("Enter parentheses: ");
string input = Console.ReadLine();
bool result7 = Parentheses.IsValid(input);
Console.WriteLine(result);


Console.WriteLine("******************************TenthTask**************************************");

int[] numbers3 = { -10, -10, 5, 2 };
int result8 = MaxOfThree.Find(numbers3);
Console.WriteLine(result8);