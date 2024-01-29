var numbers = new List<int> { 14, 38, 56, 40, 29, 71,65};
numbers.Sort();
// O "Sort" serve para ordenar uma lista de elementos.
Console.WriteLine($"I found 29 at index:{numbers.IndexOf(29)}");
// O "IndexOf" serve para mostrar o indice de um elemento na lista.
foreach (var number in numbers)
{
    Console.WriteLine($"Look at {number}!");
}
