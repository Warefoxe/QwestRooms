using QuestRooms.BLL.Servises.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuestRooms.UA.Controllers
{
    public class RoomController : Controller
    {
        private readonly IRoomsService roomsService;
        private readonly ICitiesService citiesService;

        public RoomController(IRoomsService _roomsService, ICitiesService _citiesService)
        {
            roomsService = _roomsService;
            citiesService = _citiesService;
        }
        // GET: Room
        public ActionResult Index()
        {
            var rooms = roomsService.GetRooms().ToList();
            var cities = citiesService.GetCities().ToList();
            ViewBag.Cities = cities;
            return View(rooms);
        }

        public ActionResult RoomDetails(int id)
        {
            var rooms = roomsService.GetRooms().ToList();
            return View(rooms.FirstOrDefault(r => r.ID == id));
        }

        public ActionResult RoomsByCity(int id)
        {
            var rooms = roomsService.GetRoomsbyCity(id);
            return PartialView("RoomsbyCity", rooms);
        }


    }
}