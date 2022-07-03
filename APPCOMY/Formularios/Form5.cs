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

namespace APPCOMY
{
    public partial class FrmGuardar_Registro : Form
    {
        public FrmGuardar_Registro()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            var newForm4 = new FrmMenu();
            newForm4.Show();
            this.Hide();
                
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            var newForm4 = new FrmMenu();
            newForm4.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string N_Carne = txtN_carne.Text;
            string Nombres = txtNombres.Text;
            string Apellidos = txtApellidos.Text;
            string Facultad = (cmbFacultad.SelectedItem.ToString());
            string Carrera = txtCarrera.Text;
            string Año = txtAño.Text;
            string Promedio = txtPromedio.Text;
            string Depto = (cmbDepto.SelectedItem.ToString());
            string Telefono = txtTelefono.Text;
            string Foto = (cmbFoto.SelectedItem.ToString());


            FileStream fs;
            StreamWriter escribe;

            string rutbase = Directory.GetCurrentDirectory();
            string rutarchivo = rutbase.Replace(@"\bin\Debug", @"\Archivos\Usuario.txt");
            fs = new FileStream(rutarchivo, FileMode.Append);

            escribe = new StreamWriter(fs);
            escribe.WriteLine(txtN_carne.Text);
            escribe.WriteLine(txtNombres.Text);
            escribe.WriteLine(txtApellidos.Text);
            escribe.WriteLine(cmbFacultad.SelectedItem.ToString());
            escribe.WriteLine(txtCarrera.Text);
            escribe.WriteLine(txtAño.Text);
            escribe.WriteLine(txtPromedio.Text);
            escribe.WriteLine(cmbDepto.Text);
            escribe.WriteLine(txtTelefono.Text);
            escribe.WriteLine(cmbFoto.SelectedItem.ToString());
            escribe.Close();
            















            /* if (Nombres.Length > 0)
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
              MessageBox.Show("Registro exitoso");*/


        }
    }
}
