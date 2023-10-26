List<int> input1 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
List<int> input2 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

List<int> output = new List<int>();

int longerCount = Math.Max(input1.Count, input2.Count);

for (int i = 0; i < longerCount; i++)
{
    if (i < input1.Count)
    {
        output.Add(input1[i]);
    }
    
    if (i < input2.Count)
    {
        output.Add(input2[i]);
    }
    
}

Console.WriteLine(string.Join(" ", output));