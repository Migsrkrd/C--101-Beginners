// \n is used to create a new line
Console.WriteLine("new Line"+"Giraffe\nAcademy");
Console.WriteLine("---------------------");

//concatenation is used to combine strings
Console.WriteLine("Concatenation: "+"Giraffe" + "Academy");
Console.WriteLine("---------------------");

//you can store a string in a variable
string phrase = "Giraffe Academy";
Console.WriteLine("phrase variable: "+phrase);
Console.WriteLine("---------------------");

//you can use a method to change the case of a string
//Here we use the ToLower method to change the string to all lower case
Console.WriteLine("ToLower: "+phrase.ToLower());
//Here we use the ToUpper method to change the string to all upper case
Console.WriteLine("ToUpper: "+phrase.ToUpper());
Console.WriteLine("---------------------");

//you can use a method to get the length of a string
Console.WriteLine("phrase length:" + phrase.Length);
Console.WriteLine("---------------------");

//you can use a method to find a character or a sequence of characters in a string
//Here we use the Contains method to find a sequence of characters
Console.WriteLine("Contains: "+phrase.Contains("Academy"));
Console.WriteLine("---------------------");

//you can use a method to get a substring of a string
//Here we use the Substring method to get a substring of the string
//The first parameter is the index of the first character of the substring
//The second parameter is the length of the substring
Console.WriteLine("Substring: " + phrase.Substring(8, 3));
Console.WriteLine("---------------------");

//you can use a method to get a character at a specific index
//Here we use the IndexOf method to get the index of the first occurrence of a character
Console.WriteLine( "IndexOf: " +phrase.IndexOf('a'));
//or you could use [] to get the character at a specific index
Console.WriteLine("phrase[8]: "+phrase[8]);
Console.WriteLine("---------------------");

//to find more methods, go to the C# documentation and search for string methods at https://docs.microsoft.com/en-us/dotnet/api/system.string?view=net-5.0
