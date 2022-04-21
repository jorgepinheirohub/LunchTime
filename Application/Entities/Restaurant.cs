using System;

namespace lunchtime.Entities
{
    public class Restaurant
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Votes { get; set; }
    }
}