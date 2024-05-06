using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konferencia_console
{
    internal class Konferencia
    {
        private int eloadas_id_;
        private string eloadascime_;
        Eloadoterem eloadoterem_;

        public Konferencia(int id, string eloadascime_, Eloadoterem eloadoterem_)
        {
            this.eloadas_id_ = id;
            this.eloadascime_ = eloadascime_;
            this.eloadoterem_ = eloadoterem_;
        }
    }
}
