// using math operations with strings will concatenate them instead of performing the operation
Console.WriteLine("43" + "56");
Console.WriteLine("------");

//this will throw an error because you cannot perform math operations with strings
//you can see we are trying to add a string to a number variable
//C# is a strongly typed language, so you cannot perform operations with different types of variables

//comment out the line below to see the error

// int num = "43";
// Console.WriteLine(num);

//however, you can convert a string to a number using the Convert class
//Convert.ToInt32() converts a string to an integer
int num = Convert.ToInt32("43");
Console.WriteLine(num);
Console.WriteLine("------");

//Convert.ToDouble() converts a string to a double
double num2 = Convert.ToDouble("43.56");
Console.WriteLine(num2);
Console.WriteLine("------");

//Convert.ToString() converts a number to a string
string num3 = Convert.ToString(43);
Console.WriteLine(num3);
Console.WriteLine("------");

// ---------------------------------------------------------------------------------

//Calculator

//Here is a basic calculator that takes two numbers as input and adds them together
//run this in the console and enter whole numbers to see the result

Console.Write("Enter a number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter another number: ");
int num4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num1 + num4);

Console.ReadLine();

//however there is one problem, the result will not accept decimal numbers
//comment out the next section to see the correction by using Convert.ToDouble() instead of Convert.ToInt32()

// ---------------------------------------------------------------------------------

//Here is the corrected version of the calculator that accepts decimal numbers

// Console.Write("Enter a number: ");
// double num5 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Enter another number: ");
// double num6 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine(num5 + num6);

// Console.ReadLine();