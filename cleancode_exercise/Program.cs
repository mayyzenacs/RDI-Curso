using System;
using app.systemclass;

public class Program
{
    public static void Main()
    {
        var c = new FinalPayment();
        Console.WriteLine($"Desconto Regular {FinalPayment.CalcFinalPayment(2, 89.9,FinalPayment.CustomerType.Regular, true)}");
        Console.WriteLine($"Desconto Premium {FinalPayment.CalcFinalPayment(2, 89.9,FinalPayment.CustomerType.Premium, true)}");
        Console.WriteLine($"Desconto Vip {FinalPayment.CalcFinalPayment(2, 89.9,FinalPayment.CustomerType.Vip, true)}");

        Console.WriteLine($"Desconto Regular SEM DESCONTO {FinalPayment.CalcFinalPayment(2, 89.9,FinalPayment.CustomerType.Regular, false)}");
        Console.WriteLine($"ZERO TEST {FinalPayment.CalcFinalPayment(0, 0,FinalPayment.CustomerType.Regular, false)}");

    }
}