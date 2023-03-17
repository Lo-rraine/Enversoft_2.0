using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Enversoft.Models;
using Enversoft.Controllers;

namespace EnverFrontend.Services
{
    public class SupplierService
    {
        private readonly HttpClient _httpClient;

        public SupplierService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Supplier>> GetAllSuppliers()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Supplier>>("/api/Suppliers");
        }

        public async Task AddSupplier(Supplier supplier)
        {
            await _httpClient.PostAsJsonAsync("/api/Suppliers", supplier);
        }
    }
}
