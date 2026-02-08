using Kontacta.Interfaces;
using Kontacta.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kontacta.Services
{
    internal class InMemoryUserRepository : IUserRepository
    {
        private readonly List<User> _users = new()
    {
        new User
        {
            Id = 1,
            Username = "admin",
            PasswordHash = Hash("admin123"),
            Role = "Admin"
        }
    };
        public User? GetByUsername(string username)
        {
            return _users.FirstOrDefault(u =>
            u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)
            );
        }

        private static string Hash(string password)
        {
            using var sha = System.Security.Cryptography.SHA256.Create();
            return Convert.ToBase64String(
                sha.ComputeHash(Encoding.UTF8.GetBytes(password))
                );
        }
    }
}
