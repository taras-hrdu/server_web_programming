using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppOrmEntity.Context;
using AppOrmEntity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AppOrmEntity.Repositories;

namespace AppOrmEntity.Controllers
{
    public class SageController : Controller
    {
        private readonly ISageRepository _sageRepository;

        public SageController(ISageRepository sageRepository)
        {
            _sageRepository = sageRepository;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var currentSage = _sageRepository.GetSageById(id);

            return View(currentSage);
        }

        [HttpPost]
        public IActionResult Create(Sage sage, IFormFile photo)
        {
            if (photo != null && photo.Length > 0)
            {
                var fileName = Path.GetFileName(photo.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    photo.CopyTo(stream);
                }

                sage.Photo = "/images/" + fileName;
            }
            _sageRepository.AddSage(sage);

            return RedirectToAction("Index", "Admin");
        }

        [HttpPost]
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                _sageRepository.DeleteSage(id.Value);
            }
            return RedirectToAction("Index", "Admin");
        }

        [HttpPost]
        public IActionResult Update(int id, Sage sage, IFormFile photo)
        {
            var currentSage = _sageRepository.GetSageById(id);

            currentSage.Name = sage.Name;
            currentSage.Age = sage.Age;
            currentSage.City = sage.City;

            if (photo != null && photo.Length > 0)
            {
                var fileName = Path.GetFileName(photo.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    photo.CopyTo(stream);
                }

                currentSage.Photo = "/images/" + fileName;
            }

            _sageRepository.UpdateSage(currentSage);

            return RedirectToAction("Index", "Admin");
        }
    }
}
