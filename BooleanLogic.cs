int saleAmount = 1900;
int discount1 = 100;
int discount2 = 50;

Console.WriteLine($"Total Price: {saleAmount}");

if (saleAmount > 1000)
{
    Console.WriteLine($"Discount Amount: {discount1}");
    int finalPrice = saleAmount - discount1;
    Console.WriteLine($"Final Price: {finalPrice}");

}
else if (saleAmount <= 1000)
{
    Console.WriteLine($"Discount Amount: {discount2}");
    int finalPrice = saleAmount - discount2;
    Console.WriteLine($"Final Price: {finalPrice}");    
}
