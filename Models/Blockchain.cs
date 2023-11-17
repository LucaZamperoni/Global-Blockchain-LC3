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
        
        private List<Block> blocks = new List<Block>();
        //private const string PersistenceFile = "blockchain.json";


        //getters and setters
        public List<Block> Blocks { get => blocks; set => blocks = value; }

        public Blockchain()
        {
        }

        public Blockchain(List<Block> blocks)
        {
            Blocks = blocks;
            
        }
        
    }
}