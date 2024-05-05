using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konferencia_console
{
    internal class Eloadoterem
    {
        private int sor_;
        private int hely_;
        private int[,] ertekelesek_;
        public Eloadoterem(int sor_, int hely_)
        {
            this.sor_ = sor_;
            this.hely_ = hely_;

            Ertekelesek = new int[sor_, hely_];
        }

        public int[,] Ertekelesek { get => ertekelesek_; set => ertekelesek_ = value; }
    }
}
