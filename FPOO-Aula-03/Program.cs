internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Trabalhando com Collections");
        Console.WriteLine();
        Console.WriteLine("1. LIST");
        //Criando uma List de strings
        List<string> frutas = new List<string>();

        //Adicionando elementos à lista 
        //Conteúdo - Indice
        frutas.Add("Maça"); //0
        frutas.Add("Banana"); //1
        frutas.Add("Morango"); //2

        //Acessar elementos da lista por índice
        Console.WriteLine($"A primeira fruta da lista é: {frutas[0]}");

        //Alterando o elemento por índice
        frutas[1] = "Laranja";
        Console.WriteLine($"Agora a primeira fruta da lista é: {frutas[1]}");

        //Verificando o tamanho (quantidade) da lista
        Console.WriteLine($"Total de frutas: {frutas.Count}");

        //Removendo um elemento da lista
        Console.WriteLine($"Removendo a fruta: {frutas[2]}");
        frutas.Remove(frutas[2]);

        Console.WriteLine("Lista de frutas:");
        //Imprimindo todos os elementos da lista
        foreach (string fruta in frutas) //Para cada item de frutas quero retornar uma fruta
        {
            Console.WriteLine($"Fruta: {fruta}");
        }

        Console.WriteLine();
        Console.WriteLine("2. DICTIONARY");
        //Criando um Dictionaey de chave e valor (string, int, double, etc.)

        Dictionary<string, double> notas = new Dictionary<string, double>();

        //Adicionar dados ao Dictionary
        notas.Add("João", 0.0);
        notas.Add("Maria", 10.0);
        notas.Add("Marcos", 8.0);
        notas.Add("José", 7.0);
        notas["Pedro"] = 2.7;

        //Acessar um valor do Dictionary usando o índice
        Console.WriteLine($"A nota do João é: {notas["João"]}");
        Console.WriteLine("---------");

        //Verificando se a chave existe no Dictionary
        if (!notas.ContainsKey("José"))
        {
            Console.WriteLine("O nome não está no sistema");
        }

        //Percorrendo o Dictionary 
        foreach (KeyValuePair<string, double> aluno in notas)
        {
            Console.WriteLine($"Aluno {aluno.Key} tirou {aluno.Value}");
        }

        Console.WriteLine();
        Console.WriteLine("3. QUEUE");
        //Criando uma fila de documentos (strings)
        Queue<string> documentos = new Queue<string>();

        //Enfileiramento de itens (Enqueue)
        documentos.Enqueue("relatorio-final.pdf");
        documentos.Enqueue("foto-3x4.jpeg");
        documentos.Enqueue("declaracao-de-matricula.docx");

        //Mostrar o próximo item da fila 
        Console.WriteLine($"O próximo documento será: {documentos.Peek()}");

        Console.WriteLine("...");

        //Desenfileiramento de itens 
        documentos.Dequeue();
        Console.WriteLine($"O próximo documento será: {documentos.Peek()}");

        //Contar os documentos na lista 
        Console.WriteLine($"Total de elementos da lista: {documentos.Count}");

        //Percorrendo todos os elementos da fila
        foreach (string arquivo in documentos)
        {
            Console.WriteLine($"Nome do arquivo: {arquivo}");
        }

        //Limpando todos os elementos da fila
        documentos.Clear();
        Console.WriteLine("Limpando a lista...");
        Console.WriteLine($"Total de elementos da lista: {documentos.Count}");


        Console.WriteLine();
        Console.WriteLine("4. STACK");
        //Criando uma pilha de favoritos (strings)
        Stack<string> favoritos = new Stack<string>();

        //Empilhando itens
        favoritos.Push("https://github.com");
        favoritos.Push("https://gemini.com");
        favoritos.Push("https://steam.com");

        //Mostrar o primeiro elemento da lista
        favoritos.Peek();
        Console.WriteLine($"O primeiro item da lista é: {favoritos.Peek()}");

        //Desepilhar itens da lista
        favoritos.Pop();

        foreach (string item in favoritos)
        {
            Console.WriteLine(item);
        }

        // Apagar todos os itens da pilha
        Console.WriteLine("Limpando a lista...");
        favoritos.Clear();
    }
}

//COLLECTIONS---
//List: Coleção ordenada de elementos, cada um possui um índice. Permite elementos duplicados e é dinâmica, ou seja, pode crescer ou diminuir conforme necessário.
//Exemplo: List<string> nomes = new List<string>();

//Dictionary: Coleção de pares chave-valor, onde cada elemento tem uma chave única. 
//Exemplo: Dictionary<string, int> idades = new Dictionary<string, int>();

//Queue: Coleção do tipo FIFO (First In, First Out), onde o primeiro elemento adicionado é o primeiro a ser removido.
//Exemplo: Queue<string> fila = new Queue<string>();

//Stack: Coleção do tipo LIFO (Last In, First Out), onde o último elemento adicionado é o primeiro a ser removido.
//Exemplo: Stack<string> pilha = new Stack<string>();