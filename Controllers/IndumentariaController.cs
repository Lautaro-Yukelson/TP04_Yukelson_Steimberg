using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04_Yukelson_Steimberg.Models;

namespace TP04_Yukelson_Steimberg.Controllers
{
    public class IndumentariaController : Controller
    {
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
        public IActionResult GuardarIndumentaria(string equipo, string media, string pantalon, string remera)
        {
            ViewBag.algoCargado = false;{
            if (string.IsNullOrEmpty(media) || !Equipos.ListaMedias.Contains(media)) ViewBag.Error = "El parametro MEDIA ha sido mal cargado";
            else if (string.IsNullOrEmpty(pantalon) || !Equipos.ListaShorts.Contains(pantalon)) ViewBag.Error = "El parametro PANTALON ha sido mal cargado";
            else if (string.IsNullOrEmpty(remera) || !Equipos.ListaRemeras.Contains(remera)) ViewBag.Error = "El parametro REMERA ha sido mal cargado";
            else
            {
                Equipos.EquiposIndumentaria.Add(equipo, new Indumentaria(media, pantalon, remera));
                Equipos.algoCargado = true;
                ViewBag.Success = "La indumentaria se ha creado correctamente.";
            }
            }
            return View();
        }
    }
}
