using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoisPontos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        distancia calc = new distancia(); 
        private void Button1_Click(object sender, EventArgs e)
        {
            calc.ponto1 = x1.Text;
            calc.ponto2 = x2.Text;
            calc.ponto1 = y1.Text;
            calc.ponto2 = y2.Text;
            label1.Text = calc.Pontos;
        }
    }
}
