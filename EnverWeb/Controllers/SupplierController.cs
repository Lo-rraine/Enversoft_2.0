using Enversoft.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using System.Net.Http.Formatting;
using System.Xml.Linq;


namespace EnverWeb.Controllers
{
    public class SupplierController : Controller
    {
        private readonly HttpClient _httpClient;

        public SupplierController(HttpClient httpClient)
        {
            _httpClient = httpClient;
            //_httpClient.BaseAddress = new Uri("https://localhost:7100"); // Replace with your API's URL
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetAsync("https://localhost:7100/api/Suppliers");
            var content = await response.Content.ReadAsStringAsync();
            var suppliers = JsonConvert.DeserializeObject<List<Supplier>>(content);

            return View(suppliers);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Supplier supplier)
        {
            var json = JsonConvert.SerializeObject(supplier);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("https://localhost:7100/api/Suppliers", content);

            if (!response.IsSuccessStatusCode)
            {
                return BadRequest();
                return View();
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Search()
        {
            return View();
        }

        // GET: api/Suppliers
        [HttpGet]
        public async Task<IActionResult> Search(string searchString)
        {
            var suppliers = Enumerable.Empty<Supplier>();

            if (!string.IsNullOrEmpty(searchString))
            {
                var response = await _httpClient.GetAsync($"https://localhost:7100/api/Suppliers?name={searchString}");

                if (response.IsSuccessStatusCode)
                {
                    suppliers = await response.Content.ReadAsAsync<IEnumerable<Supplier>>();
                    suppliers = suppliers.Where(s => s.Name.ToLower().Contains(searchString.ToLower()));
                }
            }

            return View(suppliers);
        }


    }
}
