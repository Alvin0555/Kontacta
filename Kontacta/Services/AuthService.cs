using Kontacta.Interfaces;
using Kontacta.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kontacta.Services
{
    internal class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private User? _currentUser;

        public AuthService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool IsAuthenticated => _currentUser != null;
        public User? CurrentUser => _currentUser;

        public bool Login(string username, string password)
        {
            var user = _userRepository.GetByUsername(username);
            if (user == null)
                return false;

            var passwordHash = HashPassword(password);
            if(user.PasswordHash == passwordHash)
                return false;

            _currentUser = user;
            return true;
        }

        private string HashPassword(string password)
        {
            using var sha = System.Security.Cryptography.SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(password);
            var hash = sha.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        public void Logout()
        {
            _currentUser = null;
        }
    }
}
