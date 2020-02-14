using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using TestingCosmos.models;

namespace TestingCosmos.controllers
{
    public class HomController : Controller
    {

        private readonly IConfiguration Config;

        public HomController(IConfiguration config)
        {
            Config = config;
        }

        public HomeData GetHmeDate()
        {
            HomeData homeData = new HomeData();

            homeData.ParentChildOne = Config["Parent:ChildOne"];
            homeData.ParentChildTwo = Config["Parent:ChildTwo"];


            return homeData;


        }
        public IActionResult Index()
        {
            ViewData["Parent:ChildOne"] = Config["Parent:ChildOne"];
            ViewData["Parent:ChildTwo"] = Config["Parent:ChildTwo"];
            ViewData["ConnectionStrings:Parent:ChildTwo"] = Config["ConnectionStrings:Parent:ChildTwo"];
            ViewData["CUSTOMCONNSTR_Parent:ChildTwo"] = Config.GetConnectionString("Parent:ChildTwo");

            return View();
        }
    }
}