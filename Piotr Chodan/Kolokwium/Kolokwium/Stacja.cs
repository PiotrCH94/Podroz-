using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Stacja : ICloneable
    {
        private string nazwaStacji;
        private bool oplataKlimatyczna; 
        {
            oplataKlimatyczna = true;
            return MemberwiseClone();
        }    
        public Stacja (string nazwaStacji, bool oplataKlimatyczna)
{
    this.nazwaStacji = nazwaStacji;
    this.oplataklimatyczna = oplataKlimatyczna;
}
        public JakaOplata()
{
    return oplataKlimatyczna;
}
    }
}
