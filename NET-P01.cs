using System;
//topico 01
class Program
{
    static void Main()
    {
        double valorDouble = 12.345;
        int valorInteiro = (int)valorDouble;
        Console.WriteLine($"Valor double: {valorDouble}");
        Console.WriteLine($"Valor inteiro após conversão: {valorInteiro}");
    }
}
//topico 02
class Program
{
    static void Main()
    {
        // Variáveis
        int x = 10;
        int y = 3;

        // Adição
        int soma = x + y;
        Console.WriteLine($"Adição: {x} + {y} = {soma}");

        // Subtração
        int subtracao = x - y;
        Console.WriteLine($"Subtração: {x} - {y} = {subtracao}");

        // Multiplicação
        int multiplicacao = x * y;
        Console.WriteLine($"Multiplicação: {x} * {y} = {multiplicacao}");

        // Divisão
        // A divisão de dois inteiros resulta em um quociente inteiro
        int divisaoInteira = x / y;
        Console.WriteLine($"Divisão (inteira): {x} / {y} = {divisaoInteira}");

        // Se desejar o resultado com parte fracionária, converta pelo menos um dos operandos para double
        double divisaoReal = (double)x / y;
        Console.WriteLine($"Divisão (real): {x} / {y} = {divisaoReal}");
    }
}
