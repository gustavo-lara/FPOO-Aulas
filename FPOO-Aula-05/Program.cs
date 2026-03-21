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

        Console.WriteLine("Exceções");
        Console.WriteLine("");

        try
        {
            int numero = int.Parse("abc");  //Erro no Parse (converte a string em int) por conta que "abc" não é número
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Programa finalizado.");
        }
    }

    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public double Preco { get; set; }
        public int Ano { get; set; }
    }

    //Tratamento de exceções
    //try: código que pode gerar uma exceção
    //catch: código para tratar a exceção
    //finally: código que será executado independentemente de ocorrer ou não uma exceção
    //throw: lança uma exceção

    //Porque tratar exceções?
    //1. Evitar que o programa termine abruptamente
    //2. Fornecer feedback ao usuário sobre o que deu errado
}