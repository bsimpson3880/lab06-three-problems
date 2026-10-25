int choice = 0;
Random rng = new Random(4000);
do
{
    choice = 0;
Console.WriteLine("=== CSCI 1250 Lab 06 ===");
Console.WriteLine("1. The Grade Checker");
Console.WriteLine("2. The Dice Table");
Console.WriteLine("3. The Score Report");
Console.WriteLine("4. All three");
Console.WriteLine("5. Quit");

while (choice < 1 || choice > 5)
{
    Console.Write("Choose 1 through 5: ");
    choice = int.Parse(Console.ReadLine());
    if (choice < 1 || choice > 5)
    {
        Console.WriteLine("Invalid choice. Please try again.");
    }
}

if (choice == 1 || choice == 4)
{
    Console.WriteLine("=== Exercise 1: The Grade Checker ===");
    Console.Write("Score: ");
    int score = int.Parse(Console.ReadLine());
    if (score >= 90 && score <= 100)
    {
        Console.WriteLine("Grade: A");
    }
    else if (score >= 80 && score < 90)
    {
        Console.WriteLine("Grade: B");
    }
    else if (score >= 70 && score < 80)
    {
        Console.WriteLine("Grade: C");
    }
    else if (score >= 60 && score < 70)
    {
        Console.WriteLine("Grade: D");
    }
    else
    {
        Console.WriteLine("Grade: F");
    }
if (score < 0 || score > 100)
        {
            Console.WriteLine("Invalid score. Please enter a score between 0 and 100.");
        }
    
}
if (choice == 2 || choice == 4)
{
    int rollCounter = 1;
    string rollAgain = "y";
    Console.WriteLine("=== Exercise 2: The Dice Table ===");
    do
    {
    int roll1 = rng.Next(1, 7);
    int roll2 = rng.Next(1, 7);
    int total = roll1 + roll2;
    Console.WriteLine("Roll " + rollCounter + ": " + roll1 + " and " + roll2 + ", total " + total + ". " );
    rollCounter++;
    Console.Write("Would you like to roll again? (y/n) ");
    rollAgain = Console.ReadLine();
    
    if (roll1 == 1 && roll2 == 1)
    {
        Console.WriteLine("Snake eyes.");
    }
    else if (roll1 == roll2 && roll1 != 1)
    {
        Console.WriteLine("Doubles!");
    }
    else if (roll1 + roll2 == 7 || roll1 + roll2 == 11)
    {
        Console.WriteLine("WINNER!");
    }
    } while (rollAgain.ToLower() == "y");
}
if (choice == 3 || choice == 4)
{
// exercise 3
}
} while (choice != 5);
Console.WriteLine("Goodbye.");



