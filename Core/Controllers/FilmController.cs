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
    public class FilmController : Controller
    {
        public IBaseRepository<Film> repf;
        public IBaseRepository<FilmTur> rept;

        FilmModel model = new FilmModel();
        FilmTurModel fm = new FilmTurModel();
      
        public FilmController(IBaseRepository<Film> _repf, IBaseRepository<FilmTur> _rept)
        {
            repf = _repf;
            rept = _rept;
        }
        public IActionResult Index()
        {
            model.fList= repf.Listele();
            model.ftList = rept.Listele();        
            return View(model);
        }

        public IActionResult Create()
        {
            model.ftList = rept.Listele();

            return View(model);
        }
        [HttpPost]
        public IActionResult Create(FilmModel fl)
        {
            if (ModelState.IsValid)
            {
                Film fls = new Film();
                fls.FilmAd = fl.Film.FilmAd;
                fls.FilmAciklama = fl.Film.FilmAciklama;
                fls.FilmResim = fl.Film.FilmResim;
                fls.FilmTurId = fl.Film.FilmTurId;
                repf.Ekle(fls);
                repf.Guncel();
                return RedirectToAction("Index");


            }
            return View();
        }


        public IActionResult Delete(int id)
        {
            Film fm = repf.Bul(id);
            repf.Sil(fm);
            repf.Guncel();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            model.Film= repf.Bul(id);
            model.ftList = rept.Listele();
            return View(model);
        }


        public IActionResult Edit(int id)
        {
            model.Film= repf.Bul(id);
            model.ftList = rept.Listele();

            return View(model);
        }


        [HttpPost]
        public IActionResult Edit(int id, FilmModel fm)
        {
            if (ModelState.IsValid)
            {
                Film f = repf.Bul(id);

                f.FilmAd = fm.Film.FilmAd;
                f.FilmAciklama = fm.Film.FilmAciklama;
                f.FilmResim = fm.Film.FilmResim;
                f.FilmTurId = fm.Film.FilmTurId;
                repf.Guncel();
                return RedirectToAction("Index");
            }
            return View();

        }


    }
}
