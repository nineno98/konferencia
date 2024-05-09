using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace konferencia_GUI
{
    public partial class Form1 : Form
    {
        List<Konferencia> konferenciak = new List<Konferencia>();
        ConnectToDatabase connection = new ConnectToDatabase();
        int kepmeret = 40;
        int konferenciaIndex = 0;
        public Form1()
        {
            InitializeComponent();
            konferenciaIndex = 0;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            konferenciak = connection.SelectKonferenciak();
            konferenciakbetoltese();
        }

        private void konferenciakbetoltese()
        {
            panelErtekeles.Controls.Clear();

            this.Text = $"{konferenciak[0].Eloadascime_}";
            foreach (string kepNeve in Directory.GetFiles("kepek"))
            {
                
                if (konferenciak[0].Eloadascime_.ToLower().Contains(kepNeve.ToLower().Split('.')[0].Split('\\')[1]))
                {
                    
                    pictureBoxKolto.Image = Image.FromFile(kepNeve);
                    pictureBoxKolto.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }


        }
    }
}
