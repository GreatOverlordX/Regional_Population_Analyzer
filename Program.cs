string[] regionNames = { "Region 1", "Region 2", "Region 3", "Region 4", "Region 5", "Region 6", "Region 7" };

/* 
	Assuming you have multiple arrays containing populations for each region  
	Largest to smallest
*/
int[] region1Population = { 5000000, 3000000, 2000000, 1000000 };
int[] region2Population = { 6000000, 5000000, 4000000, 3000000, 1000000 };
int[] region3Population = { 5000330, 4004300, 3000090, 2000200, 530000 };
int[] region4Population = { 8000000, 5000000, 3000000, 900000, 123400 };
int[] region5Population = { 5203400, 3100300, 2200000, 1150000 };
int[] region6Population = { 7000000, 4000000, 2000000, 900000 };
int[] region7Population = { 3000000, 2000000, 1000000, 600000 };

foreach (string region in regionNames)
{
	Console.WriteLine($"Summing up populations for {region}:");
	int totalPopulation = 0;
  	int count = 0; // Initialize counter

  	/* 
		Assuming you have a function to get the population array based on region name 
		*/
  	int[] regionalPopulation = GetPopulationArray(region);

	  foreach (int population in regionalPopulation)
  	{
    	if (count < 25) // Stop adding after 25 elements
    	{
      	totalPopulation += population;
    	}
    	count++;
  	}
  	Console.WriteLine($"\tTotal population of top 25 cities:{totalPopulation}");
}

/*
 This function should return the population array based on the region name (replace with your logic as you please)
*/
int[] GetPopulationArray(string region)
{
	if (region == "Region 1")
	{
	  return region1Population;
	}
	else if (region == "Region 2")
	{
	  return region2Population;
	}
	else if (region == "Region 3")
	{
		return region3Population;
	}
	else if (region == "Region 4")
	{
		return region4Population;
	}
	else if (region == "Region 5")
	{
		return region5Population;
	}
	else if (region == "Region 6")
	{
		return region6Population;
	}
	else if (region == "Region 7")
	{
		return region7Population;
	}
	else
	{
	  return null; // Handle cases where the region doesn't exist
	}
}

string outro_message = "\n\tWow! That's a lot of people\n\n";
string quit_message = "\tPress Enter to exit :)";
var quit_txt = quit_message;
var goodbye_txt = outro_message;
Console.WriteLine(goodbye_txt + quit_txt);
Console.ReadLine();