using sistema_lanchonete;

namespace sistema;

public class Program
{
    public static void Main() 
    {
        
        var r = new Restaurante();
        r.CadastrarProduto(new Produto { Id = 1, Nome = "Hamburguer", Valor = 29.9m });
        r.CadastrarProduto(new Produto { Id = 2, Nome = "Batata frita", Valor = 14m });
        r.CadastrarProduto(new Produto { Id = 3, Nome = "refrigerante", Valor = 14.9m });
        r.CadastrarProduto(new Produto { Id = 4, Nome = "Nuggets", Valor = 6m });
        r.CadastrarProduto(new Produto { Id = 5, Nome = "Batataa cheddar and baconw", Valor = 18.5m  });
        r.CadastrarProduto(new Produto { Id = 6, Nome = "Hotdog", Valor = 20.5m  });
        
        Console.WriteLine("----- bem vindo a mayyzena hotdog e tals!!!! -----");
        Console.WriteLine("Faça seu cadastro: ");
        Console.WriteLine("---------------");

        Console.WriteLine("Digite seu nome: "); 
        string nome = Console.ReadLine();
        Console.WriteLine("Digite seu telefone: "); 
        string telefone = Console.ReadLine();
        
        var user = new Usuario(nome, telefone);
        

        
        int choice;
        int option;

        do
        {
            Console.Clear();
            Console.WriteLine($"Olá {nome} Seja bem vindo faça um pedido");
            Console.WriteLine("Escolha um numero do menu");
            Console.WriteLine("MENU \n 1 - Fazer novo pedido \n 2- Ver pedidos anteriores \n 3 -Sair");
            option = int.Parse(Console.ReadLine());


            switch (option)
            {
                case 1:
                var p = new Pedido();
                int sair;

                do {  
                    Console.Clear();
                    r.ListarProdutosDisponiveis();   

                    Console.WriteLine("-----------");
                    Console.WriteLine("Adicione produtos pelo id");
                    choice = int.Parse(Console.ReadLine());

                    Produto produtoEscolhido = r.BuscarProdutoPorId(choice);
                    if (produtoEscolhido == null)
                        {
                            Console.Write("Produto não encontrado");
                        } else
                        {
                            p.AdicionarProdutos(produtoEscolhido);
                        }
                    

                    Console.Write("0 - Finalizar ou \n 1 - pedir mais itens "); 
                    sair = int.Parse(Console.ReadLine());

                } while (sair != 0);

                if (p.produtosPedidos.Count > 0)
                    {
                        user.FazerPedido(p); 
                        p.FinalizarPedido();
                    } else
                    {
                        Console.Write("pedido zerado descartado");
                    }

                Console.WriteLine("\n[Pressione ENTER para voltar no menu]");
                Console.ReadKey();
                   
                break;

                case 2:
                user.VerPedidosAnteriores();
                Console.WriteLine("\n[Pressione ENTER para voltar no menu]");
                Console.ReadKey();
                
                break;
                case 3:
                Console.Write("AGRADECEMOS POR UTILIZAR NOSSOS SERVICOS");
                break;
            }
        } while (option != 3);
        

        
   
    }

}