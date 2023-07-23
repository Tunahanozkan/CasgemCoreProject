using Microsoft.AspNetCore.Mvc;
using PizzaPan.BusinessLayer.Abstract;

namespace Pizzapan.PresentationLayer.ViewComponents.Default
{
    public class _MenuSpecialPartial : ViewComponent
    {
        private readonly IProductService _productService;

        public _MenuSpecialPartial(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            int iterations = 4;
            var values = _productService.TGetList();
            return View(values);
        }
    }
}
