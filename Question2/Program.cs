//Task: Create a C# console application that takes in a user's age.
//Using if-else statements and conditional operators, determine whether they are a child,
//teenager or adult and display the result to the console.
//Ensure that the program handles invalid input (eg an age that is outside the 0-110 range).

Console.WriteLine("Please enter your age:");
    int age = Convert.ToInt32(Console.ReadLine());

if (age <0 || age >110)
    {
    Console.WriteLine("Invalid age. Enter an age between 0 & 110.");
}
else if (age < 13)
{
    Console.WriteLine("You are a child.");
}
else if (age < 20)
{
    Console.WriteLine("You are a teenager.");
}
else
{
    Console.WriteLine("You are an adult.");
}



