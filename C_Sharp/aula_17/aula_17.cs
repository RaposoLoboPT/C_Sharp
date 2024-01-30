int[] scores = [97, 92, 81, 100, 78, 60];

var scoreQuery = scores.Where(s => s > 80).OrderByDescending(s => s);
// Esta é outra forma de fazer o LINQ
List<int> myScores = scoreQuery.ToList();
foreach (var scr in myScores)
{
    Console.WriteLine(scr);
}