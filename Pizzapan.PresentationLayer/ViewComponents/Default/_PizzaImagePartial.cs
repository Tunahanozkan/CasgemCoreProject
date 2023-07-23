using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;

namespace Pizzapan.PresentationLayer.ViewComponents.Default
{
    public class _PizzaImagePartial : ViewComponent
    {
        private readonly IProductImageService _productImageService;

        public _PizzaImagePartial(IProductImageService productImageService)
        {
            _productImageService = productImageService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _productImageService.TGetList();
            return View(values);
        }
    }
}
