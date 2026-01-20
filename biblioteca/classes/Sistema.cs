using System.Data.Common;

namespace classes;

class Livro
{
    public int Id; 
    public string Titulo;
    public string Status;
    DateTime dataEmprestimo = DateTime.Now;
    public string Locatario;

    public Livro(int id, string titulo)
    {
        Id = id;
        Titulo = titulo;
        Status = "disponivel";
        Locatario = "";
    }

    public void Emprestar(string nomeLocatario)
    {
        if(Status.ToLower() == "disponivel")
        {
            Status = "indisponível";
            Locatario = nomeLocatario;
            Console.WriteLine($"Livro {Titulo} Emprestado para {Locatario}");
            Console.WriteLine("Devolva em 7 dias por favor");
            
        } else
        {
            Console.WriteLine($"Livro {Titulo} já emprestado [INDISPONIVEL]");
        }
    }

    public void Devolver(string nomeLocatario)
    {
        Status = "Disponivel";
        Console.WriteLine($"Livro devolvido por {nomeLocatario}");
    }

}

class Pessoa
{
    public int Id;
    public string Nome;
    List<Livro> LivrosAlugados = new List<Livro>();

    public Pessoa(int id, string nome)
    {
        Id = id;
        Nome = nome;
        LivrosAlugados = new List<Livro>();
    }

    public void EmprestarLivro(Livro livro)
    {
        LivrosAlugados.Add(livro);

    }

    public void DevolverLivro(Livro livro)
    {
        LivrosAlugados.Remove(livro);
    }

    public void ListarLivrosAlugados()
    {
        foreach(var l in LivrosAlugados)
        {
            
            Console.WriteLine($"Livro {l.Titulo} Emprestado por {Nome} Durante 7 dias");

        }
    }
}

class Biblioteca
{
    List<Livro> Livros = new List<Livro>();
    List<Pessoa> Pessoas = new List<Pessoa>();

    public void CadastrarLivro(Livro livro)
    {
        var livro1 = new Livro(1, "Sociedade do cansaco");
        var livro2 = new Livro(2, "Flow a psicologia da felicidade");
        

        Livros.Add(livro);
        Console.WriteLine($"Livro {livro.Titulo} cadastrado com sucesso");
    }

    public void CadastrarUsuario(Pessoa pessoa)
    {
        Pessoas.Add(pessoa);
    }

    public void ListarLivros()
    {
        foreach(var l in Livros)
        {        
           Console.WriteLine($"ID {l.Id} Livro {l.Titulo} status: {l.Status} Quem alugou {l.Locatario}");
        }
    }

    public void EmpestarLivro(Livro livro, Pessoa pessoa)
    {
        livro.Emprestar(pessoa.Nome);
        pessoa.EmprestarLivro(livro);

    }

}