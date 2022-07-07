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
    public partial class FrmRegistro_Estudiantes : Form
    {
        public FrmRegistro_Estudiantes()
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
            string N_carnet = txtN_carnet.Text;
            string Nombres = txtNombres.Text;
            string Apellidos = txtApellidos.Text;
            string Correo = txtCorreo.Text;
            string Carrera = txtCarrera.Text;
            string Año = txtAño.Text;
            string Promedio = txtPromedio.Text;
            string Telefono = txtTelefono.Text;
            string Facultad = ComboboxFacultad.SelectedItem.ToString();
            string Depto = ComboboxDepto.SelectedItem.ToString();

            bool Guardar = true;

            if (txtN_carnet.Text.Equals(N_carnet))
            {
                Guardar = true;
            }
            else

              if (txtNombres.Text.Equals(Nombres))
            {
                Guardar = true;
            }
            else

               if (txtApellidos.Text.Equals(Apellidos))
            {
                Guardar = true;
            }
            else

               if (txtCorreo.Text.Equals(Correo))
            {
                Guardar = true;
            }
            else

               if (ComboboxFacultad.SelectedItem.Equals(Facultad))

            {
                Guardar = true;
            }
            else

               if (txtCarrera.Text.Equals(Carrera))
            {
                Guardar = true;
            }
            else

               if (txtAño.Text.Equals(Año))
            {
                Guardar = true;
            }
            else

               if (txtPromedio.Text.Equals(Promedio))
            {
                Guardar = true;
            }
            else

               if (txtTelefono.Text.Equals(Telefono))
            {
                Guardar = true;
            }
            else

               if (ComboboxDepto.SelectedItem.Equals(Depto))
            {
                Guardar = true;
            }

            
            FileStream fs;  
            StreamWriter escribe;
            string linea;

            string rutbase = Directory.GetCurrentDirectory();
            string rutarchivo = rutbase.Replace(@"\bin\Debug", @"\Archivo\Estudiantes.txt");
            fs = new FileStream(rutarchivo, FileMode.Append);
           
            escribe = new StreamWriter(fs);
            linea = txtN_carnet.Text + ";";
            linea += txtNombres.Text + ";";
            linea += txtApellidos.Text + ";";
            linea += txtCorreo.Text + ";";
            linea += ComboboxFacultad.SelectedItem.ToString();
            linea += txtCarrera.Text + ";";
            linea += txtAño.Text + ";";
            linea += txtPromedio.Text +";";
            linea += txtTelefono.Text + ";";
            linea += ComboboxDepto.SelectedItem.ToString();
            escribe.WriteLine(linea.ToUpper());
            escribe.Close();
            


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)| *.jpg;*.jpeg|PNG (*.png)|*.png";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                imgPerfil.ImageLocation = getImage.FileName;

            }
            else
            {
                MessageBox.Show("No selecciono ninguna imagen", "Sin selecion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool Eliminar;

            txtN_carnet.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            ComboboxDepto.SelectedItem = "";
            txtDomicilio.Text = "";
            txtAño.Text = "";
            ComboboxFacultad.SelectedItem = "";
            txtCarrera.Text = "";
            txtPromedio.Text = "";
            
            /*if (Eliminar) 
            {
              Eliminar = true;
            MessageBox.Show("Esta seguro que quiere eliminar este registro");
            
            }
            else
            {
            Eliminar = false;
            MessageBox.Show("Cancelado");
            }
             */
        }
    }
}
