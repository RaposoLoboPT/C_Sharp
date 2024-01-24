string firstFriend = "Scott";
string secondFriend = "David";
// A "string" serve para guarda uma string.
Console.WriteLine($"My friend is {firstFriend} and {secondFriend}.");
// Aqui foi usada uma interpolação, já que foi usado um sifrão antes da string.

// O "trim" serve para retir os espaços a mais da string.
firstFriend = "      Scott      ";
firstFriend = firstFriend.TrimStart();
// O "TrimStart" serve para retirar os espaços a mais do começo da string.

secondFriend = "      David      ";
Console.WriteLine($"My friend is {firstFriend.TrimEnd()} and {secondFriend}.");
// O "TrimEnd" serve para retirar o espaço a mais do fim da string. Ambas as formas funcionam da mesma forma.