//Vou criar uma calculadora, onde vai ter 3 entradas, uma para o primeiro valor, uma para o segundo valor e uma para escolher a operação e cinco operadores (soma, subtração, multiplicação, divisão e exponenciação).
Console.WriteLine("Diga a operação que será realizada, (Add, Subtract, Multiply, Divide ou exponentiation): ");
var operation = Console.ReadLine();
Console.WriteLine("Diga o primeiro valor da operação: ");
var numb1 = double.Parse(Console.ReadLine());
Console.WriteLine("Diga o segundo valor da operação: ");
var numb2 = double.Parse(Console.ReadLine());
if (operation.ToLower() == "add")
{
    Console.WriteLine($"O resultado da operação é: {numb1 + numb2}");
}
else if (operation.ToLower() == "subtract")
{
    Console.WriteLine($"O resultado da operação é: {numb1 - numb2}");
}
else if (operation.ToLower() == "multiply")
{
    Console.WriteLine($"O resultado da operação é: {numb1 * numb2}");
}
else if (operation.ToLower() == "divide")
{
    if (numb1 == 0 || numb2 == 0)
    {
        Console.WriteLine("[ERROR] Não é possivel dividir por 0!");
    }
    else
    {
        Console.WriteLine($"O resultado da operação é: {numb1 / numb2}");
    }
}
else if (operation.ToLower() == "exponentiation")
{
    Console.WriteLine($"O resultado da operação é: {Math.Pow(numb1, numb2)}");
}
else
{
    Console.WriteLine("[ERROR] Não é possivel realizar esta operação! Por favor, tente novamente!");
}