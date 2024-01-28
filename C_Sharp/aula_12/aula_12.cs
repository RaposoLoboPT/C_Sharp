var names = new List<string> { "Tiago", "Scott", "David", "Lucas" };
names.Add("Rafael");
names.Remove("Lucas");
foreach (var name in names)
{
    Console.WriteLine($"Hello {name}!");
}
// O "foreach" serve para repetir um bloco de código para cada elemento de uma lista. new List<t> serve para criar uma nova lista. O "Add" serve para adicionar um elemento na lista. O "Remove" serve para remover um elemento da lista.