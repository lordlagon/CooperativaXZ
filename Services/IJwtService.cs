using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CooperativaXZ.Services
{
    public interface IJwtService
    {
        Task<string> GetTokenAsync();
        Task<bool> SaveTokenAsync(string Token);
        Task<bool> DestroyTokenAsync();
    }
}
