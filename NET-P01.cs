using System;
//topico 03
class Problema03
{
    static void Main()
    {
        double valorDouble = 12.345;
        int valorInteiro = (int)valorDouble;
        Console.WriteLine($"Valor double: {valorDouble}");
        Console.WriteLine($"Valor inteiro após conversão: {valorInteiro}");
    }
}
//topico 04
class Problema04
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

//topico 05

class Problema05
{
    static void Main()
    {
        // Variáveis
        int a = 5;
        int b = 8;

        // Verificar se 'a' é maior que 'b'
        if (a > b)
        {
            Console.WriteLine($"{a} é maior que {b}");
        }
        else
        {
            Console.WriteLine($"{a} não é maior que {b}");
        }
    }
}


