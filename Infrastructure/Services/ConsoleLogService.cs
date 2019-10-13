using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace CooperativaXZ
{
    public interface IConsoleLogService
    {
        Task<bool> LogAsync(string LogString);
    }
    public class ConsoleLogService : IConsoleLogService
    {
        private readonly IJSRuntime jsRuntime;

        public ConsoleLogService(IJSRuntime _jsRuntime)
        {
            jsRuntime = _jsRuntime;
        }

        public async Task<bool> LogAsync(string LogString)
        {
            return await jsRuntime.InvokeAsync<bool>("CooperatixaXZ.consoleLog", LogString);
        }
    }
}