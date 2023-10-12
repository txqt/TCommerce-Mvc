﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using T.Library.Model.Roles.RoleName;
using T.Web.Attribute;
using T.Web.Models;
using T.Web.Services.HomePageServices;

namespace T.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHomePageService _homePageService;
        //private readonly ISliderItemService _sliderItemService;

        public HomeController(ILogger<HomeController> logger, IHomePageService homePageService/*, ISliderItemService sliderItemService*/)
        {
            _logger = logger;
            _homePageService = homePageService;
            //_sliderItemService = sliderItemService;
        }

        public IActionResult Index()
        {
            return View();
        }

        //[HttpGet]
        //public async Task<IActionResult> GetAllSliderItemAsync()
        //{
        //    var sliderItemList = await _sliderItemService.GetAllSliderItemAsync();

        //    return View(sliderItemList);
        //}

        [HttpGet]
        public async Task<IActionResult> ShowCategoriesOnHomePage()
        {
            var listModel = await _homePageService.ShowCategoriesOnHomePage();
            return Json(new { data = listModel });
        }

        //[CustomAuthorizationFilter(RoleName.Customer)]
        public IActionResult Privacy()
        {
            return View();
        }
    }
}