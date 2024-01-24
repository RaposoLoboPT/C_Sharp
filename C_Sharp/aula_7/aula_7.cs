int a = 2100000000;
int b = 2100000000;
// O "int" serve para guardar um número inteiro. Só consegue armazenar até 2100000000.
long c = (long)a + (long)b;
// O long seve para colocar números maiores de 2100000000. Não esquecer de converter o "int" para "long".
Console.WriteLine(c);