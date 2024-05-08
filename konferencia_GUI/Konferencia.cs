using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konferencia_GUI
{
    internal class Konferencia
    {
        private int eloadas_id_;
        private string eloadascime_;
        Eloadoterem eloadoterem_;

        public Konferencia(int id, string eloadascime_, Eloadoterem eloadoterem_)
        {
            this.Eloadas_id_ = id;
            this.Eloadascime_ = eloadascime_;
            this.Eloadoterem_ = eloadoterem_;
        }

        public int Eloadas_id_ { get => eloadas_id_; set => eloadas_id_ = value; }
        public string Eloadascime_ { get => eloadascime_; set => eloadascime_ = value; }
        internal Eloadoterem Eloadoterem_ { get => eloadoterem_; set => eloadoterem_ = value; }
    }
}
