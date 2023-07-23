using Microsoft.AspNetCore.Mvc;
using Pizzapan.EntityLayer.Concrete;
using PizzaPan.BusinessLayer.Abstract;

namespace Pizzapan.PresentationLayer.Controllers
{
    public class OurTeamController : Controller
    {
        private readonly IOurTeamService _teamService;

        public OurTeamController(IOurTeamService teamService)
        {
            _teamService = teamService;
        }
        public IActionResult Index()
        {
            var values = _teamService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddOurTeam()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddOurTeam(OurTeam ourTeam)
        {
            _teamService.TInsert(ourTeam);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteOurTeam(int id)
        {
            var value = _teamService.TGetByID(id);
            _teamService.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateOurTeam(int id)
        {
            var value = _teamService.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateOurTeam(OurTeam ourTeam)
        {
            _teamService.TUpdate(ourTeam);
            return RedirectToAction("Index");
        }
    }
}
