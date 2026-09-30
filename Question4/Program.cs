//Write a program that checks if a given year is a leap year. A year is a leap year if:
//It is divisible by 4 e.g.the result of a modulus operation is 0But not divisible by 100
//Or alternatively it is also divisible by 400

//Ask the user to enter a year.
Console.WriteLine("Please enter a year:");
int yearEntered = Convert.ToInt32(Console.ReadLine());

if (int.TryParse(Console.ReadLine(), out int year))
{
    //Check if the year is a leap year.
    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
    {
        Console.WriteLine($"{year} is a leap year.");
    }
    else
    {
        Console.WriteLine($"{year} is not a leap year.");
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid integer for the year.");
}