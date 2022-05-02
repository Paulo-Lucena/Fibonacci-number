using System.Globalization;
using System.Diagnostics;


DateTime dataInicial = DateTime.Now;

double fibo(double x)
{
    if (x > 1)
    {
        return fibo(x - 1) + fibo(x - 2);
    }

    return x;
}

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(fibo(i));
};

DateTime dataFinal = DateTime.Now;

TimeSpan resultado = dataFinal - dataInicial;
Console.WriteLine($"Resultado {resultado.TotalMilliseconds.ToString(CultureInfo.InvariantCulture)} Milliseconds");




