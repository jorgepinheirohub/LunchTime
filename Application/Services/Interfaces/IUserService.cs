using Application.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace Application.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> GetUserById(Guid id);

        Task<IEnumerable<User>> GetUserList();

        Task<User> InsertUser(User user);

        Task<User> UpdateUser(User user);

        void DeleteUser(Guid id);
    }
}