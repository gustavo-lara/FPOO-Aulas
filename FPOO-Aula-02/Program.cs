internal class Program
{
    private static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Blue; //Exemplo de Atributo de classe para "Console" (ForegroundColor)
        Console.WriteLine("Digite seu nome: "); //Exemplo de método de classe para "Console" (WriteLine)
        string nome = Console.ReadLine(); //Exemplo de método de classe para Ler Entrada de usuário (ReadLine)
        Console.WriteLine($"Olá, {nome}! Seja bem-vindo!"); //Exibindo o nome

        Console.WriteLine();//*******************************

        //Instanciar (criar) um objeto da classe carro
        Carro meuCarro = new Carro(); //objeto vazio

        //Atribuindo valores aos atributos do objeto "meuCarro"
        meuCarro.Marca = "Honda";
        meuCarro.Modelo = "Civic";
        meuCarro.Ano = 2019;

        Carro meuNovoCarro = new Carro();
        meuNovoCarro.Marca = "Ford";
        meuNovoCarro.Modelo = "Mustang";
        meuNovoCarro.Ano = 2026;

        //Instanciando um objeto do tipo Carro utilizando a sintaxe de inicialização de objetos
        Carro meuAntigoCarro = new Carro
        {
            Marca = "Chevrolet",
            Modelo = "Camaro SS",
            Ano = 1969
        };

        //Exibir as informações dos carros utilizando métodos
        meuCarro.ExibirInformacoes();
        meuCarro.Ligar();
        meuNovoCarro.Ligar();
        meuAntigoCarro.Ligar();

        Console.WriteLine();//*******************************

        //Instanciando objeto com atributos de Acessorio (Filha) e Carro (Mãe)
        Acessorio meuCarroComAcessorios = new Acessorio();
        meuCarroComAcessorios.Marca = "Lamborghini";
        meuCarroComAcessorios.Modelo = "Revuelto";
        meuCarroComAcessorios.Ano = 2025;
        meuCarroComAcessorios.Portas = 4;
        meuCarroComAcessorios.CambioAutomatico = true;

        meuCarroComAcessorios.ExibirInformacoes();
        meuCarroComAcessorios.Ligar();

        Console.WriteLine();//*******************************

        ContaBancaria minhaConta = new ContaBancaria();
        minhaConta.Depositar(200);
    }

    //Criar uma classe para representar um carro
    public class Carro //Exemplo de Abstração
    {
        // Atributos da classe Carro
        public string Marca { get; set; } //get e set são usados para acessar e modificar os atributos da classe
        public string Modelo { get; set; }
        public int Ano { get; set; }


        public virtual void ExibirInformacoes() //Método para exibir as informações do carro (Usamos virtual para herdar o método)
        {// public void ExibirInformacoes()
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
        }

        public void Ligar()
        {
            Console.WriteLine($"O carro modelo {Modelo} está ligado!");
        }
    }

    //Criar uma classe acessórios para os carros
    public class Acessorio : Carro //Exemplo de Herança, acessórios irá Herdar a classe carro
    {
        public int Portas;
        public bool CambioAutomatico;

        public override void ExibirInformacoes() //Exemplo de Polimorfismo, Sobrescreve o método da classe mãe (Carro)
        {
            base.ExibirInformacoes(); //Traz todas as informações da classe mãe (Carro)
            Console.WriteLine($"Portas: {Portas}");
            Console.WriteLine($"CambioAutomatico: {CambioAutomatico}");
        }
    }

    //Criar uma classe de conta bancária
    public class ContaBancaria //Exemplo de encapsulamento
    {
        // Atributo privado: Ninguem fora da classe pode alterar diretamente
        private double Saldo;
        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de R$" + valor + " realizado com sucesso!");
        }
    }

}

//PILARES DO POO--- 
//Abstração: Trazer algo de fora do mundo real para o mundo da programação. 
//Exemplo: Ler o nome do usuário e exibir uma mensagem personalizada.

//Herança: Criar uma nova classe que herda as características de uma classe existente. 
//Exemplo: Criar uma classe "Pessoa" e depois criar uma classe "Aluno" que herda de "Pessoa".

//Encapsualemento: Esconder os detalhes internos de uma classe e fornecer uma interface pública para interagir com ela. 
//Exemplo: Criar uma classe "ContaBancaria" que tem um método público "Depositar" e um campo privado "saldo".

//Polimorfismo: Permitir que objetos de diferentes classes sejam tratados como objetos da mesma classe base. 
//Exemplo: Criar uma classe base "Animal" e depois criar classes derivadas "Cachorro" e "Gato" que implementam um método "FazerSom" de maneira diferente.

//Conceitos de POO---
//Classe: Define o que o objeto terá -> Atributos (características) e Métodos (ações) 
//Exemplo: Criar uma classe "Pessoa" com atributos "nome" e "idade" e métodos "falar" e "andar".

//Objeto: Quando a classe ganha vida na memória do computador
//Exemplo: Criar um objeto "pessoa1" da classe "Pessoa" e atribuir valores aos seus atributos (nome, idade) e chamar seus métodos (falar, andar).