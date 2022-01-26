using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Fanex.Caching;
using Newtonsoft.Json;

namespace Olympus.CacheManipulator
{
    public interface CacheManipulator
    {
        Task<IList<T>> GetMultipleData<T>(string key);

        Task<T> GetSingleData<T>(string key, T defaultValue);

        Task RemoveData(string key);

        Task SaveData<T>(string key, T data, TimeSpan expired);
    }

    public class CacheManipulatorImp : CacheManipulator
    {
        private readonly ICache cache;

        public CacheManipulatorImp(ICache cache)
        {
            this.cache = cache;
        }

        public async Task<IList<T>> GetMultipleData<T>(string key)
        {
            (_, var value) = await cache.TryGetAsync<string>(key);
            var data = string.IsNullOrEmpty(value)
                ? new List<T>()
                : JsonConvert.DeserializeObject<List<T>>(value);

            return data;
        }

        public async Task<T> GetSingleData<T>(string key, T defaultValue)
        {
            (_, var value) = await cache.TryGetAsync<string>(key);
            var data = string.IsNullOrEmpty(value)
                ? defaultValue
                : JsonConvert.DeserializeObject<T>(value);

            return data;
        }

        public async Task RemoveData(string key)
            => await cache.RemoveAsync(key);

        public async Task SaveData<T>(string key, T data, TimeSpan expired)
        {
            var cachePolicy = new CacheItemOptions()
                .SetAbsoluteExpiration(expired);
            await cache.SetAsync(key, data, cachePolicy);
        }
    }
}
