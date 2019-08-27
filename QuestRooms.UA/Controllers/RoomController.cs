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

        public RoomController(IRoomsService _roomsService)
        {
            roomsService = _roomsService;
        }
        // GET: Room
        public ActionResult Index()
        {
            var rooms = roomsService.GetRooms().ToList();
            return View(rooms);
        }
    }
}