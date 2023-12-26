using Company.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Company.MVC.Controllers
{
    public class PersonelController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public PersonelController(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = new HttpClient();
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetPersonelList()
        {
            var apiUrl = _configuration.GetValue<string>("Api:Url");

            List<Personel> personelList = new List<Personel>();
            HttpResponseMessage responseMessage = _httpClient.GetAsync(apiUrl + "Personel/GetPersonelList").Result;

            if (responseMessage.IsSuccessStatusCode)
            {
                string data = responseMessage.Content.ReadAsStringAsync().Result;
                personelList = JsonConvert.DeserializeObject<List<Personel>>(data);
            }
            return View(personelList);
        }

        public IActionResult GetPersonelListWithSignalR()
        {
            return View();
        }


    }
}
