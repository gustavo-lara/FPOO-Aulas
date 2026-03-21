using static Program;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Livro> biblioteca = new List<Livro>
        {
            new Livro { Titulo = "O Senhor dos Anéis", Autor = "Tolkien", Preco = 80.0, Ano = 1954 },
            new Livro { Titulo = "1984", Autor = "George Orwell", Preco = 45.0, Ano = 1949 },
            new Livro { Titulo = "Dom Casmurro", Autor = "Machado de Assis", Preco = 30.0, Ano = 1899 },
            new Livro { Titulo = "O Hobbit", Autor = "Tolkien", Preco = 55.0, Ano = 1937 },
            new Livro { Titulo = "Clean Code", Autor = "Robert Martin", Preco = 120.0, Ano = 2008 }
        };

        Console.WriteLine("Funções LINQ");
        Console.WriteLine("");
        Console.WriteLine("1. Filtragem e busca - Where **********");
        //Buscar os livros com preço maior que R$100. 

        var listaLivros = biblioteca.Where(l => l.Preco > 75).ToList(); //arrow function (lambda)

        foreach (var livro in listaLivros)
        {
            Console.WriteLine($"Livro: {livro.Titulo} | Autor: {livro.Autor} | Preço: {livro.Preco} | Ano: {livro.Ano}");
        }

        Console.WriteLine("");
        Console.WriteLine("2. FirstOrDefault - First **********");
        //Buscando o primeiro livro do autor "Tolkien"

        var buscaLivro = biblioteca.FirstOrDefault(l => l.Autor == "Tolkien");

        Console.WriteLine($"Livro: {buscaLivro.Titulo} | Autor: {buscaLivro.Autor} | Preço: {buscaLivro.Preco} | Ano: {buscaLivro.Ano}");

        Console.WriteLine("");
        Console.WriteLine("3. Ordenação - OrderBy and Thenby **********");
        //Ordernar livros por ano de publicação

        var ordernarLivros = biblioteca.OrderBy(l => l.Ano).ThenBy(l => l.Titulo).ToList(); //Ordena por ano e, em caso ano repetido, por título

        foreach (var livro in ordernarLivros)
        {
            Console.WriteLine($"Livro: {livro.Titulo} | Autor: {livro.Autor} | Preço: {livro.Preco} | Ano: {livro.Ano}");
        }

        Console.WriteLine("");
        Console.WriteLine("4. Projeção/Trasnformação - Select **********");

        var titulosFormatados = biblioteca.Select(l => $"{l.Titulo} ({l.Ano})");

        foreach (var titulo in titulosFormatados)
        {
            Console.WriteLine(titulo.ToString());
        }

        Console.WriteLine("");
        Console.WriteLine("5. Agregações Matemáticas - Sum, Min, Max, Average, etc.  **********");

        double totalPatrimonio = biblioteca.Sum(l => l.Preco);
        double maiorPreco = biblioteca.Max(l => l.Preco);
        double menorPreco = biblioteca.Min(l => l.Preco);
        double mediaPreco = biblioteca.Average(l => l.Preco);

        Console.WriteLine($"Total de patrimônio: R${totalPatrimonio}");
        Console.WriteLine($"Maior preço: R${maiorPreco}");
        Console.WriteLine($"Menor preço: R${menorPreco}");
        Console.WriteLine($"Média de preços: R${mediaPreco}");

        Console.WriteLine("");
        Console.WriteLine("6. Paginação/Particionamento - Skip´and Take **********");
        //Pulando os dois primeiros e trazendo os próximos dois

        var paginados = biblioteca.Skip(2).Take(2).ToList();

        foreach (var livroPaginados in paginados)
        {
            Console.WriteLine($"Livro: {livroPaginados.Titulo} | Autor: {livroPaginados.Autor} | Preço: {livroPaginados.Preco} | Ano: {livroPaginados.Ano}");
        }
    }

}

public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public double Preco { get; set; }
    public int Ano { get; set; }
}

// O LINQ (Language Integrated Query) permite consultar e filtrar coleções de dados (Listas, Arrays) 
// de forma declarativa e direta, substituindo blocos complexos de 'foreach' e 'if'.
//
// Para aplicar essas regras de forma rápida, o LINQ utiliza Expressões Lambda (ex: l => l.Preco > 100).
// Uma Lambda é simplesmente uma função anônima (sem nome) e inline (criada no exato local 
// onde será usada, sem precisar ser declarada em outro lugar do arquivo).
//
// Na prática: A expressão "l => l.Preco > 100" diz ao LINQ: 
// "Para cada item 'l' da lista, mantenha apenas os que têm o Preço maior que 100".
// O resultado é um código muito mais limpo, eficiente e fácil de ler.