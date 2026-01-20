using System.Data.Common;

namespace biblioteca.classes;

class Livro
{
    public int Id { get; private set; }      
    public string Titulo { get; private set; } 
    public string Status { get; private set; } 
    public DateTime? DataEmprestimo { get; private set; }    //? troca para nullnable permite que seja nulo
    public string Locatario { get; private set; }

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
            Status = "emprestado";
            Locatario = nomeLocatario;
            Console.WriteLine($"Livro {Titulo} Emprestado para {Locatario}");
            DataEmprestimo = DateTime.Now;  
            Console.WriteLine($"Devolva em 7 dias por favor, data do emprestimo {DataEmprestimo}");
            
        } else
        {
            Console.WriteLine($"Livro {Titulo} já emprestado [INDISPONIVEL]");
        }
    }

    public void Devolver(string nomeLocatario)
    {
        Status = "DISPONIVEL";
        DataEmprestimo = null;
        Console.WriteLine($"Livro devolvido por {nomeLocatario} na data e seu Status é {Status}");
    }

}

class Pessoa
{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public List<Livro> LivrosAlugados { get; private set; } = new List<Livro>(); 

    public Pessoa(int id, string nome)
    {
        Id = id;
        Nome = nome;
        LivrosAlugados = new List<Livro>();
    }

    public void PegarLivro(Livro livro)
    {
        LivrosAlugados.Add(livro);

    }

    public void DevolverLivro(Livro livro)
    {
        LivrosAlugados.Remove(livro);
    }
}

class Biblioteca
{
    public List<Livro> Livros { get; private set; } = new List<Livro>();
    public List<Pessoa> Pessoas { get; private set; } = new List<Pessoa>();

    public void CadastrarLivro(Livro livro)
    {
        if (livro == null)
        {
            Console.WriteLine("erro não é possivel adicionar");
            return;
        }
        
        Livros.Add(livro);
    }

    public void CadastrarUsuario(Pessoa pessoa)
    {
        Pessoas.Add(pessoa);
        
    }

    public void ListarLivros()
    {
        foreach(var l in Livros)
        {        
           Console.WriteLine($"|| ID: {l.Id} Titulo: {l.Titulo} Status: {l.Status}");
        }
    }

    public Livro AcharLivroId(int id)
    {
        foreach (var livro in Livros)
        {
            if (id == livro.Id)
            {
                return livro;
            }
        }
        return null;
    } 

    public void EmprestarLivro(Livro livro, Pessoa pessoa)
    {   
        livro.Emprestar(pessoa.Nome);
        pessoa.PegarLivro(livro);

    }

}