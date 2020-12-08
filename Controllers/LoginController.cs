using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TruYumClient.Models;

namespace TruYumClient.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(User model)
        {
            if (!ModelState.IsValid)
            {
                
                return View(model);
            }
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44323");
            var jsonstring = JsonConvert.SerializeObject(model);
            var message = new StringContent(jsonstring, System.Text.Encoding.UTF8, "application/json");
            var response = await client.PostAsync("/api/Auth", message);
            if (!response.IsSuccessStatusCode)
            {
                return View();
            }
            string stringJWT = await response.Content.ReadAsStringAsync();

            HttpContext.Session.SetString("Logged In", "1");
            return View("SelectAction");
        }
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Login");
        }
    }
}