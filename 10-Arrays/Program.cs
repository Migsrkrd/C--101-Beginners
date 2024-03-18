//yoo can create an array of any type of data
//array syntax is written with square brackets at the end of the data type, and then the name of the array, followed by the data you want to store in the array inside curly brackets
//you can create an array of strings like this
string[] colors = { "red", "blue", "green", "yellow" };

//you can create an array of integers like this
int[] numbers = { 1, 2, 3, 4, 5 };

//you can alter the values of an array like this
numbers[1] = 8;

//you can create an array of booleans like this
bool[] booleans = { true, false, true, false };

Console.WriteLine("colors: " + colors[2]);
Console.WriteLine("numbers: " + numbers[1]);
Console.WriteLine("booleans: " + booleans[0]);

//to print all data in an array, you can use a for loop
for (int i = 0; i < colors.Length; i++)
{
    Console.Write(colors[i] + " ");
}

// or you can use a foreach loop
foreach (int number in numbers)
{
    Console.Write(number + " ");
}

Console.ReadLine();
