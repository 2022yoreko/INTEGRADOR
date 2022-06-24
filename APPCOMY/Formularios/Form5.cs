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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            var newForm4 = new Form4();
            newForm4.Show();
            this.Hide();
                
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            var newForm4 = new Form4();
            newForm4.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nombres = txtNombres.Text;
            string Apellidos = txtApellidos.Text;
            string Facultad = txtFacultad.Text;
            string Carrera = txtCarrera.Text;
            string Año = txtAño.Text;
            string Promedio = txtPromedio.Text;
            string Depto = txtDepto.Text;
            string Telefono = txtTelefono.Text;
            string Foto = cbxFoto.Text;

            if (Nombres.Length > 0)
            {

            }
            else

              if (Apellidos.Length > 0)
            {

            }
            else

            if (Facultad.Length > 0)
            {

            }
            else

            if (Carrera.Length > 0)
            {

            }
            else

            if (Año.Length > 2000)
            {

            }
            else

            if (Promedio.Length >= 80)
            {

            }
            else

            if (Depto.Length > 0)
            {

            }
            else

            if (Telefono.Length > 0)
            {
            
            }
            else 

             if (Foto.Length > 0)
            {
            
            }

        }
    }
}
