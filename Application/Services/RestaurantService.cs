using Application.Context;
using Application.Entities;
using Application.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;

namespace Application.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly DataContext _context;

        public RestaurantService(DataContext context)
        {
            _context = context;
        }

        public async Task<Restaurant> GetRestaurantById(Guid id)
        {
            return await _context.Restaurants.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<Restaurant> InsertRestaurant(Restaurant restaurant)
        {
            await _context.Restaurants.AddAsync(restaurant);
            await _context.SaveChangesAsync();

            return restaurant;
        }

        public async Task<Restaurant> UpdateRestaurant(Restaurant restaurant)
        {
            var oldRestaurant = await GetRestaurantById(restaurant.Id);

            if (oldRestaurant == null)
                return null;

            oldRestaurant.Alterar(restaurant);

            await _context.SaveChangesAsync();

            return oldRestaurant;
        }

        public async void DeleteRestaurant(Guid id)
        {
            var user = await GetRestaurantById(id);

            if (user == null)
                return;

            _context.Restaurants.Remove(user);
            await _context.SaveChangesAsync();
        }
    }
}