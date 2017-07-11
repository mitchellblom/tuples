using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();
            transactions.Add(("phone", 199.04, 11));
            transactions.Add(("charger", 19.04, 22));
            transactions.Add(("case", 29.04, 55));
            transactions.Add(("headphones", 9.04, 76));
            transactions.Add(("dock", 99.04, 34));

            foreach ((string product, double amount, int quantity) transaction in transactions) {
                Console.WriteLine($"{transaction.product} {transaction.amount} {transaction.quantity}");
            }

            int quantitySold = 0;
            double salesRevenue = 0;

            foreach ((string product, double amount, int quantity) transaction in transactions) {
                quantitySold += transaction.quantity;
                salesRevenue += transaction.amount;
            }

            Console.WriteLine(quantitySold);
            Console.WriteLine(salesRevenue);

        }
    }
}
