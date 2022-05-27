

Console.WriteLine("Hello, World!");
int number;
Console.Write("Guess the number from 1 to 10: ");
number = Convert.ToInt32(Console.ReadLine());
Random random = new Random();
var randomNumber = random.Next(1, 11);


Console.WriteLine($"Your number is: {number}");
if(number == randomNumber)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Your guess is correct :)");
    Console.ResetColor();
} else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Your quess is not correct! Random number is: {randomNumber}");
    Console.ResetColor();
}
Console.ReadKey();
