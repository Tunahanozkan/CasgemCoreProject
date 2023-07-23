using Microsoft.AspNetCore.Mvc;
using Pizzapan.EntityLayer.Concrete;
using PizzaPan.BusinessLayer.Abstract;

namespace Pizzapan.PresentationLayer.ViewComponents.Default
{
    public class _AboutOurTeamPartial : ViewComponent
    {
        private readonly IOurTeamService _teamService;

        public _AboutOurTeamPartial(IOurTeamService teamService)
        {
            _teamService = teamService;
        }

        public IViewComponentResult Invoke()
        {   
            var values = _teamService.TGetList();
            return View(values);
        }
    }
}
