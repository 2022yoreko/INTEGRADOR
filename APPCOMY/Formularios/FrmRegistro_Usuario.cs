using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace APPCOMY
{
    public partial class FrmRegistro_Usuario : Form
    {
        public FrmRegistro_Usuario()
        {
            InitializeComponent();
        }

        private void txtNumero_Telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {


            string Nombres = txtNombres.Text;
            string Apellidos = txtApellidos.Text;
            string Contraseña = txtContraseña.Text;
            string Confirmar_Contraseña = txtC_Contraseña.Text;
            string Correo_electronico = txtCorreo_Electronico.Text;
            string Numero_telefono = txtN_telefono.Text;
            bool Guardar = false;

            FileStream fs;
            StreamWriter escribe;

            string rutbase = Directory.GetCurrentDirectory();
            string rutarchivo = rutbase.Replace(@"\bin\Debug", @"\Archivos\Usuario.txt");
            fs = new FileStream(rutarchivo, FileMode.Append);

            escribe = new StreamWriter(fs);
            escribe.WriteLine(txtNombres.Text);
            escribe.WriteLine(txtApellidos.Text);
            escribe.WriteLine(txtContraseña.Text);
            escribe.WriteLine(txtC_Contraseña.Text);
            escribe.WriteLine(txtCorreo_Electronico.Text);
            escribe.WriteLine(txtN_telefono.Text);
            escribe.Close();


            FrmMenu administrador = new FrmMenu();
            administrador.ShowDialog();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            var newForm = new Form();
            newForm.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void txtNombres_Enter(object sender, EventArgs e)
        {
            if (txtNombres.Text == "Nombres")
            {
                txtNombres.Text = "";
                txtNombres.ForeColor = Color.DarkBlue;
            }
        }

        private void txtNombres_Leave(object sender, EventArgs e)
        {
            if (txtNombres.Text == "")
            {
                txtNombres.Text = "Nombres";
                txtNombres.ForeColor = Color.DarkBlue;
            }
        }

        private void txtApellidos_Enter(object sender, EventArgs e)
        {
            if (txtApellidos.Text == "Apellidos")
            {
                txtApellidos.Text = "";
                txtApellidos.ForeColor = Color.DarkBlue;
            }
        }

        private void txtApellidos_Leave(object sender, EventArgs e)
        {
            if (txtApellidos.Text == "")
            {
                txtApellidos.Text = "Apellidos";
                txtApellidos.ForeColor = Color.DarkBlue;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.DarkBlue;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.DarkBlue;
            }
        }

        
        private void txtCorreo_Electronico_Enter(object sender, EventArgs e)
        {
            if (txtCorreo_Electronico.Text == "Correo Electronico")
            {
                txtCorreo_Electronico.Text = "";
                txtCorreo_Electronico.ForeColor = Color.DarkBlue;
            }
        }

        private void txtCorreo_Electronico_leave(object sender, EventArgs e)
        {
            if (txtCorreo_Electronico.Text == "")
            {
                txtCorreo_Electronico.Text = "Correo Electronico";
                txtCorreo_Electronico.ForeColor = Color.DarkBlue;
            }
        }

        

        private void txtC_Contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtC_Contraseña_Enter(object sender, EventArgs e)
        {
            if (txtC_Contraseña.Text == "Confirmar Contraseña") 
            {
                txtC_Contraseña.Text = "";
                txtC_Contraseña.ForeColor = Color.Gray;
            }
        }

        private void txtC_Contraseña_leave(object sender, EventArgs e)
        {
            if (txtC_Contraseña.Text == "")
            {
                txtC_Contraseña.Text = "Confirmar contraseña";
               
            }
        }

        private void txtN_telefono_Enter(object sender, EventArgs e)
        {
            if (txtN_telefono.Text == "Numero de telefono") 
            {
                txtN_telefono.Text = "";
          
            }
        }

        private void txtN_telefono_Leave(object sender, EventArgs e)
        {
            if (txtN_telefono.Text == "") 
            {
                txtN_telefono.Text = "Numero de telefono";
            }
        }
    }
}
