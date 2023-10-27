﻿using System;
using System.Collections.Generic;
using System.IO;
using Models;

namespace Data
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var blockchain = new Blockchain();

            Console.WriteLine(File.Exists("blockchain.json") ? "Created." : "Ups");

            Account a1 = new Account(1, FinancialState.Activo, "Caja");
            Account a2 = new Account(2, FinancialState.Activo, "Mercadería");

            Movement m1 = new Movement(1000, 0, a1);
            Movement m2 = new Movement(0, 1000, a2);
            List<Movement> movements = new List<Movement>() { m1, m2 };

            Seat seat = new Seat(DateTime.Now, movements);
            List<Seat> seats = new List<Seat>() { seat };

            Block block = new Block(1, DateTime.Now, seats, "Un hash inventado",
                "D835BA9BD7288F390C4A6CBAAD4A8BDD828FF5FA2418773F751E05845899E97B");
            
            blockchain.AddBlock(block);
        }
    }
}