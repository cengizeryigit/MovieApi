﻿using Microsoft.AspNetCore.Mvc;
using MovieApi.Dto.Dtos.UserRegisterDtos;
using Newtonsoft.Json;
using System.Text;

namespace MovieApi.WebUI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public RegisterController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(CreateUserRegisterDto createUserRegisterDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createUserRegisterDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:7158/api/Registers", stringContent);

            if (response.IsSuccessStatusCode)
            {
               
                return RedirectToAction("SignIn", "Login");
            }
            ViewBag.error = "Başarısız Oldu";
            return View();

           
        }
    }
}
