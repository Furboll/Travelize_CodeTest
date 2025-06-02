using System.Globalization;

Console.WriteLine("Member Registration");
	while (true)
	{
		Console.WriteLine("Enter Name or press ENTER to quit.");
		var nameInput = Console.ReadLine();

		if (string.IsNullOrEmpty(nameInput))
		{
	        Console.WriteLine("Exiting member registration...");
		    break;
		}

		try
		{
			ValidateNameInput(nameInput);

			Console.WriteLine("Enter birthdate (yyyy-MM-dd)");
			var birthdateInput = Console.ReadLine();

			var isCorrect = DateTime.TryParseExact(birthdateInput, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birthdate);
			if (!isCorrect)
			{
				throw new FormatException("Invalid birthdate format. Please use yyyy-MM-dd.");
			}

			ValidateAgeIsCorrect(birthdate);
			SaveRegistratedMembers(nameInput, birthdate);
		}
		catch (Exception e)
		{
			Console.WriteLine($"And error has been thrown: {e.Message}\n");
		}
	}
Console.WriteLine("Added members have been saved to file. Shutting down...");

static void ValidateNameInput(string? nameInput)
{
	if (nameInput.Length < 5)
		throw new ArgumentException("Name must be at least 5 characters long.");
}
static void ValidateAgeIsCorrect(DateTime birthdate)
{
	int currentYear = DateTime.Now.Year;
	int birthYear = birthdate.Year;
	int memberYear = currentYear - birthYear;
	if (memberYear < 15)
		throw new ArgumentException($"The user you are trying to add is {memberYear} years old. Members must be at least 15 years old.");
}
static void SaveRegistratedMembers(string name, DateTime birthdate)
{
	///Will be saved int he bin folder
	var filePath = "members.txt";
	
	using (StreamWriter sw = new StreamWriter(filePath, append: true))
    {
        sw.WriteLine($"{name}\t{birthdate:yyyy-MM-dd}");
        Console.WriteLine("Member has been saved!");
	}
}