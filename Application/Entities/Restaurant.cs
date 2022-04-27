using System;

namespace Application.Entities
{
    public class Restaurant
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Votes { get; set; }

        public void Alterar(Restaurant restaurant) => Name = restaurant.Name;
    }
}