using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> b2733c7cb0878b8fc714b92b27017633a0cb7691
using BlockChainP34.Models;

namespace BlockChainP34.Service
{
    public class DisplayService
    {
<<<<<<< HEAD
        public bool Verbose { get; set; } = false;

        public void DisplayBlockChain(List<Block> chain)
        {
            foreach (var block in chain)
            {
                if (Verbose)
                {
                    Console.WriteLine($"Index: {block.Index}");
                    Console.WriteLine($"Timestamp: {block.Timestamp}");
                    Console.WriteLine($"Data: {block.Data}");
                    Console.WriteLine($"Hash: {block.Hash}");
                    Console.WriteLine($"PrevHash: {block.PrevHash}");
                    Console.WriteLine($"Author: {block.Author}");
                }
                else
                {
                    Console.WriteLine($"#{block.Index} | {block.Timestamp} | {block.Author}");
                }

=======
        public void DisplayBlockChain(List<Models.Block> chain)
        {
            foreach (var block in chain)
            {
                Console.WriteLine($"Index: {block.Index}");
                Console.WriteLine($"Timestamp: {block.Timestamp}");
                Console.WriteLine($"Data: {block.Data}");
                Console.WriteLine($"Hash: {block.Hash}");
                Console.WriteLine($"PrevHash: {block.PrevHash}");
                Console.WriteLine($"Author: {block.Author}");
>>>>>>> b2733c7cb0878b8fc714b92b27017633a0cb7691
                Console.WriteLine(new string('-', 50));
            }
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> b2733c7cb0878b8fc714b92b27017633a0cb7691
