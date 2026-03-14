internal class Program
{
    private static void Main(string[] args) //Função principal do programa, onde a execução começa
    {
        /* Tipos de Dados:
         * int: para números inteiros
         * double: para números decimais
         * string: para texto
         * bool: para valores booleanos (true/false)
        */

        int idade = 19; // Variável do tipo inteiro
        string nome = "Gustavo"; // Variável do tipo string
        double altura = 1.70; // Variável do tipo double
        bool estudante = true; // Variável do tipo booleano

        // Imprimindo as variáveis no console
        Console.WriteLine(nome);

        // Concatenando texto e variáveis
        Console.WriteLine("Nome: " + nome);

        // Interpolação de strings (C# 6.0+)
        Console.WriteLine($"Nome: {nome}, Idade: {idade}, Altura: {altura}m, Estudante: {estudante}");

        // Operadores aritméticos ( + , -, *, /, % )
        int a = 10;
        int b = 2;

        int soma = a + b; // 12
        int subtracao = a - b; // 8
        int multiplicacao = a * b; // 20
        int divisao = a / b; // 5
        int resto = a % b; // 0

        // Operadores de comparação ( == , != , > , < , >= (> =), <= (< =) )

        bool igual = (a == b); // false
        bool diferente = (a != b); // true 
        bool maior = (a > b); // true
        bool menor = (a < b); // false
        bool maiorOuIgual = (a >= b); // true
        bool menorOuIgual = (a <= b); // false


        // Operadores lógicos ( && , || , ! )

        // Comparar se uma pessoa é sexo masculino e tem 18 anos

        int idadePessoa = 20;
        string sexoPessoa = "Masculino";

        bool alistar = (sexoPessoa == "Masculino") && (idadePessoa >= 18); // false

        Console.WriteLine($"A pessoa está apta para o alistamento: {alistar}");


        // Exemplo de uso do operador lógico OR (||)

        idadePessoa = 17;
        sexoPessoa = "Masculino";

        alistar = (sexoPessoa == "Masculino") || (idadePessoa >= 18); // false

        // Exemplo de uso do operador lógico NOT (!)

        // Verificar se a pessoa não é do sexo feminino
        sexoPessoa = "Masculino";

        bool feminino = !(sexoPessoa == "Feminino"); // true

        Console.WriteLine($"A pessoa é do sexo Feminino: {feminino}");


        Console.WriteLine($"A pessoa está apta para o alistamento: {alistar}");

        Console.WriteLine("");
        Console.WriteLine("************************");
        Console.WriteLine("");

        //Estruturas de controle

        Console.WriteLine("If-Else:");

        idade = 19;
        Console.WriteLine(idade);

        if (idade >= 18)
        {
            Console.WriteLine("Maior de idade");
        }
        else
        {
            Console.WriteLine("Menor de idade");
        }

        Console.WriteLine("");
        Console.WriteLine("If-Else If-Else:");

        idade = 17;
        if (idade >= 18)
        {
            Console.WriteLine("Adulto");
        }
        else if (idade >= 13)
        {
            Console.WriteLine("Adolescente");
        }
        else
        {
            Console.WriteLine("Criança");
        }

        Console.WriteLine("");
        Console.WriteLine("Switch Case:");

        int diaDaSemana = 6;
        switch (diaDaSemana)
        {
            case 1:
                Console.WriteLine("Domigo");
                break;
            case 2:
                Console.WriteLine("Segunda");
                break;
            case 3:
                Console.WriteLine("Terça");
                break;
            case 4:
                Console.WriteLine("Quarta");
                break;
            case 5:
                Console.WriteLine("Quinta");
                break;
            case 6:
                Console.WriteLine("Sexta");
                break;
            case 7:
                Console.WriteLine("Sábado");
                break;
            default:
                Console.WriteLine("Dia inválido");
                break;
        }

        Console.WriteLine("");
        Console.WriteLine("Repetição While:");

        int contador = 1;
        while (contador <= 10)
        {
            Console.WriteLine($"Contador: {contador}");
            contador++;
        }

        Console.WriteLine("");
        Console.WriteLine("Repetição Do While:");
        //Realiza a repetição pelo menos uma vez, mesmo que a condição seja falsa

        contador = 1000;
        do
        {
            Console.WriteLine($"Contador: {contador}");
            contador++;
        } while (contador <= 100);

        Console.WriteLine("");
        Console.WriteLine("Laço For:");

        for (int i = 0; i <= 7; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("");
        Console.WriteLine("Laço Foreach:");

        string[] frutas = { "Maçã", "Banana", "Laranja", "Uva" };

        foreach (string fruta in frutas) //Para cada item(fruta) no array(frutas)
        {
            Console.WriteLine(fruta);
        }

        Console.WriteLine("");
        Console.WriteLine("************************");
        Console.WriteLine("");
        //Chamando as funções

        int num1 = 5;
        int num2 = 3;

        Console.WriteLine($"A soma de {num1} + {num2} é: {Somar(num1, num2)}");
    }

    //Métodos e Funções
    //Função void retorna vazio, ou seja, não retorna nenhum valor

    static int Somar(int num1, int num2) //Função que recebe dois parâmetros inteiros e retorna a soma deles
    {
        return num1 + num2; //Retorna o resultado da soma
    }
}