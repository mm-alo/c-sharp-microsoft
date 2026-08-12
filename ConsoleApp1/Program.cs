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

// string projectName = "ACME";
// string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

// Console.WriteLine("View English output:");
// Console.WriteLine($@"  c:\Exercise\{projectName}\data.txt");
// Console.WriteLine("\n"+ russianMessage + ":");
// Console.WriteLine($"c:\\Exercise\\{projectName}\ru-Ru\\data.txt");

// decimal decimalQuotient = 7.0m / 5;
// Console.WriteLine($"Decimal Qoutient: {decimalQuotient}");

//celcius to farenheit
// int farenheit = 94;
// decimal celcius = farenheit - 32;
// decimal result = celcius *(5/9m);
// Console.WriteLine($"The temperature is {result} Celsius.");


//module assesment student grading system
// int currentAssignments = 5;

// int sophia1 = 93;
// int sophia2 = 87;
// int sophia3 = 98;
// int sophia4 = 95;
// int sophia5 = 100;

// int nicolas1 = 80;
// int nicolas2 = 83;
// int nicolas3 = 82;
// int nicolas4 = 88;
// int nicolas5 = 85;

// int zahirah1 = 84;
// int zahirah2 = 96;
// int zahirah3 = 73;
// int zahirah4 = 85;
// int zahirah5 = 79;

// int jeong1 = 90;
// int jeong2 = 92;
// int jeong3 = 98;
// int jeong4 = 100;
// int jeong5 = 97;

// int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
// int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
// int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
// int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

// decimal sophiaResults = (decimal) sophiaSum / currentAssignments;
// decimal nicolasResults = (decimal) nicolasSum / currentAssignments;
// decimal zahirahResults = (decimal) zahirahSum / currentAssignments;
// decimal jeongResults = (decimal) jeongSum / currentAssignments;

// Console.WriteLine("Student \t Grade\n");
// Console.WriteLine("Sophia: \t" + sophiaResults + " \tA");
// Console.WriteLine("Nicolas: \t" + nicolasResults + " \tB");
// Console.WriteLine("zahirah: \t" + zahirahResults + " \tB");
// Console.WriteLine("jeong: \t\t" + jeongResults + " \tB");


//gpa calculator
//Divide the resulting sum by the total number of credit hours.
// string studentName = "Sophia Johnson";
// string course1Name = "English 101";
// string course2Name = "Algebra 101";
// string course3Name = "Biology 101";
// string course4Name = "Computer Science I";
// string course5Name = "Psychology 101";

// int course1Credit = 3;
// int course2Credit = 3;
// int course3Credit = 4;
// int course4Credit = 4;
// int course5Credit = 3;

// int gradeA = 4;
// int gradeB = 3;

// int course1Grade = gradeA;
// int course2Grade = gradeB;
// int course3Grade = gradeB;
// int course4Grade = gradeB;
// int course5Grade = gradeA;

// int totalCreditHours = 0;
// totalCreditHours += course1Credit;
// totalCreditHours += course2Credit;
// totalCreditHours += course3Credit;
// totalCreditHours += course4Credit;
// totalCreditHours += course5Credit;

// int totalGradePoints = 0;
// totalGradePoints += course1Credit * course1Grade;
// totalGradePoints += course2Credit * course2Grade;
// totalGradePoints += course3Credit * course3Grade;
// totalGradePoints += course4Credit * course4Grade;
// totalGradePoints += course5Credit * course5Grade;

// decimal gradePointAverage = (decimal) totalGradePoints /totalCreditHours;
// int leadingDigit = (int) gradePointAverage;


// Console.WriteLine($"Student: {studentName} \n");
// Console.WriteLine("Course \t \t\tGrade \tCredit Hours");
// Console.WriteLine($"{course1Name}  \t\t{gradeA} \t\t{course1Credit}");
// Console.WriteLine($"{course2Name} \t\t{gradeB} \t\t{course2Credit}");
// Console.WriteLine($"{course3Name} \t\t{gradeB} \t\t{course3Credit}");
// Console.WriteLine($"{course4Name} \t{gradeB} \t\t{course4Credit}");
// Console.WriteLine($"{course5Name} \t\t{gradeA} \t\t{course5Credit}");
// Console.WriteLine($"Final GPA: {gradePointAverage}");

//classes, methods, parameters and arguments
// Random roll = new Random();
// int dice = roll.Next();
// int dice1 = roll.Next(100);
// int dice2 = roll.Next(50,100);

// Console.WriteLine(dice);
// Console.WriteLine(dice1);
// Console.WriteLine(dice2);

// int firstValue = 500;
// int secondValue = 600;
// int largerValue;
// largerValue = Math.Max(firstValue, secondValue);
// Console.WriteLine(largerValue);

Random num = new Random();
int num1 = num.Next(1,7);
int num2 = num.Next(1,7);
int num3 = num.Next(1,7);
int total = num1 + num2 + num3;

Console.WriteLine($"Num roll: {num1} + {num2} + {num3}: {total}");

if ((num1 == num2) || (num2 == num3) || (num3 == num1))
{
    Console.WriteLine("Congrats you rolled Doubles! Double or Nothing");
    total += 2;
}
if ((num1 == num2) && (num2 == num3))
{
    Console.WriteLine("Congrats you rolled Triples! Tripled Fun");
    total += 3;
}
if (total > 15)
{
    Console.WriteLine("Congrats you win");
    Console.WriteLine($"Double or Nothing? \n Your total is:  {total}");
}
if (total < 15 )
{
    Console.WriteLine("You Lose, hahaha fatass");
    Console.WriteLine($"Gamble your life away \n Your total is: {total}");
}