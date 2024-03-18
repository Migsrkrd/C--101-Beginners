//Console.WriteLine is used to print the result of the operation to the console.
Console.WriteLine("-----");



//here we are asking the user to enter their name
//Console.Write is used to print the message to the console.
//The difference between Console.Write and Console.WriteLine is that Console.Write does not add a new line after the message.
Console.Write("Enter your name: ");

//Console.ReadLine is used to read the user's input and store it in a variable
//The ? after the string type is used to indicate that the variable can be null.
string? name = Console.ReadLine();

//here we are asking the user to enter their age
Console.Write("Enter your age: ");

//Console.ReadLine is used to read the user's input and store it in a variable
//The ? after the string type is used to indicate that the variable can be null.
string? age = Console.ReadLine();

//Console.WriteLine is used to print the result of the operation to the console.
Console.WriteLine("Hello " + name + ", you are " + age + " years old.");

//Console.ReadLine is used to keep the console window open until the user closes it.
Console.ReadLine();


