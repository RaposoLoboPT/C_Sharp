var names = new string[] { "Tiago", "Scott", "David", "Rafael"};
// O "new string[]" é um array de strings, que serve para criar uma estrutura de dados para armazenar elementos do mesmo tipo. Os arrays são fixos.
names = [..names,"Anyone"];
// É assim que se adiciona um elemento ao array.
foreach (var name in names)
{
    Console.WriteLine($"Hello {name}!");
}