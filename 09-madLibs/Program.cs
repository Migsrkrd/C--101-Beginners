// here we establish the variables
string color, pluralNoun, celebrity;

//here we are asking the user to enter a color
Console.Write("Enter a color: ");

//Console.ReadLine is used to read the user's input and store it in a variable
color = Console.ReadLine();

Console.Write("Enter a plural noun: ");
pluralNoun = Console.ReadLine();

Console.Write("Enter a celebrity: ");
celebrity = Console.ReadLine();

//Console.WriteLine is used to print the result of the operation to the console.
Console.WriteLine("Roses are " + color);
Console.WriteLine(pluralNoun + " are blue");
Console.WriteLine("I love " + celebrity);

//Console.ReadLine is used to keep the console window open until the user closes it.
Console.ReadLine();
