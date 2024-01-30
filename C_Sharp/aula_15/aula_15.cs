int[] scores = [97, 92, 81, 60];

IEnumerable<int> scoreQuery = 
    from score in scores
    where score > 80
    select score;
foreach (int i in scoreQuery)
{
    Console.Write(i + " ");
}
Console.WriteLine();
int l = 0;
while (l < scores.Length)
{
    if(scores[l] > 90)
    {
        Console.WriteLine($"Found a score greater than 90: {scores[l]}");
    }
    l++;
}