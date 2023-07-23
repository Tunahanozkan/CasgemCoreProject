using Microsoft.AspNetCore.Mvc;
using Pizzapan.EntityLayer.Concrete;
using Pizzapan.PresentationLayer.Models;
using PizzaPan.BusinessLayer.Abstract;
using System.IO;
using System;

namespace Pizzapan.PresentationLayer.Controllers
{
    public class GaleryController : Controller
    {
        private readonly IProductImageService _imageService;

        public GaleryController(IProductImageService imageService)
        {
            _imageService = imageService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ImageFileViewModel model)
        {
            var resource = Directory.GetCurrentDirectory();
            var extension = Path.GetExtension(model.Image.FileName);
            var imageName = Guid.NewGuid() + extension;
            var saveLocation = resource + "/wwwroot/images/" + imageName;
            var stream = new FileStream(saveLocation, FileMode.Create);
            model.Image.CopyTo(stream);
            ProductImage productImage = new ProductImage();
            productImage.ImageUrl = imageName;
            _imageService.TInsert(productImage);

            return RedirectToAction("Index");
        }
    }
}
