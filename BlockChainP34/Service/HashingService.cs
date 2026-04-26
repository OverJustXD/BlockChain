using BlockChainP34.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlockChainP34.Service
{
    public class HashingService
    {
        public string ComputeHash(Block block)
        {
            string rawData = $"{block.Index}{block.Timestamp}{block.Data}{block.PrevHash}{block.Author}{block.Nonce}";
            return ComputeHash(rawData);
        }

        private string ComputeHash(string rawData)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(rawData);
<<<<<<< HEAD
            byte[] hashBytes = SHA256.HashData(inputBytes);

            return Convert.ToHexString(hashBytes).ToLowerInvariant();
=======
            byte[] harshBytes = SHA256.HashData(inputBytes);

            return Convert.ToBase64String(harshBytes);
>>>>>>> b2733c7cb0878b8fc714b92b27017633a0cb7691
        }
    }
}
