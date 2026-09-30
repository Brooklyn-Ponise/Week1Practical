//Task: Create a C# console application that prints a message to the user asking for their name and age.
//After taking user input, display their name and how old they will be in 5 years.

//Ask user for their name.
Console.WriteLine("Please enter your name:");
string name = Console.ReadLine();

//Ask user for their age.
Console.WriteLine("Please enter your age:");
int age = int.Parse(Console.ReadLine());

// Calculate age in 5 years.
int ageInFiveYears = age + 5;

// Display the result to the user.
Console.WriteLine($"Hello {name}, in 5 years you will be {ageInFiveYears} years of age.");