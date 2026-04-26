using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Diagnostics;
=======
>>>>>>> b2733c7cb0878b8fc714b92b27017633a0cb7691
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlockChainP34.Models;

namespace BlockChainP34.Service
{
    public class MiningService
    {
        private readonly HashingService _hashingService;

        public MiningService(HashingService hashingService)
        {
            _hashingService = hashingService;
        }

        public long MineBlock(Block block, int difficulty)
        {
            var target = new String('0', difficulty);
<<<<<<< HEAD
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
=======
>>>>>>> b2733c7cb0878b8fc714b92b27017633a0cb7691
            while (true)
            {
                block.Nonce++;
                block.Hash = _hashingService.ComputeHash(block);
<<<<<<< HEAD

                if (block.Nonce % 100000 == 0)
                {
                    Console.Write(".");
                }

                if (block.Hash.StartsWith(target))
                {
                    Console.WriteLine($"\nBlock mined with nonce: {block.Nonce}, hash: {block.Hash}");
                    stopwatch.Stop();
                    block.MiningDurationSecond = stopwatch.Elapsed.TotalSeconds;
                    block.DifficultyAtMining = difficulty;
=======
                if (block.Nonce % 100000 == 0)
                {
                    Console.Write(".");

                }
                if (block.Hash.StartsWith(target))
                {
                    Console.WriteLine($"Block mined with nonce: {block.Nonce}, hash: {block.Hash}");
>>>>>>> b2733c7cb0878b8fc714b92b27017633a0cb7691
                    return block.Nonce;
                }
            }
        }
    }
}
