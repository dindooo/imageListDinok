using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imageListDinoK
{
    public partial class Form1 : Form
    {
        int brojac = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (brojac < imgLista.Images.Count - 1)
            {
                brojac++;
            }
            else
            {
                brojac = 0;
            }
            pcrSlike.Image = imgLista.Images[brojac];
        }
    }
}
