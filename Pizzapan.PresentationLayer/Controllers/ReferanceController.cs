using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;

namespace Pizzapan.PresentationLayer.Controllers
{
    public class ReferanceController : Controller
    {
        private readonly IReferanceService _referanceService;

        public ReferanceController(IReferanceService referanceService)
        {
            _referanceService = referanceService;
        }

        public IActionResult Index()
        {
            var values = _referanceService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddReferance()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddReferance(Referance referance)
        {
            _referanceService.TInsert(referance);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteReferance(int id)
        {
            var value = _referanceService.TGetByID(id);
            _referanceService.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateReferance(int id)
        {
            var value = _referanceService.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateReferance(Referance referance)
        {
            _referanceService.TUpdate(referance);
            return RedirectToAction("Index");
        }
    }
}
