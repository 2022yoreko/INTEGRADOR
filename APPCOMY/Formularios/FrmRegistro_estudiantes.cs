using APPCOMY.Formularios;
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
         FrmPerfil enviar = new FrmPerfil();
        public FrmRegistro_Estudiantes()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmMenu Menu = new FrmMenu();
            Menu.MdiParent = this.MdiParent;
            Menu.Show();
            this.Close();

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu Menu = new FrmMenu();
            Menu.MdiParent = this.MdiParent;
            Menu.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string N_carnet = txtN_carnet.Text;
            string N_Becado = txtN_Becado.Text;
            string Nombres = txtNombres.Text;
            string Apellidos = txtApellidos.Text;
            string Correo = txtCorreo.Text;
            string Telefono = txtTelefono.Text;
            string Depto = ComboboxDepto.SelectedItem.ToString();
            string Domicilio = txtDomicilio.Text;
            string Facultad = ComboboxFacultad.SelectedItem.ToString();
            string Carrera = txtCarrera.Text;
            string Año = ComboBoxAño.SelectedItem.ToString();
            string Promedio = txtPromedio.Text;
            bool Guardar = true;


            FileStream fs;
            StreamWriter escribe;
            string linea;

            string rutbase = Directory.GetCurrentDirectory();
            string rutarchivo = rutbase.Replace(@"\bin\Debug", @"\Archivos\Estudiantes.txt");
            fs = new FileStream(rutarchivo, FileMode.Append);
            escribe = new StreamWriter(fs);

            try
            {

                linea = txtN_carnet.Text + ";";
                linea = txtN_Becado.Text + ";";
                linea += txtNombres.Text + ";";
                linea += txtApellidos.Text + ";";
                linea += txtCorreo.Text + ";";
                linea += txtTelefono.Text + ";";
                linea += ComboboxDepto.SelectedItem.ToString() + ";";
                linea += txtDomicilio.Text + ";";
                linea += ComboboxFacultad.SelectedItem.ToString() + ";";
                linea += txtCarrera.Text + ";";
                linea += ComboBoxAño.SelectedItem.ToString() + ";";
                linea += txtPromedio.Text + ";";
                escribe.WriteLine(linea.ToUpper());
                escribe.Close();

            }
            catch
            {
                MessageBox.Show("Datos incompletos, llene todos los campos");
            }


            if (Guardar == true)
            {
                MessageBox.Show("Datos registrados correctamente");
            }

            enviar.pN_carnet = txtN_carnet.Text;
            enviar.pN_becado = txtN_Becado.Text;
            enviar.pnombres = txtNombres.Text;
            enviar.papellidos = txtApellidos.Text;
            enviar.pcorreo = txtCorreo.Text;
            enviar.ptelefono = txtTelefono.Text;
            enviar.pdepto = ComboboxDepto.SelectedItem.ToString();
            enviar.pdomicilio = txtDomicilio.Text;
            enviar.pfacultad = ComboboxFacultad.SelectedItem.ToString();
            enviar.pcarrera = txtCarrera.Text;
            enviar.paño = ComboBoxAño.SelectedItem.ToString();
            enviar.ppromedio = txtPromedio.Text;

            enviar.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_foto_Click(object sender, EventArgs e)
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtN_carnet.Clear();
            txtN_Becado.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtCarrera.Clear();
            txtTelefono.Clear();
            txtDomicilio.Clear();
            txtPromedio.Clear();
        }

        private void txtN_carnet_Validated(object sender, EventArgs e)
        {
            if (txtN_carnet.Text.Trim() == "") 
            {
                epError.SetError(txtN_carnet, "Campo requerido");
                txtN_carnet.Focus();
            }
            else 
            {
                epError.Clear();
            }
        }

        private void txtNombres_Validated(object sender, EventArgs e)
        {
            if (txtNombres.Text.Trim() == "")
            {
                epError.SetError(txtNombres, "Campo requerido");
                txtNombres.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtApellidos_Validated(object sender, EventArgs e)
        {
            if (txtApellidos.Text.Trim() == "")
            {
                epError.SetError(txtApellidos, "Campo requerido");
                txtApellidos.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtCorreo_Validated(object sender, EventArgs e)
        {
            if (txtCorreo.Text.Trim() == "")
            {
                epError.SetError(txtCorreo, "Campo requerido");
                txtCorreo.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtTelefono_Validated(object sender, EventArgs e)
        {
            if (txtTelefono.Text.Trim() == "")
            {
                epError.SetError(txtTelefono, "Campo requerido");
                txtTelefono.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtDomicilio_Validated(object sender, EventArgs e)
        {
            if (txtDomicilio.Text.Trim() == "")
            {
                epError.SetError(txtDomicilio, "Campo requerido");
                txtDomicilio.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

       
        private void txtCarrera_Validated(object sender, EventArgs e)
        {
            if (txtCarrera.Text.Trim() == "")
            {
                epError.SetError(txtCarrera, "Campo requerido");
                txtCarrera.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtN_Becado_Validated(object sender, EventArgs e)
        {
            if (txtN_Becado.Text.Trim() == "")
            {
                epError.SetError(txtN_Becado, "Campo requerido");
                txtN_Becado.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
           
            txtN_carnet.Clear();
            txtN_Becado.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtCarrera.Clear();
            txtTelefono.Clear();
            txtDomicilio.Clear();
            txtPromedio.Clear();

        }
        private void txtPromedio_Validated(object sender, EventArgs e)
        {
            if (txtPromedio.Text.Trim() == "")
            {
                epError.SetError(txtPromedio, "Campo requerido");
                txtPromedio.Focus();
            }
            else
            {
                epError.Clear();
            }

        }

    }
    
}

