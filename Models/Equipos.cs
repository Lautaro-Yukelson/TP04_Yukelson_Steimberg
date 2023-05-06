using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP04_Yukelson_Steimberg.Models
{
    public static class Equipos
    {
        public static List<string> ListaEquipos { get; private set; }
        public static List<string> ListaMedias { get; private set; } = new List<string> { "medias1", "medias2", "medias3", "medias4", "medias5", "medias6", "medias7", "medias8", "medias9", "medias10" };
        public static List<string> ListaPantalones { get; private set; } = new List<string> { "pantalones1", "pantalones2", "pantalones3", "pantalones4", "pantalones5", "pantalones6", "pantalones7", "pantalones8", "pantalones9", "pantalones10" };
        public static List<string> ListaRemeras { get; private set; } = new List<string> { "remeras1", "remeras2", "remeras3", "remeras4", "remeras5", "remeras6", "remeras7", "remeras8", "remeras9", "remeras10" };
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