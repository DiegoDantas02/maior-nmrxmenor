using System;

class ComparadorDeNumeros
{
    static void Main(string[] args)
    {
        int numero1, numero2;

        Console.Write("Digite o primeiro número: ");
        numero1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        numero2 = int.Parse(Console.ReadLine());

        if (numero1 > numero2)
        {
            Console.WriteLine("O maior número é " + numero1 + " e o menor número é " + numero2);
        }
        else if (numero2 > numero1)
        {
            Console.WriteLine("O maior número é " + numero2 + " e o menor número é " + numero1);
        }
        else
        {
            Console.WriteLine("Os números são iguais: " + numero1);
        }
    }
}
