using Veiculo_exercise.classes;

namespace Veiculo_exercise;


class Program
{
    public static void Main()
    {
       var carro = new Carro("Toyota", "Etios", 3.50m);
       var Bicicleta = new Bicicleta("Bike Eletrica", "24", 2m);
       var Onibus = new Onibus("Volks", "Busao", 10.5m);
       
       carro.CalcularCusto(10);
       Onibus.CalcularCusto(20);
       Bicicleta.CalcularCusto(30);
       
        

    }
}