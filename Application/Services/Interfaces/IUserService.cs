using Application.Entities;
using System;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> GetUserById(Guid id);

        Task<User> InsertUser(User user);

        Task<User> UpdateUser(User user);

        void DeleteUser(Guid id);
    }
}