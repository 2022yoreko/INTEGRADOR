using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPCOMY
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnRegistro_Estudiantes_Click(object sender, EventArgs e)
        {
            Form5 administrador = new Form5();
            administrador.ShowDialog();
        }

        private void btnPerfil_Alumnos_Click(object sender, EventArgs e)
        {
            Form7 administrador = new Form7();
            administrador.ShowDialog();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Form5 administrador = new Form5();
            administrador.ShowDialog();
        }

        private void btnInformacion_Personal_Click(object sender, EventArgs e)
        {
            Form7 administrador = new Form7();
            administrador.ShowDialog();
        }

        private void btnTabla_Asistencia_Click(object sender, EventArgs e)
        {
            Form8 administrador = new Form8();
            administrador.ShowDialog();
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            Form7 administrador = new Form7();
            administrador.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}