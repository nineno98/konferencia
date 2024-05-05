using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konferencia
{
    internal class Eloadas
    {
        private int _id;
        private string _cim;
        private int _sor;
        private int _szek;
        int[,] _ertekeles;

        public Eloadas(int id, string cim, int sor, int szek, int[,] ertekeles)
        {
            _id = id;
            _cim = cim;
            _sor = sor;
            _szek = szek;
            _ertekeles = ertekeles;
        }

        public int Id { get => _id; set => _id = value; }
        public string Cim { get => _cim; set => _cim = value; }
        public int Sor { get => _sor; set => _sor = value; }
        public int Szek { get => _szek; set => _szek = value; }
        public int[,] Ertekeles { get => _ertekeles; set => _ertekeles = value; }
    }
}
