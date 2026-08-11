// string firstName;
// firstName = "bob";
// Console.WriteLine(firstName);

// var age = 15;
// Console.WriteLine(age);

// string name = "Bob";
// int numberMessages = 3;
// float degrees = 34.4f;

// Console.Write("Hello, "  +  name + "! " + "You have " + numberMessages + " messages in your inbox."+ 
// " The temperature is " + degrees + " celcius.");

//escape sequences
// Console.WriteLine("Hello \"World\" !");

// Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
// Console.WriteLine("Invoice: 1021 \t Complete!");
// Console.WriteLine("Invoice: 1022 \t Complete! \n");
// Console.Write("Output Directory: \t");

//verbatim string literals
// Console.Write(@" c\invoices");

//string concatenation
// string firstName = "Bob";
// string message = "Hello" + firstName;
// Console.WriteLine("\n\n"+message);

//string interpolation
// string firstName = "bob";
// string message = $"hello {firstName}";
// Console.WriteLine(message);

//challenge for string interpolation and verbatim string literals

string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine("View English output:");
Console.WriteLine($@"  c:\Exercise\{projectName}\data.txt");
Console.WriteLine("\n"+ russianMessage + ":");
Console.WriteLine($"c:\\Exercise\\{projectName}\ru-Ru\\data.txt");