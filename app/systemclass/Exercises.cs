using System;

namespace app.systemclass;

public class Validador
{
    public static bool EhMaiordeIdade(int idade)
    {
        if (idade >= 18)
        {
            return true;
        } 
        return false;
    }

    public static bool EmailValido(string email)
    {
        if (email.Contains('@'))
        {
            return true;
        } 
        return false;
    }

}

public class Pedido
{
    public static decimal Valor;

    public Pedido(decimal valor)
    {
        Valor = valor;
    }

    public static bool ValorEhValido(decimal valor)
    {
        if (valor > 0)
        {
            return true;
        }
        return false;
    }
}


public class SessaoUsuario
{
    public string NomeUsuario { get; private set; } 
    public static string UsuarioAtivo;

    public SessaoUsuario(string usuarioativo)
    {
        UsuarioAtivo = usuarioativo;
    }
}