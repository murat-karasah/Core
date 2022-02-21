using Core.Controllers.Repository;
using Core.Models;
using Core.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Controllers
{
    public class FilmTurController : Controller
    {
        public IBaseRepository<FilmTur> rep;
        FilmTurModel fmodel = new FilmTurModel();
        public FilmTurController(IBaseRepository<FilmTur> _rep)
        {
            rep = _rep;
        }
        public IActionResult Index()
        {
            fmodel.ftList = rep.Listele();
            
            return View(fmodel);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(FilmTurModel ft)
        {
            if (ModelState.IsValid)
            {
                FilmTur f = new FilmTur();
                f.TurAd= ft.FilmTur.TurAd;
                rep.Ekle(f);
                rep.Guncel();
                return RedirectToAction("Index");
            }

            return View();
        }


        public IActionResult Edit(int id)
        {
            fmodel.FilmTur = rep.Bul(id);
            return View(fmodel);
        }
        [HttpPost]
        public IActionResult Edit(int id,FilmTurModel ft)
        {
            if (ModelState.IsValid)
            {
                FilmTur f = rep.Bul(id);

                f.TurAd = ft.FilmTur.TurAd;
                rep.Guncel();
                return RedirectToAction("Index");
            }
            return View();

        }

        public IActionResult Details(int id)
        {
            fmodel.FilmTur = rep.Bul(id);
            return View(fmodel);
        }

        public IActionResult Delete(int id)
        {
            FilmTur ft = rep.Bul(id);
            rep.Sil(ft);
            rep.Guncel();
            return RedirectToAction("Index");
        }

    }
}
