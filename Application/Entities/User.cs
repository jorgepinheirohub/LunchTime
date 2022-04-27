using System;

namespace Application.Entities
{
    public class User
    {
        public Guid Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Avatar { get; set; }

        public void Alterar(User user)
        {
            Username = user.Username;
            Password = user.Password;
            Avatar = user.Avatar;
        }
    }
}