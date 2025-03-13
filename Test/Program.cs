using System;
using System.Threading;
class Test {
  static void Main() {
    int milliseconds = 1000;
    int end = 2750;
    Console.WriteLine("Enter Name:");
    string name = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Hello, "+name);
    Thread.Sleep(milliseconds);
    Console.WriteLine("Welcome to my math test.");
    Thread.Sleep(milliseconds);
    Console.WriteLine("type 'ok' to begin.");
    string accept = Convert.ToString(Console.ReadLine());
    Thread.Sleep(milliseconds);
    if (accept == "ok") Console.WriteLine("Lets start with an easy question.");
    if (accept != "ok") Console.WriteLine("I SAID TYPE OK!!");
    Thread.Sleep(milliseconds);
    if (accept != "ok") System.Environment.Exit(1);
    Console.WriteLine("5 + 4 = ?");
    double answer1 = Convert.ToDouble(Console.ReadLine());
    if (answer1 == 9) Console.WriteLine("Correct!");
    if (answer1 != 9) Console.WriteLine("Incorrect!");
    if (answer1 == 9) Console.WriteLine("Lets try something a bit more challenging!");
    if (answer1 == 9) Console.WriteLine("23 + 30 = ?");
    double answer2 = Convert.ToDouble(Console.ReadLine());
    if (answer2 == 53) Console.WriteLine("Correct!");
    if (answer2 != 53) Console.WriteLine("Incorrect!");
    if (answer2 == 53) Console.WriteLine("That was good, now lets get into subtraction!");
    if (answer2 == 53) Console.WriteLine("24 - 13 = ?");
    double answer3 = Convert.ToDouble(Console.ReadLine());
    if (answer3 == 11) Console.WriteLine("Correct!");
    if (answer3 != 11) Console.WriteLine("Incorrect!");
    if (answer3 == 11) Console.WriteLine("Now Multiplication!");
    if (answer3 == 11) Console.WriteLine("26*7 = ?");
    double answer4 = Convert.ToDouble(Console.ReadLine());
    if (answer4 == 182) Console.WriteLine("Correct!");
    if (answer4 != 182) Console.WriteLine("Incorrect!");
    if (answer4 == 182) Console.WriteLine("Now Division");
    if (answer4 == 182) Console.WriteLine("56/8");
    double answer5 = Convert.ToDouble(Console.ReadLine());
    if (answer5 == 7) Console.WriteLine("Correct!");
    if (answer5 != 7) Console.WriteLine("Incorrect!");
    if (answer5 == 7) Console.WriteLine("Good Job, " + name);
    if (answer5 == 7) Console.WriteLine("You passed! I hope to see you again sometime!");
    Thread.Sleep(end);
    }
}