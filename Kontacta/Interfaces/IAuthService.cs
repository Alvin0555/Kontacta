using Kontacta.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kontacta.Interfaces
{
    internal interface IAuthService
    {
        bool Login(string username, string password);
        void Logout();
        bool IsAuthenticated { get; }
        User? CurrentUser { get; }
    }
}
