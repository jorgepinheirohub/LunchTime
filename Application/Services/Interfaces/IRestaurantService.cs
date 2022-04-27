using Application.Entities;
using System.Threading.Tasks;
using System;

namespace Application.Services.Interfaces
{
    public interface IRestaurantService
    {
        Task<Restaurant> GetRestaurantById(Guid id);

        Task<Restaurant> InsertRestaurant(Restaurant restaurant);

        Task<Restaurant> UpdateRestaurant(Restaurant restaurant);

        void DeleteRestaurant(Guid id);
    }
}