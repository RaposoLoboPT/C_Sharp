int[] scores = [97, 92, 81, 100, 78, 60];

IEnumerable<string> scoreQuery = 
    from score in scores
    // O "from" serve para dizer de onde vem os elementos.
    where score > 80
    // O "where" serve para filtrar o elemento.
    orderby score descending
    // O "orderby" serve para ordenar os elementos.
    select $"The score greater than 80 is: {score}";
    // O "select" serve para selecionar o elemento. Podes fazer alterações nesse elemento. Exemplo: select numero * 2 (dobro).
foreach (string i in scoreQuery)
{
    Console.WriteLine(i);
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