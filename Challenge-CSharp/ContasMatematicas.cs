namespace Challenge01;

public class OperacoesMatematicas
{
    public void Somar(int valor1, int valor2)
    {
        var resultado = valor1 + valor2;

        Console.WriteLine("A soma é " + resultado);
    }

    public void Subtrair(int valor1, int valor2)
    {
        var resultado = valor1 - valor2;

        Console.WriteLine("A diferença é " + resultado);
    }

    public void Multiplicar(int valor1, int valor2)
    {
        var resultado = valor1 * valor2;

        Console.WriteLine("A multiplicação é " + resultado);
    }

    public void Dividir(int valor1, int valor2)
    {
        var resultado = valor1 / valor2;

        Console.WriteLine("A divisão é " + resultado);
    }

    public void Media(int valor1, int valor2)
    {
        var resultado = (valor1 + valor2) / 2;

        Console.WriteLine("A média é " + resultado);
    }
}