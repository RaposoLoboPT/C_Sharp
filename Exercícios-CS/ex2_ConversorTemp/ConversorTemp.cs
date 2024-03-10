// Vamos criar um convertor de temperatura de celsius para fahrenheit e vice-versa.
Console.WriteLine("Diga para que tipo de temperatura deseja converter (Celsius ou Fahrenheit): ");
var TempType = Console.ReadLine();
Console.WriteLine("Diga a temperatura que deseja converter: ");
var TempValue = double.Parse(Console.ReadLine());
if (TempType.ToLower() == "celsius")
{
    double celsius = (TempValue - 32) / 1.8;
    Console.WriteLine($"A temperatura em celsius é: {celsius}");
}
else if (TempType.ToLower() == "fahrenheit")
{
    double fahrenheit = TempValue * 1.8 + 32;
    Console.WriteLine($"A temperatura em fahrenhit é: {fahrenheit}");
}
else
{
    Console.WriteLine("[ERROR] Temperatura inválida");
}