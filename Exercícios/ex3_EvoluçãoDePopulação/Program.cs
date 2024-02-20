// Vou criar um sistema para saber a TN a TM e a TCE 
Console.WriteLine("Diga o número de residentes da população desta analíse:");
var pa = double.Parse(Console.ReadLine());
if (pa <= 0)
{
    Console.WriteLine("[ERROR] população invalida");
}
else
{
    Console.WriteLine("Diga o número da nados-vivos da população desta analíse:");
    var n = double.Parse(Console.ReadLine());
    Console.WriteLine("Diga o número de óbitos da população desta analíse:");
    var m = double.Parse(Console.ReadLine());
    Console.WriteLine("Diga o número de imigrantes da população desta analíse:");
    var i = double.Parse(Console.ReadLine());
    Console.WriteLine("Diga o número emigrantes da população desta analíse:");
    var e = double.Parse(Console.ReadLine());
    var tn = 0.0;
    var tm = 0.0;
    var tce = 0.0;
    if (pa >= 1000)
    {
        tn = n / pa * 1000;
        Console.WriteLine($"A Taxa de Natalidade é {tn}‰.");
        tm = m / pa * 1000;
        Console.WriteLine($"A Taxa de Mortalidade é {tm}‰.");
        tce = ((n - m) + (i - e)) / pa * 1000;
        Console.WriteLine($"A Taxa de Crescimento Efetivo é {tce}‰.");
    }
    else if (pa < 1000)
    {
        tn = n / pa * 100;
        Console.WriteLine($"A Taxa de Natalidade é {tn}%.");
        tm = m / pa * 100;
        Console.WriteLine($"A Taxa de Mortalidade é {tm}%.");
        tce = (n - m) + (i - e) / pa * 100;
        Console.WriteLine($"A Taxa de Crescimento Efetivo é {tce}%.");
    }
}