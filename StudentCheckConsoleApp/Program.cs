Console.Write("What is your first name: ");
string? firstName = Console.ReadLine();

bool isValidAge;
int age;

do
{
	Console.Write("What is your age: ");
	string? ageText = Console.ReadLine();

	isValidAge = int.TryParse(ageText, out age);

	if ( !isValidAge )
	{
		Console.WriteLine("That is not a valid age; please try again.");
	}
} while ( !isValidAge );

Console.WriteLine();

if ( firstName.ToLower() == "bob" || firstName.ToLower() == "sue" )
{
	Console.WriteLine("Welcome Professor!");
}
else if ( age >= 21 )
{
	Console.WriteLine($"Welcome {firstName}!");
}
else
{
	int yearsToWait = 21 - age;
	Console.WriteLine($"You should wait {yearsToWait} years to start this class.");
}

Console.ReadLine();
