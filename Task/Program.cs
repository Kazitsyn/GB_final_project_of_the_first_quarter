string [] primer1 = {"hello", "2", ":-)"};
string [] primer2 = {"1234", "1567", "computer science"};
string [] primer3 = {"Russia", "Demmark", "Kazan"};


int count = 0;
foreach (string item in primer1)
{
    if (item.Length <= 3)
    {
        count++;
    } 
    
} 

string[] result = new string[count];
int index = 0;

for (int i = 0; i < primer1.Length; i++)
{
    if (primer1[i].Length <= 3) 
    {
        result[index] = primer1[i];
        index++;
    }
}

for (int i = 0; i < result.Length; i++)
{
    if (i == 0)
    {
        Console.Write($"[{result[i]}, ");
    }
    else if (i< result.Length-1)
    {
        Console.Write($"{result[i]}, ");
    }
    else 
    {
        Console.Write($"{result[i]}]");
    }
}
