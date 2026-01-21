using System;
using app.systemclass;

namespace app;

class Program
{
    public static void Main()
    {
        
        if (Validador.EhMaiordeIdade(18))
        {
            System.Console.WriteLine("maior de idade");
        } else
        {
             System.Console.WriteLine("Menor de idade");
        }
        
        if (Validador.EmailValido("mayraclarolive.com"))
        {
            System.Console.WriteLine("email valido");
        } else
        {
            System.Console.WriteLine("Email INVALIDO");
        }


        if (Pedido.ValorEhValido(100))
        {
            var pedido = new Pedido(100);
        } else
        {
            System.Console.WriteLine("invalido");
        }


        var sessao1 = new SessaoUsuario("Ana");
        Console.WriteLine(SessaoUsuario.UsuarioAtivo);

        var sessao2 = new SessaoUsuario("LUCAS");
        Console.WriteLine(SessaoUsuario.UsuarioAtivo);
    }
}