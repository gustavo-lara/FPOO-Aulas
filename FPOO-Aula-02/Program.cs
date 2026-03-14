internal class Program
{
    private static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green; //Exemplo de Atributo de classe para "Console" (ForegroundColor)
        Console.WriteLine("Digite seu nome: "); //Exemplo de método de classe para "Console" (WriteLine)
        string nome = Console.ReadLine(); //Exemplo de método de classe para Ler Entrada de usuário (ReadLine)
        Console.WriteLine($"Olá, {nome}! Seja bem-vindo!"); //Exibindo o nome
    }

    //PILARES DO POO--- 
    //Abstração: Trazer algo de fora do mundo real para o mundo da programação. Exemplo: Ler o nome do usuário e exibir uma mensagem personalizada.
    //Herança: Criar uma nova classe que herda as características de uma classe existente. Exemplo: Criar uma classe "Pessoa" e depois criar uma classe "Aluno" que herda de "Pessoa".
    //Encapsualemento: Esconder os detalhes internos de uma classe e fornecer uma interface pública para interagir com ela. Exemplo: Criar uma classe "ContaBancaria" que tem um método público "Depositar" e um campo privado "saldo".
    //Polimorfismo: Permitir que objetos de diferentes classes sejam tratados como objetos da mesma classe base. Exemplo: Criar uma classe base "Animal" e depois criar classes derivadas "Cachorro" e "Gato" que implementam um método "FazerSom" de maneira diferente.
}