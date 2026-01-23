
using heranca_poliformismo.classes;

public class Program
{
    
    public static void Main()
{
    var n = new Notificacao("Email","fulano","oii");
    var n1 = new Notificacao("SMS","fulano","oii");
    var n2 = new Notificacao("Fumaça","fulano","oii");
    var nc = new NotificacaoService();
    Console.WriteLine(nc.Enviar(n));
    Console.WriteLine(nc.Enviar(n1));
    Console.WriteLine(nc.Enviar(n2));

    List<Notificacao> notifacoeslist = [n,n1,n2];
    Console.WriteLine("---");
    nc.Enviar(notifacoeslist);
    
}
}