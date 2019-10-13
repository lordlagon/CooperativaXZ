using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace CooperativaXZ
{
    public interface IJwtService
    {
        Task<string> GetTokenAsync();
        Task<bool> SaveTokenAsync(string Token);
        Task<bool> DestroyTokenAsync();
    }
    public class JwtService : IJwtService
    {
        private readonly IJSRuntime jsRuntime;

        public JwtService(IJSRuntime _jsRuntime)
        {
            jsRuntime = _jsRuntime;
        }

        public async Task<string> GetTokenAsync()
        {
            return await jsRuntime.InvokeAsync<string>("CooperativaXZ.getToken");
        }

        public async Task<bool> SaveTokenAsync(string Token)
        {
            return await jsRuntime.InvokeAsync<bool>("CooperativaXZ.saveToken", Token);
        }

        public async Task<bool> DestroyTokenAsync()
        {
            return await jsRuntime.InvokeAsync<bool>("CooperativaXZ.destroyToken");
        }
    }
}
