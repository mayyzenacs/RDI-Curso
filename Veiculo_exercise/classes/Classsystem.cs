namespace Veiculo_exercise.classes;

public abstract class Transporte(decimal custokm)
{
    public decimal CustoKM = custokm;

    public static void Mover(int KM, string NomeVeiculo)
    {
        Console.WriteLine($"Movendo {NomeVeiculo} vrum vrum {KM}");
    }

    public abstract void CalcularCusto(int KmAndados);
}

public class Carro(string marca, string modelo, decimal custokm) : Transporte(custokm) 
{
    public string Marca { get; } = marca;
    public string Modelo { get; } = modelo;

    public override void CalcularCusto(int KmAndados)
    {   
        Mover(KmAndados, Modelo);
        decimal calculo = CustoKM * KmAndados;
        Console.WriteLine($"O carro {Marca} {Modelo} custou {calculo:C} pra rodar {KmAndados} pra rodar {KmAndados}KM");
    }
}


public class Bicicleta(string marca, string aro, decimal custokm) : Transporte(custokm) 
{
    public string Marca { get; } = marca;
    public string Modelo { get; } = aro;
    
    public override void CalcularCusto(int KmAndados)
    {   
        Mover(KmAndados, Modelo);
        decimal calculo = CustoKM * KmAndados;
        Console.WriteLine($"A Bicicleta {Marca} {Modelo} custou {calculo:C} pra rodar {KmAndados}KM");
    }
}


public class Onibus(string marca, string modelo, decimal custokm) : Transporte(custokm) 
{
    public string Marca { get; } = marca;
    public string Modelo { get; } = modelo;
    
    public override void CalcularCusto(int KmAndados)
    {   
        Mover(KmAndados, Modelo);
        decimal calculo = CustoKM * KmAndados;
        Console.WriteLine($"O Onibus {Marca} {Modelo} custou {calculo:C} pra rodar {KmAndados}KM");
    }
}

