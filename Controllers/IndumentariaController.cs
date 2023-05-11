using System.IO;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using TP04_Yukelson_Steimberg.Models;

namespace TP04_Yukelson_Steimberg.Controllers
{
    public class IndumentariaController : Controller
    {
        private IWebHostEnvironment Environment;

        public IndumentariaController(IWebHostEnvironment environment){
            Environment = environment;
        }
        public IActionResult Index()
        {
            ViewBag.dicEquipos = Equipos.EquiposIndumentaria;
            ViewBag.algoCargado = Equipos.algoCargado;
            return View();
        }

        public IActionResult SelectIndumentaria()
        {
            ViewBag.ListaEquipos = Equipos.ListaEquipos;
            ViewBag.ListaMedias = Equipos.ListaMedias;
            ViewBag.ListaShorts = Equipos.ListaShorts;
            ViewBag.ListaRemeras = Equipos.ListaRemeras;
            return View();
        }

        [HttpPost]
        public IActionResult GuardarIndumentaria(string equipo, string media, string shorts, string remera)
        {
            ViewBag.algoCargado = false;
            if (string.IsNullOrEmpty(media) || !Equipos.ListaMedias.Contains(media)) ViewBag.Error = "El parametro MEDIA ha sido mal cargado";
            else if (string.IsNullOrEmpty(shorts) || !Equipos.ListaShorts.Contains(shorts)) ViewBag.Error = "El parametro SHORT ha sido mal cargado";
            else if (string.IsNullOrEmpty(remera) || !Equipos.ListaRemeras.Contains(remera)) ViewBag.Error = "El parametro REMERA ha sido mal cargado";
            else
            {
                Equipos.EquiposIndumentaria.Add(equipo, new Indumentaria(media, shorts, remera));
                Equipos.algoCargado = true;
                ViewBag.Success = "La indumentaria se ha creado correctamente.";
            }
            return View();
        }

        public IActionResult SubirIndumentaria()
        {
            ViewBag.algo = "NICE";
            return View();
        }

        [HttpPost]
        public void SubirNuevaIndumentaria(string nombre, string categoria, IFormFile MyFile){
            if (MyFile.Length>0){
                string wwwRootLocal = this.Environment.ContentRootPath + @$"\wwwroot\assets\{categoria}\{MyFile.FileName}";
                using (var stream = System.IO.File.Create(wwwRootLocal)){
                    MyFile.CopyToAsync(stream);
                }
            }
        }
    }
}
