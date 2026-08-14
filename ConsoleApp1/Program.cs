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

// Random num = new Random();
// int num1 = num.Next(1,7);
// int num2 = num.Next(1,7);
// int num3 = num.Next(1,7);
// int total = num1 + num2 + num3;

// Console.WriteLine($"Num roll: {num1} + {num2} + {num3}: {total}");

// if ((num1 == num2) || (num2 == num3) || (num3 == num1))
// {
//     Console.WriteLine("Congrats you rolled Doubles! Double or Nothing");
//     total += 2;
// }
// if ((num1 == num2) && (num2 == num3))
// {
//     Console.WriteLine("Congrats you rolled Triples! Tripled Fun");
//     total += 3;
// }
// if (total > 15)
// {
//     Console.WriteLine("Congrats you win");
//     Console.WriteLine($"Double or Nothing? \n Your total is:  {total}");
// }
// if (total < 15 )
// {
//     Console.WriteLine("You Lose, hahaha fatass");
//     Console.WriteLine($"Gamble your life away \n Your total is: {total}");
// }

// module challenge - if else block

// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0; // will continue tommorow haha!

// if (daysUntilExpiration == 0)
// {
//     Console.WriteLine("Your subscription has expired.");
// }
// else if (daysUntilExpiration == 1)
// {
//     Console.WriteLine("Your subscription expires within a day!");
//     discountPercentage = 20;
// }
// else if (daysUntilExpiration <= 5)
// {
//     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
//     discountPercentage = 10;
// }
// else if (daysUntilExpiration <= 10)
// {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }
// if (discountPercentage > 0)
// {
//     Console.WriteLine($"Renew now and save {discountPercentage}%.");
// }
// arrays - big mind

// string[] fraudulentOrderIDs = new string[3];
// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";

// string[] fraudulentOrderIDs = [ "A123lo", "B456", "C789"];

// Console.WriteLine($"first: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");
// fraudulentOrderIDs[0] = "dragunuv";
// Console.WriteLine($"first: {fraudulentOrderIDs[0]} \n");
// Console.WriteLine($"how many orders do i have: {fraudulentOrderIDs.Length}");

// int[] inventory = {100, 200, 300, 400};
// int sum = 0;

// foreach (int inv in inventory)
// {
//     sum += inv;
//     Console.WriteLine($"Total is: {sum}");
// }


// string[] fraudOrders = {"B123", "C234", "A345","C15", 
// "B177", "G3003", "G3003", "B179"};
 
//  foreach (string id in fraudOrders)
// {
//     if (id.StartsWith("B"))
//     {
//         Console.WriteLine($"{id}");
//     }
// }

// int[] orderIds = [100, 200, 300, 400, 500];
// int sum = 0;
// int idNum = 0;
// foreach(int id in orderIds)
// {
//     sum += id;
//     idNum++;
//     Console.WriteLine($"Id number {idNum}, total is {sum}");
// }
// Console.WriteLine($"total is {sum}");

//guided project using foreach, if to process array data logic
// initialize variables - graded assignments 
// Student         Grade

// Sophia          95.8    A
// Andrew          91.2    A-
// Emma            90.4    A-
// Logan           93      A
// Becky           94.8    A
// Chris           93.4    A
// Eric            93.4    A
// Gregor          94.6    A
// Press the Enter key to continue
//desired output above

//guided project
 
int currentAssignments = 5;

int[] sophia = [90, 91, 92, 93, 94];
int[] emma = [81, 82, 83, 84, 85];
int[] andrew = [86, 87, 88, 89, 90];
int[] logan = [75, 76, 77, 78, 79];

string[] currentName = ["sophia", "emma", "andrew", "logan"];
int[] studentScores = new int[10];
string currentGrade = "";

Console.WriteLine("Student \t Grades");
foreach (string name in currentName)
{
    string currentStudent = name;
    if(currentStudent == "sophia")
    {
        studentScores = sophia;   
    } 
    else if (currentStudent == "emma")
    {
        studentScores = emma;
    }
    else if (currentStudent == "andrew")
    {
        studentScores = andrew;
    }
    else if (currentStudent == "logan")
    {
        studentScores = logan;
    }

    int sumStudentScores = 0;
    decimal studentAvg = 0;

    foreach (int score in studentScores)
    {
        sumStudentScores += score;
    }

    studentAvg = (decimal) sumStudentScores / currentAssignments;

    if (studentAvg >= 97)
    {
        currentGrade = "A+";
    } 
    else if (studentAvg >= 90)
    {
        currentGrade = "A";
    }
    else if (studentAvg >= 85)
    {
        currentGrade = "B+";
    } 
    else if (studentAvg >= 80)
    {
        currentGrade = "B";
    }
    else if (studentAvg >= 75)
    {
        currentGrade = "palakol umay";
    }



    Console.WriteLine($"{currentStudent} \t\t {studentAvg} \t {currentGrade}");
}

