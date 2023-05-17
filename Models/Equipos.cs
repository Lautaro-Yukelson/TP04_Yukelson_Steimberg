using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TP04_Yukelson_Steimberg.Models
{
    public static class Equipos
    {
        public static List<string> ListaEquipos { get; private set; }
        public static List<string> ListaMedias { get; private set; } = new List<string> { "medias0", "medias1", "medias2", "medias3", "medias4", "medias5", "medias6", "medias7", "medias8", "medias9" };
        public static List<string> ListaShorts { get; private set; } = new List<string> { "shorts0", "shorts1", "shorts2", "shorts3", "shorts4", "shorts5", "shorts6", "shorts7", "shorts8", "shorts9" };
        public static List<string> ListaRemeras { get; private set; } = new List<string> { "remeras0", "remeras1", "remeras2", "remeras3", "remeras4", "remeras5", "remeras6", "remeras7", "remeras8", "remeras9" };
        public static Dictionary<string, Indumentaria> EquiposIndumentaria { get; private set; } = new Dictionary<string, Indumentaria>();
        public static bool algoCargado = false;

        public static bool IngresarIndumentaria(string equipoSeleccionado, Indumentaria item)
        {
            if (!EquiposIndumentaria.ContainsKey(equipoSeleccionado))
            {
                ListaEquipos.Add(equipoSeleccionado);
                EquiposIndumentaria.Add(equipoSeleccionado, item);
                return true;
            }
            return false;
        }
    }
}