using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticaWeb3junio8.Models;
using PracticaWeb3junio8.Repositorios;
using PracticaWeb3junio8.Servicios;
using System.Collections.Generic;

namespace PracticaWeb3junio8.Controllers
{
    public class AnimalController : Controller
    {
        // GET: AnimalController
        public ActionResult ListarAnimales()
        {
            _20221CPracticaEFContext ctx = new _20221CPracticaEFContext();
            AnimalRepositorio animalRepositorio = new AnimalRepositorio(ctx);
            AnimalServicio animalServicio = new AnimalServicio(animalRepositorio);

            List<Animal> animales = animalServicio.ObtenerTodos();

            return View(animales);
        }

        public IActionResult Index()
        {
            return View();
        }


        // GET: AnimalController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AnimalController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnimalController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AnimalController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AnimalController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AnimalController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AnimalController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
