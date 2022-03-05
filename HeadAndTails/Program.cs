// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int Coin_Head = 1;
Random random = new Random();
int coincheck = random.Next(0, 2);
if (coincheck == Coin_Head)
{
    Console.WriteLine("Coin Is Head");
}
else
{
    Console.WriteLine("Coin Is Tails");
}