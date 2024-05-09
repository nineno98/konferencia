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
        int konferenciaIndex;
        int kepmeret;
        public Form1()
        {
            InitializeComponent();
            kepmeret = 35;
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

            this.Text = $"{konferenciak[konferenciaIndex].Eloadascime_}";
            foreach (string kepNeve in Directory.GetFiles("kepek"))
            {
                
                if (konferenciak[konferenciaIndex].Eloadascime_.ToLower().Contains(kepNeve.ToLower().Split('.')[0].Split('\\')[1]))
                {
                    
                    pictureBoxKolto.Image = Image.FromFile(kepNeve);
                    pictureBoxKolto.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }

            for (int sor = 0; sor < konferenciak[konferenciaIndex].Eloadoterem_.Sor_; sor++)
            {
                for (int hely = 0; hely < konferenciak[konferenciaIndex].Eloadoterem_.Hely_; hely++)
                {
                    PictureBox pb = new PictureBox();
                    pb.Image = selectImageFromErtekeles(konferenciak[konferenciaIndex].Eloadoterem_.GetErtekeles(sor,hely));
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Size = new Size(kepmeret, kepmeret);
                    pb.Location = new Point(sor*kepmeret, hely*kepmeret);
                    pb.Tag = $"{sor},{hely}";
                    
                    pb.MouseClick += new MouseEventHandler((sender, e) =>
                        {
                            string[] tag = pb.Tag.ToString().Split(',');
                            konferenciak[konferenciaIndex].Eloadoterem_.SetErtekeles(int.Parse(tag[0]), int.Parse(tag[1]));
                            konferenciakbetoltese();
                            
                        }   
                    );

                    panelErtekeles.Controls.Add(pb);
                }
            }

            if (konferenciaIndex == 0)
            {
                jobbnyil.Show();
                ballnyil.Hide();
            }
            else if (konferenciaIndex == konferenciak.Count - 1)
            {
                jobbnyil.Hide();
                ballnyil.Show();
            }
            else
            {
                jobbnyil.Show();
                ballnyil.Show();
            }
        }

        

        private Image selectImageFromErtekeles(int v)
        {
            Image ertekeles;
            switch (v)
            {
                case 1:
                    ertekeles = Image.FromFile("kepek\\Pont1.jpg");
                    break;
                case 2:
                    ertekeles = Image.FromFile("kepek\\Pont2.jpg");
                    break;
                case 3:
                    ertekeles = Image.FromFile("kepek\\Pont3.jpg");
                    break;
                default:
                    ertekeles = Image.FromFile("kepek\\Pont0.jpg");
                    break;
            }
            return ertekeles;
        }

        private void jobbnyil_Click(object sender, EventArgs e)
        {
            if (konferenciaIndex < konferenciak.Count -1)
                konferenciaIndex++;
            konferenciakbetoltese();
        }

        private void ballnyil_Click(object sender, EventArgs e)
        {
            if (konferenciaIndex != 0)
                konferenciaIndex--;
            konferenciakbetoltese();

        }

        private void mentes_Click(object sender, EventArgs e)
        {

        }
    }
}
