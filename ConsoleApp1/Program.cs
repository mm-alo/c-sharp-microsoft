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
 
// int currentAssignments = 5;

// int[] sophia = [90, 91, 92, 93, 94];
// int[] emma = [81, 82, 83, 84, 85];
// int[] andrew = [86, 87, 88, 89, 90];
// int[] logan = [75, 76, 77, 78, 79];

// string[] currentName = ["sophia", "emma", "andrew", "logan"];
// int[] studentScores = new int[10];
// string currentGrade = "";

// Console.WriteLine("Student \t Grades");
// foreach (string name in currentName)
// {
//     string currentStudent = name;
//     if(currentStudent == "sophia")
//     {
//         studentScores = sophia;   
//     } 
//     else if (currentStudent == "emma")
//     {
//         studentScores = emma;
//     }
//     else if (currentStudent == "andrew")
//     {
//         studentScores = andrew;
//     }
//     else if (currentStudent == "logan")
//     {
//         studentScores = logan;
//     }

//     int sumStudentScores = 0;
//     decimal studentAvg = 0;

//     foreach (int score in studentScores)
//     {
//         sumStudentScores += score;
//     }

//     studentAvg = (decimal) sumStudentScores / currentAssignments;

//     if (studentAvg >= 97)
//     {
//         currentGrade = "A+";
//     } 
//     else if (studentAvg >= 90)
//     {
//         currentGrade = "A";
//     }
//     else if (studentAvg >= 85)
//     {
//         currentGrade = "B+";
//     } 
//     else if (studentAvg >= 80)
//     {
//         currentGrade = "B";
//     }
//     else if (studentAvg >= 75)
//     {
//         currentGrade = "palakol umay";
//     }


//     Console.WriteLine($"{currentStudent} \t\t {studentAvg} \t {currentGrade}");
// }

//module challenge
// Student         Exam Score      Overall Grade   Extra Credit

// Sophia          92.2            95.88   A       92 (3.68 pts)
// Andrew          89.6            91.38   A-      89 (1.78 pts)
// Emma            85.6            90.94   A-      89 (5.34 pts)
// Logan           91.2            93.12   A       96 (1.92 pts)
// output

// int[] sophia = [90, 86, 87, 98, 100];
// int[] emma = [92, 89, 81, 96, 90];
// int[] andrew = [ 90, 85, 87, 98, 68];
// int[] logan = [90, 95, 87, 88, 96];
// double[] examScore = [92.2, 89.6, 85.6, 91.2];

// string[] currentStudent = ["sophia", "emma", "andrew", "logan"];
// int[] studentScore =  new int[10];
// double currentExamScore = 0;

// Console.WriteLine("Student \t Exam Score \t Overall Grade \t \t Extra Credit \n");

// foreach (string name in currentStudent)
// {
//     string currentName = name;
//     if(currentName == "sophia")
//     {
//         studentScore = sophia;
//         currentExamScore = examScore[0];
//     }
//     else if (currentName == "emma")
//     {
//         studentScore = emma;
//         currentExamScore = examScore[1];
//     }
//     else if (currentName == "andrew")
//     {
//         studentScore = andrew;
//         currentExamScore = examScore[2];
//     }
//     else if (currentName == "logan")
//     {
//         studentScore = logan;
//         currentExamScore = examScore[3];
//     }


//     int sumScore = 0;
//     decimal scoreAvg = 0;
//     decimal extraCredit = 0;
//     decimal OverallGrade = 0;

//     foreach (int score in studentScore)
//     {
//         sumScore += score;
//     }
   
//     extraCredit =  sumScore * .10m / 5;
//     scoreAvg = (decimal) sumScore / 5;
//     OverallGrade = (decimal) (sumScore + extraCredit) / 5;

//     Console.WriteLine($"{currentName} \t\t {currentExamScore} \t\t {OverallGrade} \t\t {scoreAvg} ({extraCredit})");
// }

// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// string myValue1 = "A ";

// Console.WriteLine(myValue.ToLower().Trim() == myValue1.ToLower().Trim());
// string pangram = "A quick brown fox jumps over the lazy dog";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(!pangram.Contains("cow"));

//conditional operation
// int saleAmount = 1001;
// int discount = saleAmount > 1002 ? 100 : 50;
// evaluate the first condition "saleAmount > 1000" if it's true return ? 100 and if false : return 50

// Console.WriteLine($"discount: {(saleAmount > 1000 ? 100 : 50)}");

// module challenge coin flip
// Random flip = new Random();
// int coin = flip.Next(1,3);
// Console.WriteLine($"Result: {(coin == 1 ? "Heads" : "Tails")} ");

// string permission = "Admin | Managaer";
// int level = 10;

// if (permission.Contains("Admin") && level > 55)
// {
//     Console.WriteLine("Welcome, Super Admin.");
// } 
// else if(permission.Contains("Admin") && level <= 55)
// {
//     Console.WriteLine("Welcome, Admin user.");

// }
// else if (permission.Contains("Manager") && level >= 20)
// {
//     Console.WriteLine("Contact admin for Access");
// } 
// else if (permission.Contains("Manager") && level < 20)
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }
// else
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }

// bool flag = true;
// if (flag)
// {
//     int value = 10;
//     Console.WriteLine($"Inside the code block {flag}");
// }
// Console.WriteLine($"Outside the code block {flag}");

// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// int total = 0;
// bool found = false;

// foreach (int number in numbers)
// {
//     if (number == 42)
//     {
//         found = true;
//         if (found)
//         {
//             Console.WriteLine("Set Contains 42");
//         }
//     }
//     total += number;
// }
// Console.WriteLine($"Total: {total}");

// int employeeLevel = 0;
// string employeeName = "Emmanuel Alo";

// string employeeTitle = "";

// switch (employeeLevel)
// {
//     case 100:
//     employeeTitle = "CEO";
//     break;

//     case 200:
//     employeeTitle = "Vice President";
//     break;

//     case 300:
//     employeeTitle = "Manager";
//     break;

//     default:
//     employeeTitle = "Section Leader";
//     break;
// }
// Console.WriteLine($"{employeeName}: {employeeTitle}");

// for iterations loop


// for (int i = 1; i < 101; i++)
// {
//     if ((i % 3 == 0) && (i % 5 == 0))
//         Console.WriteLine($"{i} - FizzBuzz");
//     else if (i % 3 == 0)
//         Console.WriteLine($"{i} - Fizz");
//     else if (i % 5 == 0)
//         Console.WriteLine($"{i} - Buzz");
//     else
//         Console.WriteLine($"{i}");
// }

// Random attack = new Random();
// int heroHealth = 10;
// int monsterHealth = 10;

// do
// {
//     int monsterAttack = attack.Next(1,6);
//     heroHealth -= monsterAttack;
//     Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroHealth} health");

//     if(heroHealth <= 0) continue;

//     int heroAttack = attack.Next(1,6);
//     monsterHealth -= heroAttack;
//     Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterHealth} health");

// } while (heroHealth > 0 && monsterHealth > 0);

// Console.WriteLine(heroHealth > monsterHealth ? "Hero wins" : "Monster wins");

string? readResults;
bool isValid = false;
Console.WriteLine("Enter a string need atleast 3 characters");

do
{
    readResults = Console.ReadLine();
    if (readResults.Length > 3)
    {
        Console.WriteLine("Valid input");
        isValid = true;
        continue;
    } else if (readResults.Length < 3)
    {
        Console.WriteLine("Invalid input");
    }

} while (isValid == false);