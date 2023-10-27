using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


namespace Data
{
    [Serializable]
    public class Blockchain
    {
        public List<Block> Blocks { get; set; }
        private const string PersistenceFile = "blockchain.json";
        
        public Blockchain()
        {
            Blocks = new List<Block>();
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
                var json = JsonConvert.SerializeObject(Blocks, Formatting.Indented);
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
            var genesisBlock = new Block(0, DateTime.Now, null, "First Hash", "0");
            Blocks.Add(genesisBlock);
            SaveBlockchainToFile();
        }
    }
}