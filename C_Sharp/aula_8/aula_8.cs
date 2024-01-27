float a = 36.7F;
// O "float" serve para guardar um número decimal. Só consegue armazenar se colocarmos um "F" no fim do número.
double b = 49.5;
// O "double" é como "long" mas para para o "float". Não precisa de nenhuma letra no fim do número.
double c = a + b;
Console.WriteLine($"The answer for this is {c}.");

decimal d = 36.7M;
decimal e = 49.5M;
decimal f = d + e;
// O decimal serve para arredondar o número. Só consegue arredondar se colocarmos um "M" no fim do número.
Console.WriteLine($"The answer for this is {f}.");