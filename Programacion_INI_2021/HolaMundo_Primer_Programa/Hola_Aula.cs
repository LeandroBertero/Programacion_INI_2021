using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundo_Primer_Programa
{
    public partial class Hola_Aula : Form
    {
        public Hola_Aula()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnClick_Click(object sender, EventArgs e)
        {
            LblMensaje.Text = "Hola gente de la materia:  " + TxtMateria.Text;
        }
    }
}
