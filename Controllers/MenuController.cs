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
    public class MenuController : Controller
    {
        // GET: Menu
        public async  Task<ActionResult> ViewMenu()
        {
            /*if (HttpContext.Session.GetString("Logged In") == null)
            {
                return RedirectToAction("Login", "Login");
            }*/
            
            var client = new HttpClient();

            client.BaseAddress = new Uri("https://localhost:44341");
            /*var jsonstring = JsonConvert.SerializeObject(model);
            var message = new StringContent(jsonstring, System.Text.Encoding.UTF8, "application/json");
            var id = message.ReadAsStringAsync().Result;*/
            var response = await client.GetAsync("/api/MenuItem");
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonContent = await response.Content.ReadAsStringAsync();
                var menuItems= JsonConvert.DeserializeObject<List<MenuItem>>(jsonContent);
                ViewBag.mod = menuItems;
                return View();
            }
            else
            {
                return View("EmptyMenu");
            }
        }

        

        // GET: Menu/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Menu/Create
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

        // GET: Menu/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Menu/Edit/5
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

        // GET: Menu/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Menu/Delete/5
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