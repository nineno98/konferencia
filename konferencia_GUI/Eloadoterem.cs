using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konferencia_GUI
{
    internal class Eloadoterem
    {
        private int sor_;
        private int hely_;
        private int[,] ertekelesek_;
        public Eloadoterem(int sor_, int hely_)
        {
            this.Sor_ = sor_;
            this.Hely_ = hely_;

            Ertekelesek = new int[sor_, hely_];
        }

        public int[,] Ertekelesek { get => ertekelesek_; set => ertekelesek_ = value; }
        public int Sor_ { get => sor_; set => sor_ = value; }
        public int Hely_ { get => hely_; set => hely_ = value; }

        public int GetErtekeles(int sor, int hely)
        {
            return Ertekelesek[sor, hely];
        }

        public double Avg_ { get => getAvg(); }

        private double getAvg()
        {
            double avg = 0;
            int counter = 0;
            for (int i = 0; i < ertekelesek_.GetLength(0); i++)
            {
                for (int j = 0; j < ertekelesek_.GetLength(1); j++)
                {
                    avg += ertekelesek_[i, j];
                    counter++;
                }
            }
            avg = avg / counter;
            
            return Math.Round(avg,2);
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < ertekelesek_.GetLength(0); i++)
            {
                for (int j = 0; j < ertekelesek_.GetLength(1); j++)
                {
                    result += ertekelesek_[i,j] + " ";
                }
                result += "\n";
            }
            return result;
        }
    }
}
