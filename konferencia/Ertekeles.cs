using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konferencia
{
    internal class Ertekeles
    {
        private int _sor;
        private int _szek;
        private int _ertek;

        public Ertekeles(int sor, int szek, int ertek)
        {
            Sor = sor;
            Szek = szek;
            Ertek = ertek;
        }

        public int Sor { get => _sor; set => _sor = value; }
        public int Szek { get => _szek; set => _szek = value; }
        public int Ertek { get => _ertek; set => _ertek = value; }
    }
}
