namespace heranca_poliformismo.classes;

public class Notificacao
{
    public string Nome;
    public string Destinatario;
    public string Mensagem;

    public Notificacao(string nome, string destinatario, string mensagem)
    {
        Nome = nome;
        Destinatario = destinatario;
        Mensagem = mensagem;
    }

    public virtual string Enviar()
    {
        return string.Format($"Notificacao tipo {Nome} para {Destinatario} conteudo --- {Mensagem} ---");
    }
}

public class NotificacaoService()
{

    public string Enviar(Notificacao notificacao)
    {
        return string.Format($"{notificacao.Enviar()}");
    }

    public void Enviar(List<Notificacao> notificacaos)
    {
        foreach (var n in notificacaos)
        {
            Console.WriteLine(Enviar(n));
        }
        
    }
}
