using Application.Context;
using Application.Entities;
using Application.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;

namespace Application.Services
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserById(Guid id)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<User> InsertUser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task<User> UpdateUser(User user)
        {
            var oldUser = await GetUserById(user.Id);

            if (oldUser == null)
                return null;

            oldUser.Alterar(user);

            await _context.SaveChangesAsync();

            return oldUser;
        }

        public async void DeleteUser(Guid id)
        {
            var user = await GetUserById(id);

            if (user == null)
                return;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }
    }
}