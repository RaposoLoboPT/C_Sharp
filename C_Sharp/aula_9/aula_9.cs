Console.Write("Enter a number: ");
int a = int.Parse(Console.ReadLine());
// O Console.ReadLine() serve para pedir uma entrada do usário. O int.Parse() serve para transformar uma string em um inteiro, mas também podemos usar o double, o bool entre outros.
Console.Write("Enter another number: ");
int b = int.Parse(Console.ReadLine());
if ((a + b) >= 10) 
{
    Console.WriteLine("The answer is greather than 10.");
} // O "if" serve para dizer se algo é verdadeiro.
else
{
    Console.WriteLine("The answer is less than 10.");
} // O "else" serve para dizer se algo é falso.
Console.Write("Enter a third number: ");
int c = int.Parse(Console.ReadLine());
if ((a + b + c) >= 15 && (a == b)) // O "&&" serve para dizer se as duas condicões são verdadeiras. O "||" serve para dizer se pelo menos uma das condicões é verdadeira. O "!" serve para inverter o valor da condição. O "==" serve para dizer se o valor da esquerda e do valor da direita são iguais.
{
    Console.WriteLine("The answer is greather than 15.");
    Console.WriteLine("And the first number is equal to the second.");
}
else
{
    Console.WriteLine("The answer is less than 15.");
    Console.WriteLine("Or the first number is not equal to the second.");
}