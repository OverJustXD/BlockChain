using BlockChainP34.Service;
using BlockChainP34.Models;
<<<<<<< HEAD

var displayService = new DisplayService();


var Difficulty = 0;
do
{
    Console.WriteLine("Enter missing Difficulty (positive integer): ");
    var input = Console.ReadLine();
    if (!int.TryParse(input, out Difficulty) || Difficulty <= 0)
    {
        Console.WriteLine("Invalid input. Please enter a positive integer.");
    }
} while (Difficulty <= 0);

var blockChainService = new BlockChainService(Difficulty);

for (int i = 0; i < 10; i++)
{
    blockChainService.AddBlock("First Block", "Alex");
    blockChainService.AddBlock("Second Block", "Deny");
    blockChainService.AddBlock("Third Block", "Timur");
    blockChainService.AddBlock("Fourth Block", "Lisa");
    displayService.DisplayBlockChain(blockChainService.Chain);
    Console.WriteLine("Difficulty: " + blockChainService.Difficulty);
}

=======
var displayService = new DisplayService();
var blockChainService = new BlockChainService(1);

blockChainService.AddBlock("First Block", "Alex");

blockChainService.AddBlock("Second Block", "Deny");

blockChainService.AddBlock("Third Block", "Timur");

blockChainService.AddBlock("Fourth Block", "Lisa");

displayService.DisplayBlockChain(blockChainService.Chain);

blockChainService.Chain[1].Data = "Tampered Data";

if (blockChainService.IsVaild())
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("The blockchain is valid.");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("The blockchain is not valid.");
}

blockChainService.Chain[1].Data = "First Block";

foreach(int d in new int[] { 1, 2, 3, 4 })
{
    Console.WriteLine(d);
    var sw = System.Diagnostics.Stopwatch.StartNew();
    var blockchain = new BlockChainService(d);
    blockchain.AddBlock("Alice pays Bob 10 BTC", "Alice");
    sw.Stop();
    Console.WriteLine($"Time taken to mine block with difficulty {d}: {sw.ElapsedMilliseconds} ms");
}
>>>>>>> b2733c7cb0878b8fc714b92b27017633a0cb7691
