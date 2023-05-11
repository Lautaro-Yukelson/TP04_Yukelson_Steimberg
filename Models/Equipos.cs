using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TP04_Yukelson_Steimberg.Models
{
    public static class Equipos
    {
        public static List<string> ListaEquipos { get; private set; }
        public static List<string> ListaMedias { get; private set; } = new List<string> { "Atlanta.webp", "Banfield.webp", "Boca.webp", "Huracan.webp", "Independiente.webp", "Racing.webp", "River.webp", "Sacachispas.webp", "San-Lorenzo.webp", "Velez.webp" };
        public static List<string> ListaShorts { get; private set; } = new List<string> { "Atlanta.webp", "Banfield.webp", "Boca.webp", "Huracan.webp", "Independiente.webp", "Racing.webp", "River.webp", "Sacachispas.webp", "San-Lorenzo.webp", "Velez.webp" };
        public static List<string> ListaRemeras { get; private set; } = new List<string> { "Atlanta.webp", "Banfield.webp", "Boca.webp", "Huracan.webp", "Independiente.webp", "Racing.webp", "River.webp", "Sacachispas.webp", "San-Lorenzo.webp", "Velez.webp" };
        public static Dictionary<string, Indumentaria> EquiposIndumentaria { get; private set; } = new Dictionary<string, Indumentaria>();
        public static bool algoCargado = false;

        public static bool IngresarIndumentaria(string equipoSeleccionado, Indumentaria item)
        {
            if (!EquiposIndumentaria.ContainsKey(equipoSeleccionado))
            {
                EquiposIndumentaria.Add(equipoSeleccionado, item);
                return true;
            }
            return false;
        }
    }
}