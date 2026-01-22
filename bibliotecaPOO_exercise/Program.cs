using biblioteca.classes;
using System.Linq;
using System.Reflection.Metadata;

namespace biblioteca; 

class Program
{
    public static void Main()
    {   
        var bib = new Biblioteca();
        bib.CadastrarLivro(new Livro(1, "Sociedade do Cansaço"));
        bib.CadastrarLivro(new Livro(2, "Flow a Psicologia da Felicidade"));
        bib.CadastrarLivro(new Livro(3, "Minimalismo Digital"));

        int option;

        Console.WriteLine("--- Bem vindo a biblioteca Mayyzena ---");

        
        do
        {
            Console.WriteLine("Biblioteca Menu \n 1 - Listar Livros \n 2 - Emprestar Livro \n 3- SAIR Escolha uma opcao!");
            option = int.Parse(Console.ReadLine());

            switch (option)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("Listando todos os livros...");
                Thread.Sleep(2000);
                bib.ListarLivros();
            break;

            case 2:
                Console.WriteLine("Por favor se cadastre como locatario");
                Console.Write("Nome locatario: ");
                string nome = Console.ReadLine(); 
                var user = new Pessoa(1, nome);

                if (!string.IsNullOrWhiteSpace(nome) && !nome.Any(char.IsDigit))
                    {
                        bib.CadastrarUsuario(user);
                        Console.WriteLine($"Usuario {nome} cadastrado com sucesso");
                    } else
                    {
                        Console.WriteLine("erro, nome Não pode ser nulo nem numero. Tente novamente");
                        return;
                    }
                Console.WriteLine($"Bem vindo {nome} a biblioteca!!");
                Thread.Sleep(3000);

                Console.Clear();
                Console.WriteLine(" -- Escolha o livro desejado pelo ID --");
                bib.ListarLivros();
                int id = int.Parse(Console.ReadLine());
                var livroEscolhido = bib.AcharLivroId(id);
                
                if (livroEscolhido != null)
                {
                    bib.EmprestarLivro(livroEscolhido, user);
                } else {
                    Console.WriteLine("Livro Não encontrado.");
                    }

                Console.WriteLine("----------");
            break;

            case 3:
                Console.WriteLine("Agradecemos por utilizar nossa biblioteca!!");
                Console.WriteLine("Programa encerrado.");
            break;
        }
            
        } while (option != 3);      
        
    }
}