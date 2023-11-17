using System;
//os topicos 01 e 02 são discorridos ao serem feitos os topicos 03 ao 08.
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

//topico 06
class Problema06
{
    static void Main()
    {
        // Strings
        string str1 = "Hello";
        string str2 = "World";

        // Verificar se as strings são iguais usando o método Equals
        bool saoIguais = str1.Equals(str2);

        // Ou você pode usar o operador ==
        // bool saoIguais = (str1 == str2);

        // Exibir o resultado
        if (saoIguais)
        {
            Console.WriteLine("As strings são iguais.");
        }
        else
        {
            Console.WriteLine("As strings são diferentes.");
        }
    }
}

//topico 07 

class Problema07
{
    static void Main()
    {
        // Variáveis booleanas
        bool condicao1 = true;
        bool condicao2 = false;

        // Verificar se ambas as condições são verdadeiras
        if (condicao1 && condicao2)
        {
            Console.WriteLine("Ambas as condições são verdadeiras.");
        }
        else
        {
            Console.WriteLine("Pelo menos uma das condições não é verdadeira.");
        }
    }
}

//topico 08

using System;

class Problema08
{
    static void Main()
    {
        // Variáveis
        int num1 = 7;
        int num2 = 3;
        int num3 = 10;

        // Verificar se num1 é maior do que num2
        bool condicao1 = num1 > num2;

        // Verificar se num3 é igual a num1 + num2
        bool condicao2 = num3 == (num1 + num2);

        // Exibir o resultado
        if (condicao1 && condicao2)
        {
            Console.WriteLine("num1 é maior do que num2 e num3 é igual a num1 + num2.");
        }
        else
        {
            Console.WriteLine("As condições não são ambas verdadeiras.");
        }
    }
}


