//Prompt the user to enter an integer.
//Use an if-else statement to check if the number is positive, negative, or zero.
//Print the appropriate message based on the condition.

//Ask user to enter an integer.
Console.WriteLine("Hello, please enter an integer:");
int number = Convert.ToInt32(Console.ReadLine());

//Check if the number is positive, negative, or zero.
if (number > 0)
{
    Console.WriteLine("The number is positive.");
}
else if (number < 0)
{
    Console.WriteLine("The number is negative.");
}
else
{
    Console.WriteLine("The number is zero.");
}
