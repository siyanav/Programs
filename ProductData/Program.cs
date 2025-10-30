public class ProductData
{
    public static void Main(string[] args)
    {
        double productPrice = 45.99; 
        int quantity = 250;

        double vatRate = 0.20;

        const double TOTAL_PROFIT_GOAL = 5000.00;

        double totalReavenue = productPrice * quantity

        Console.WriteLine($"Цена на продукт: {productPrice:C}");
        Console.WriteLine($"Продадено количество: " + quantity);
        Console.WriteLine($"Общ приход: {totalReavenue:C}");
        Console.WriteLine($"Печалба: {TOTAL_PROFIT_GOAL:C}");
    }
}
