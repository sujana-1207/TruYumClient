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

            client.BaseAddress = new Uri("https://localhost:44301");
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

            client.BaseAddress = new Uri("https://localhost:44301");
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
            // GET: Cart/Details/5
            public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cart/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cart/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cart/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cart/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cart/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cart/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}