// The Math class provides many methods that allow you to perform mathematical tasks on numbers.
int num = 6;

// Math.Abs() returns the absolute value of a number
Console.WriteLine(Math.Abs(num)); // 6
Console.WriteLine("-----");

Console.WriteLine(Math.Pow(num, 2)); // 36
Console.WriteLine("-----");

Console.WriteLine(Math.Sqrt(num)); // 2.449489742783178

// Math.Round() rounds a number to the nearest integer
Console.WriteLine(Math.Round(Math.Sqrt(num))); // 2
Console.WriteLine("-----");

// Math.Floor() rounds a number down to the nearest integer
Console.WriteLine(Math.Floor(Math.Sqrt(num))); // 2
Console.WriteLine("-----");

// Math.Ceiling() rounds a number up to the nearest integer
Console.WriteLine(Math.Ceiling(Math.Sqrt(num))); // 3
Console.WriteLine("-----");

// Math.Max() returns the larger of two numbers
Console.WriteLine(Math.Max(6, 9)); // 9
Console.WriteLine("-----");

// Math.Min() returns the smaller of two numbers
Console.WriteLine(Math.Min(6, 9)); // 6
Console.WriteLine("-----");

// Math.PI returns the value of pi
Console.WriteLine(Math.PI); // 3.141592653589793
Console.WriteLine("-----");

//etc.
//you can find more math operations in the documentation at https://docs.microsoft.com/en-us/dotnet/api/system.math?view=net-6.0