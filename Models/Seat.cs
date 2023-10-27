using System;
using System.Collections.Generic;

namespace Models
{
    public class Seat
    {
        public DateTime Timestamp { get; set; }
        public List<Movement> Movements { get; set; }

        public Seat()
        {
        }

        public Seat(DateTime timestamp, List<Movement> movements)
        {
            Timestamp = timestamp;
            Movements = movements;
        }
    }
}