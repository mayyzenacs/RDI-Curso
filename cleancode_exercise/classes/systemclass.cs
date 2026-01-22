using static app.systemclass.FinalPayment;

namespace app.systemclass;

// EXERCICIO CLEAN CODE

public class FinalPayment{

    public enum CustomerType
        { Regular = 1, Premium = 2, Vip = 3 }

    public static double CalcFinalPayment(
        int quantity, 
        double valueItem, 
        CustomerType clientType, 
        bool haveDiscount)
        {

        if (quantity <= 0 || valueItem <= 0)
        {
            Console.WriteLine("Não pode ser zero ou menor");
            return 0;
        }

        double total = quantity * valueItem;
        if (!haveDiscount) return total;
        List<double> discounts = [0.05 * total, 0.10 * total, 0.15 * total];

        switch (clientType)
        {
            case (CustomerType.Regular):
            total -= discounts[0];
            break;
            case (CustomerType.Premium):
            total -= discounts[1];
            break;
            case (CustomerType.Vip):
            total -= discounts[2];
            break;
        }
        return (double)(decimal) total;
    }

}