using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP04_Yukelson_Steimberg.Models
{
    public class Indumentaria
    {
        public string Media { get; private set; }
        public string Short { get; private set; }
        public string Remera { get; private set; }

        public Indumentaria(string medias, string shorts, string remera)
        {
            Media = medias;
            Short = shorts;
            Remera = remera;
        }
    }
}