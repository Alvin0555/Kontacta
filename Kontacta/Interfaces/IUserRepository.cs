using Kontacta.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kontacta.Interfaces
{
    internal interface IUserRepository
    {
        User? GetByUsername(string username);
    }
}
