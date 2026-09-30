//ask: Create a program that takes an integer as input and determines whether it is even or odd.
//Requirements:
//Use if-else statements to check the parity of the number.
//Provide appropriate messages for even and odd numbers.

//Ask the user to enter an integer.
Console.WriteLine("Please enter an integer:");

//Read the input and convert it to an integer.
int number = Convert.ToInt32(Console.ReadLine());

//Check if the number is even or odd using if-else statements.
if (number % 2 == 0)
{
    Console.WriteLine($"{number} is an even number.");
}
else
{
    Console.WriteLine($"{number} is an odd number.");
}
