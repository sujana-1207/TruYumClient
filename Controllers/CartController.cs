using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TruYumClient.Models;

namespace TruYumClient.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public async Task<IActionResult> AddToCart(MenuItem model)
        {
            /*if (HttpContext.Session.GetString("Logged In") == null)
            {
               return RedirectToAction("Login", "Login");
            }*/
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);

            client.BaseAddress = new Uri("https://truyumcart.azurewebsites.net");
            var jsonstring = JsonConvert.SerializeObject(model);
            var message = new StringContent(jsonstring, System.Text.Encoding.UTF8, "application/json");
            var response = await client.PostAsync("/api/Cart", message);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {

                return RedirectToAction("GetCart");
            }
            return RedirectToAction("GetCart");
        }
        public async Task<IActionResult> GetCart()
        {
            /*if (HttpContext.Session.GetString("Logged In") == null)
            {
                return RedirectToAction("Login", "Login");
            }*/
            var client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);

            client.BaseAddress = new Uri("https://truyumcart.azurewebsites.net");
            var response = await client.GetAsync("/api/Cart");
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonContent = await response.Content.ReadAsStringAsync();
                var cartitems = JsonConvert.DeserializeObject<List<MenuItem>>(jsonContent);
                if ( cartitems == null)
                    return View("Empty Cart");
                ViewBag.items = cartitems;
                return View("GetCart");
            }
            return View("EmptyCart");


            }
       
    }
}
