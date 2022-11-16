using System.Diagnostics.Metrics;

string biggest = "dkd";

string smallest = "kd";
int counter=0;

for(int i = 0; i < biggest.Length-1; i++)
{
	for (int j = 0; j < smallest.Length-1; j++)
	{
		while(biggest[i] == smallest[j] )
		{
			counter++;
		}
	}
}

if(counter== smallest.Length)
{
	Console.WriteLine("var");
}




