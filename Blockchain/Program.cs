﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using NBitcoin;

namespace Blockchain
{
    public class Program
    {
        static void Main()
        {
            Key privateKey = new Key();

            // From the private key, we use a one-way cryptographic function, to generate a public key.
            PubKey publicKey = privateKey.PubKey;
            Console.WriteLine(publicKey);

            // Get your addresses from your public key
            Console.WriteLine(publicKey.GetAddress(Network.Main));
            Console.WriteLine(publicKey.GetAddress(Network.TestNet));

            var publicKeyHash = publicKey.Hash;
            Console.WriteLine(publicKeyHash);

            var mainNetAdress = publicKeyHash.GetAddress(Network.Main);
            var testNetAdress = publicKeyHash.GetAddress(Network.TestNet);

            Console.WriteLine(mainNetAdress);
            Console.WriteLine(testNetAdress);

            Console.WriteLine(mainNetAdress.ScriptPubKey);
            Console.WriteLine(testNetAdress.ScriptPubKey);

        }
    }
}
