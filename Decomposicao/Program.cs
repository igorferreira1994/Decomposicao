using Decomposicao.Model;
using System;

public class Decom
{
    public static void Main(string[] args)
    {
        Decompor decompor = new Decompor();
        Console.Write("Digite um número: ");
        long numero = Convert.ToInt64(Console.ReadLine());

        GerarDivisores(numero, decompor);
        GerarPrimos(decompor);
        TransformarString(decompor);
        ImprimirResultados(numero, decompor);
    }

    public Decompor RetornoCalculoApi(int numero)
    {
        Decompor decompor = new Decompor();
        GerarDivisores(numero, decompor);
        GerarPrimos(decompor);
        TransformarString(decompor);
        ImprimirResultados(numero, decompor);
        return decompor;
    }

    public static void GerarDivisores(long numero, Decompor decompor)
    {
        decompor.Divisores = new List<int>();

        for (int j = 2; j <= numero / 2; j++)
        {
            if (numero % j == 0)
            {
                decompor.Divisores.Add(j);
            }
        }
    }

    public static void GerarPrimos(Decompor decompor)
    {
        decompor.Primos = new List<int>();
        foreach (var item in decompor.Divisores)
        {
            bool primo = true;
            for (int i = item / 2; i > 1; i--)
            {
                if (item % i == 0)
                {
                    primo = false;
                }
            }
            if (primo)
                decompor.Primos.Add(item);
        }
    }
    public static void TransformarString(Decompor decompor)
    {
        foreach (var item in decompor.Divisores)
            decompor.DivisoresStr += item + " ";

        foreach (var item in decompor.Primos)
            decompor.PrimosStr += item + " ";
    }        

    public static void ImprimirResultados(long numero, Decompor decompor)
    {
        Console.WriteLine("Número de Entrada: " +numero);
        Console.WriteLine("Números divisores: " + decompor.DivisoresStr);
        Console.WriteLine("Divisores Primos: " +decompor.PrimosStr);
    }
}