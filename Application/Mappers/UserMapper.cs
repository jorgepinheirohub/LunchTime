using Application.Entities;
using Application.Models;
using System.Collections.Generic;
using System.Linq;

namespace Application.Mappers
{
    public static class UserMapper
    {
        public static UserModel Map(User user)
        {
            return new UserModel()
            {
                Id = user.Id,
                Username = user.Username,
                Avatar = user.Avatar,
            };
        }

        public static User Map(UserModel user)
        {
            return new User()
            {
                Id = user.Id,
                Username = user.Username,
                Avatar = user.Avatar,
            };
        }

        public static IEnumerable<UserModel> Map(IEnumerable<User> users)
        {
            return users.Select(Map).ToList();
        }

        public static IEnumerable<User> Map(IEnumerable<UserModel> users)
        {
            return users.Select(Map).ToList();
        }
    }
}