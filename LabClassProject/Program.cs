// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");
//datattypes
//int, float, double, char, string, bool
//variables

Console.WriteLine("Please enter your name:");
string name = Console.ReadLine();
Console.WriteLine("Please enter your address:");
string address = Console.ReadLine();

Console.WriteLine("Greetings " + name + " from " + address);

//int int32 long
Console.WriteLine("Please enter first number:");
string input1 = Console.ReadLine();
int num1 = Convert.ToInt32(input1);

Console.WriteLine("Please enter second number:");
int num2 = Convert.ToInt32(Console.ReadLine());

add(num1, num2);

void add(int a, int b)
{
  int result = a + b;
  Console.WriteLine("Your sum =" + result);
  //
}

//+, -, *, / %
// 7/2 = 3
// 7% 2 = 1

// division