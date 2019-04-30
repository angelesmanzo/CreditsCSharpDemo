﻿using NodeApi;
using System;
using Thrift.Protocol;
using Thrift.Transport;

namespace CreditsCSAPIDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Credits API Simple Demo");

            var publicKey = "your address";
            var publicKeyBytes = SimpleBase.Base58.Bitcoin.Decode(publicKey).ToArray();

            using (var transport = new TSocket("127.0.0.1", 9090))
            {
                using (var protocol = new TBinaryProtocol(transport))
                {
                    using (var client = new API.Client(protocol))
                    {
                        transport.Open();

                        var balance = client.WalletBalanceGet(publicKeyBytes);
                        Console.WriteLine($"[{publicKey}] Balance: {balance.Balance.ToString()}");
                    }
                }
            }

            Console.WriteLine("Press [Enter] to exit...");
            Console.ReadLine();
        }
    }
}
