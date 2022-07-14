using Microsoft.JSInterop;
using System.Text.Json;
using System.Threading.Tasks;

namespace LogisticsCenterAPP.Services
{

    public interface ISessionStorageServices 
    {
        Task<T> GetItem<T>(string key);
        Task SetItem<T>(string key, T value);
        Task RemoveItem(string key);
        ValueTask<string> GetFromSessionStorage(string key);
    }  
    public class SessionStorageServices : ISessionStorageServices
    {
        private IJSRuntime _jsRuntime;

        public SessionStorageServices(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task<T> GetItem<T>(string key)
        {
            var json = await _jsRuntime.InvokeAsync<string>("sessionStorage.getItem", key);

            if (json == null)
                return default;

            return JsonSerializer.Deserialize<T>(json);
        }
        public ValueTask<string> GetFromSessionStorage(string key)
        {
            return _jsRuntime.InvokeAsync<string>("sessionStorage.getItem", key);
        }
        public async Task SetItem<T>(string key, T value)
        {
            await _jsRuntime.InvokeVoidAsync("sessionStorage.setItem", key, JsonSerializer.Serialize(value));
        }

        public async Task RemoveItem(string key)
        {
            await _jsRuntime.InvokeVoidAsync("sessionStorage.removeItem", key);
        }
    }
}
