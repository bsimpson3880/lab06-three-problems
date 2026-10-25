/*
* Name: Bryce Simpson
* Course: CSCI 1250, Section 001
* Assignment: Lab 06, Three Short Problems
* Date: October 21, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/

int choice = 0;
Random rng = new Random(4000);
//The body must run once before the question can be asked
do
{
    choice = 0;
Console.WriteLine("=== CSCI 1250 Lab 06 ===");
Console.WriteLine("1. The Grade Checker");
Console.WriteLine("2. The Dice Table");
Console.WriteLine("3. The Score Report");
Console.WriteLine("4. All three");
Console.WriteLine("5. Quit");

// The menu loop will continue until the user chooses to quit.
while (choice < 1 || choice > 5)
{
    Console.Write("Choose 1 through 5: ");
    choice = int.Parse(Console.ReadLine());
    if (choice < 1 || choice > 5)
    {
        Console.WriteLine("Invalid choice. Please try again.");
    }
}
//The number of repeats is unknown before the loop starts.
if (choice == 1 || choice == 4)
{
    Console.WriteLine("=== Exercise 1: The Grade Checker ===");
    Console.Write("Score: ");
    int score = int.Parse(Console.ReadLine());
    while (score < 0 || score > 100)
        {
            Console.WriteLine("A score must be between 0 and 100.");
            Console.Write("Score: ");
            score = int.Parse(Console.ReadLine());
        }
    while (score >= 90 && score <= 100)
    {
        Console.WriteLine("Grade: A");
        break;
    }
    while (score >= 80 && score < 90)
    {
        Console.WriteLine("Grade: B");
        break;
    }
    while (score >= 70 && score < 80)
    {
        Console.WriteLine("Grade: C");
        break;
    }
    while (score >= 60 && score < 70)
    {
        Console.WriteLine("Grade: D");
        break;
    }
    while (score < 60 && score >= 0)
    {
        Console.WriteLine("Grade: F");
        break;
    }
}
if (choice == 2 || choice == 4)
{
    int rollCounter = 1;
    int wins = 0;
    string rollAgain = "y";
    Console.WriteLine("=== Exercise 2: The Dice Table ===");
    // The dice rolling loop will continue until the user chooses not to roll again.
    do
    {
    int roll1 = rng.Next(1, 7);
    int roll2 = rng.Next(1, 7);
    int total = roll1 + roll2;
    Console.WriteLine("Roll " + rollCounter + ": " + roll1 + " and " + roll2 + ", total " + total + ". " + (roll1 == 1 && roll2 == 1 ? "Snake eyes." : roll1 == roll2 && roll1 != 1 ? "Doubles!" : roll1 + roll2 == 7 || roll1 + roll2 == 11 ? "WINNER!" : ""));
    if (roll1 + roll2 == 7 || roll1 + roll2 == 11)
    {
        wins++;
    }
    rollCounter++;
    Console.Write("Would you like to roll again? (y/n) ");
    rollAgain = Console.ReadLine();
   
   if (rollAgain.ToLower() == "n")
   {
       Console.WriteLine("You rolled " + rollCounter + " times and won " + wins + " times.");
       break;
   }
    } while (rollAgain.ToLower() == "y");
}
if (choice == 3 || choice == 4)
{
    Console.WriteLine("=== Exercise 3: The Score Report ===");
    int[] scores = new int[5];
    // The loop will continue until all five scores are entered.
    for (int i = 0; i < 5; i++)
    {
        Console.Write("Score " + (i + 1) + ": ");
        scores[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("");
    Console.WriteLine("Scores entered: 5");
    Console.WriteLine("Total: " + (scores[0] + scores[1] + scores[2] + scores[3] + scores[4]));
    double average = (scores[0] + scores[1] + scores[2] + scores[3] + scores[4]) / 5.0;
    Console.WriteLine("Average: " + average);
    Console.WriteLine("Highest: " + scores.Max());
    Console.WriteLine("Passing: " + scores.Count(s => s >= 60) + " out of 5");
}
} while (choice != 5);
Console.WriteLine("Goodbye.");
