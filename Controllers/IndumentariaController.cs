using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04_Yukelson_Steimberg.Models;

namespace TP04_Yukelson_Steimberg.Controllers;

public class IndumentariaController : Controller
{
    public IActionResult Index()
    {
        ViewBag.dicEquipos = Equipos.EquiposIndumentaria;
        return View();
    }

    public IActionResult SelectIndumentaria()
    {
        return View();
    }

    public IActionResult GuardarIndumentaria(int equipo, int media, int pantalon, int remera)
    {
        return View();
    }
}
