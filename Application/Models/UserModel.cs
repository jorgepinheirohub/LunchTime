using System;

namespace Application.Models
{
    public class UserModel
    {
        public Guid Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Avatar { get; set; }
    }
}