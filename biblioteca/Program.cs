using classes;

namespace biblioteca; 

class Program
{
    public static void Main()
    {
        
        // livro1.Devolver("Lucas");

        System.Console.WriteLine("Biblioteca Menu /n 1 - dasds /n 2 - Emprestar livro");

        string nome;
        Console.WriteLine("Nome locatario");
        nome = Console.ReadLine(); 
        
        var user = new Pessoa(1, nome);
        


        var bib = new Biblioteca();

        bib.ListarLivros();
        
        
    }
}