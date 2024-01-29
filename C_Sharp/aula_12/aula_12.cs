var names = new List<string> { "Tiago", "Scott", "David", "Lucas" };
names.Add("Rafael");
names.Remove("Lucas");
// new List<t> serve para criar uma nova lista. O "Add" serve para adicionar um elemento na lista. O "Remove" serve para remover um elemento da lista.
foreach (var name in names)
{
    Console.WriteLine($"Hello {name}!");
}
// O "foreach" serve para repetir um bloco de código para cada elemento de uma lista.
Console.WriteLine(names[0]);
// O "names[0]" serve para mostrar o elemento da lista na posição 0 (1º).
Console.WriteLine(names[names.Count - 1]);
// O "names.Count" serve para mostrar o número de elementos da lista.
Console.WriteLine(names[^3]);
// O "name[^3]" serve para mostrar se um elemento está na lista a contar do final (seria o scott, porque ainda temos o lucas).