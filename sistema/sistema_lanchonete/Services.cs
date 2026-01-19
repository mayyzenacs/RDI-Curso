namespace sistema_lanchonete; 

public class Produto
{
    public int Id;
    public string Nome;
    public decimal Valor;

}

public class Pedido
{
    public int Id;
    DateTime Hora = DateTime.Now;
    public string Usuario;
    public List<Produto> produtosPedidos = new List<Produto>();

    public void AdicionarProdutos(Produto produto)
    {
        produtosPedidos.Add(produto);
        Console.WriteLine($"adicionado ao pedido: {produto.Nome}");
    }

    public string CalcularTotal()
    {
        return string.Format($"{produtosPedidos.Sum(produtosPedidos => produtosPedidos.Valor)}");
    }

    public void FinalizarPedido()
    {
        Console.WriteLine($"finalizando pedido para {Usuario}");
        Console.WriteLine("-----------");
        foreach (var p in produtosPedidos)
        {
            Console.WriteLine($"---- Produto {p.Nome} Valor {p.Valor} ----");
        }
        Console.WriteLine($"Total do pedido: {CalcularTotal()}");
        Console.WriteLine("-----------");
        Console.WriteLine($"Horario do pedido {Hora} seu pedido estára pronto em BREVE VOLTE SEMPRE :)");
    }
}

public class Usuario  
{
    public string Nome;
    string Telefone;
    private List<Pedido> pedidosRealizados = new List<Pedido>();

    public Usuario(string nome, string telefone)
    {
        Nome = nome;
        Telefone = telefone;
    }

    public void FazerPedido(Pedido pedido)
    {
        var rnd = new Random(); 
        pedido.Id = rnd.Next();

        pedido.Usuario = this.Nome;
        pedidosRealizados.Add(pedido);
        
    }

    public void VerPedidosAnteriores()
    {
        foreach (var pedido in pedidosRealizados)
        {
            foreach (var produto in pedido.produtosPedidos)
            {
                Console.WriteLine($"Pedido: {produto.Nome} Valor: {produto.Valor}");
            }
            Console.WriteLine($"Total do pedido: {pedido.CalcularTotal()}");
        }
    }
}

public class Restaurante
{
    public List<Pedido> listaPedidos = new List<Pedido>();
    List<Produto> produtos = new List<Produto>();

    public void CadastrarProduto(Produto produto)
    {
        foreach (var p in produtos)
        {
            if (p.Id == produto.Id)
            {
                Console.WriteLine($"Erro ja existe um produto com esse ID:  {produto.Id}");
                return; 
            }
        }
        produtos.Add(produto);
    }

    public Produto BuscarProdutoPorId(int id)
    {
        foreach (var p in produtos)
        {
            if (p.Id == id)
            {
                return p; 
            }   
        } 
      
        return null;
    }

    public void ListarProdutosDisponiveis()
    {
        foreach(var p in produtos)
        {
            Console.WriteLine($"id: {p.Id} nome: {p.Nome} Valor: {p.Valor}");
        }
    }
}
