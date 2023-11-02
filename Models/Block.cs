using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using Models;

namespace Data
{
    [Serializable]
    public class Block
    {
        public int Index { get; set; }
        public DateTime Timestamp { get; set; }
        public List<Seat> Seats { get; set; }
        public string Hash { get; set; }
        public string PreviousHash { get; set; }
        
        public Block(){}

        public Block(int index, DateTime timestamp, List<Seat> seats, string previousHash)
        {
            Index = index;
            Timestamp = timestamp;
            Seats = seats;
            Hash = CalculateHash();
            PreviousHash = previousHash;
        }
        
        public string CalculateHash()
        {
            var data = $"{Index}{Timestamp}{PreviousHash}{Seats}";
            using (var sha256 = SHA256.Create())
            {
                var bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(data));
                return BitConverter.ToString(bytes).Replace("-", string.Empty);
            }
        }
    }
}