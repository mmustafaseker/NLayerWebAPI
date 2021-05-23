using Newtonsoft.Json;
using NLayerProject.Web.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Web.ApiService
{
    public class ProductApiService
    {
        private readonly HttpClient _httpClient;

        public ProductApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<ProductDto>> GetAllAsync()
        {
            IEnumerable<ProductDto> productDto;
            var response = await _httpClient.GetAsync("Products");
            if (response.IsSuccessStatusCode)
            {
                productDto = JsonConvert.DeserializeObject<IEnumerable<ProductDto>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                productDto = null;
            }
            return productDto;
        }

        public async Task<ProductDto> AddAsync(ProductDto productDto)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(productDto), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("Products", stringContent);
            if (response.IsSuccessStatusCode)
            {
                productDto = JsonConvert.DeserializeObject<ProductDto>(await response.Content.ReadAsStringAsync());
                return productDto;
            }
            else
            {
                return null;
            }
        }

        public async Task<ProductDto> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"Products/{id}");
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ProductDto>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                return null;
            }
        }
        public async Task<bool> Update(ProductDto productDto)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(productDto), Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync("Products", stringContent);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<bool> Remove(int id)
        {
            var response = await _httpClient.DeleteAsync($"Products/{id}");
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
