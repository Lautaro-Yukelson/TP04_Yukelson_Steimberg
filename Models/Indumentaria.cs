using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP04_Yukelson_Steimberg.Models
{
    public class Indumentaria
    {
        public string Medias { get; private set; }
        public string Pantalon { get; private set; }
        public string Remera { get; private set; }

        public Indumentaria(string medias, string pantalon, string remera)
        {
            Medias = medias;
            Pantalon = pantalon;
            Remera = remera;
        }
    }
}