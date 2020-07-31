using Microsoft.AspNetCore.Mvc;
using MyPlace.Data;
using MyPlace.Helpers;
using MyPlace.Services.Interfaces;
using MyPlace.ViewModels;
using System.Linq;

namespace MyPlace.Controllers
{
    public class ImageController : Controller
    {
        private readonly IImageService imageService;

        public ImageController(IImageService imageService)
        {
            this.imageService = imageService;
        }

        public IActionResult Overview(string username)
        {
            var images = imageService.GetByUsername(username)
                .Select(x => x.ConvertToImageViewModel())
                .ToList();
            return View(images);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var image = new UserImage();

            return View(image);
        }


        [HttpPost]
        public IActionResult Create(UserImageViewModel userImage)
        {
            if (ModelState.IsValid)
            {
                imageService.CreateMovie(userImage.ConvertToImageEntity());
                return RedirectToAction("Overview");
            }
            else
            {
                return View(userImage);
            }
        }

        public IActionResult ModifyOverview()
        {
            var images = imageService.GetAll()
                .Select(x => x.ConvertToImageViewModel())
                .ToList();

            return View(images);
        }


        public IActionResult ModifyImage(int id)
        {
            var image = imageService.GetById(id)
                .ConvertToImageViewModel();

            return View(image);
        }


        [HttpPost]
        public IActionResult ModifyImage(UserImageViewModel image)
        {
            if (ModelState.IsValid)
            {
                imageService.Update(image.ConvertToImageEntity());
                return RedirectToAction("ModifyOverview");
            }

            return View(image);
        }

        public IActionResult Delete(int id)
        {
            imageService.Delete(id);
            return RedirectToAction("ModifyOverview");
        }
    }
}
