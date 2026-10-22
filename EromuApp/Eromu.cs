using System;
using System.Collections.Generic;
using System.Text;

namespace EromuApp
{
    public class Eromu
    {
        string Azonosito { get; set; }
        protected int kapacitasKW;
        public int KapacitasKW { 
            get { return kapacitasKW; }
            set
            {
                if (value <= 0)
                {
                   value == 100;
                }
            } 
        }
        private static int osszesEromuSzama;
        public int OsszesEromuSzama { get; }

        public Eromu(string azonosito, int kapacitasKW, int osszesEromuSzama)
        {
            Azonosito = azonosito;
            KapacitasKW = kapacitasKW;
            OsszesEromuSzama = osszesEromuSzama;
        }

        public virtual int NapiTermeles(int orakSzama)
        {
            return KapacitasKW * orakSzama;
        }

        public override string ToString()
        {
            return $"Erőmű [Azonosito] | Kapacitás: [KapacitasKW] kW";
        }
    }
}
