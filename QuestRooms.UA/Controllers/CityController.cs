using QuestRooms.BLL.Servises.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuestRooms.UA.Controllers
{
    public class CityController : Controller
    {
        private readonly ICitiesService citiesService;

        public CityController(ICitiesService _citiesService)
        {
            citiesService = _citiesService;
        }
        // GET: City
        public string Index()
        {
            var cities = citiesService.GetCities();
            return "Hello";
        }
    }
}