using System;
using System.Collections.Generic;
using System.IO;
using Models;
using Newtonsoft.Json;
using Formatting = System.Xml.Formatting;


namespace Data
{
    [Serializable]
    public class Blockchain
    {
        //atributos
        private List<Block> blocks = new List<Block>();
        private List<Seat> tempAccount = new List<Seat>();
        private const string PersistenceFile = "blockchain.json";


        //getters and setters
        public List<Block> Blocks { get => blocks; set => blocks = value; }
        public List<Seat> _TempAccount { get => tempAccount; set => tempAccount = value; }

        public Blockchain()
        {
        }

        public Blockchain(List<Block> blocks, List<Seat> tempAccount)
        {
            Blocks = blocks;
            _TempAccount = tempAccount;
            if (File.Exists(PersistenceFile))
            {
                LoadBlockchainFromFile();
            }
            else
            {
                AddGenesisBlock();
            }
        }
        
        private void LoadBlockchainFromFile()
        {
            try
            {
                var json = File.ReadAllText(PersistenceFile);
                Blocks = JsonConvert.DeserializeObject<List<Block>>(json);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error loading blockchain from file: " + e.Message);
            }
        }

        private void SaveBlockchainToFile()
        {
            try
            {
                var json = JsonConvert.SerializeObject(Blocks, (Newtonsoft.Json.Formatting)Formatting.Indented);
                File.WriteAllText(PersistenceFile, json);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error saving blockchain to file: " + e.Message);
            }
        }
        
        public void AddBlock(Block block)
        {
            Blocks.Add(block);
            SaveBlockchainToFile();
        }

        private void AddGenesisBlock()
        {
            var genesisBlock = new Block(0, DateTime.Now, null, "0");
            Blocks.Add(genesisBlock);
            SaveBlockchainToFile();
        }
    }
}