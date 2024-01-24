string firstFriend = "Scott";
string secondFriend = "David";
string friends = $"My friend is {firstFriend} and {secondFriend}.";
Console.WriteLine(friends);
Console.WriteLine(friends.Replace("Scott", "Tiago"));
// O "Replace()" troca uma parte da string por outra, como acontece.
Console.WriteLine(friends);
Console.WriteLine(friends.Contains("Scott"));
// O "Contains()" diz se em uma string tem uma parte referida, devolvendo uma resposta booleana ("True" ou "False").
Console.WriteLine(friends.ToUpper());
// O "ToUpper()" torna a string em Maiúsculas.
Console.WriteLine(friends.ToLower());
// O "ToLower()" torna a string em Minúsculas.
Console.WriteLine(friends.Length);
// O "Length" conta o numero de caracteres da string.
Console.WriteLine(friends.StartsWith("My"));
// O "StartsWith()" diz se a string começa com a parte referida, também devolvendo uma resposta booleana.