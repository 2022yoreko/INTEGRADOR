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
            string Confirmar_Contraseña = txtConfirmar.Text;
            string Correo_electronico = txtCorreo_Electronico.Text;
            string Numero_telefono = txtTelefono.Text;
            bool Guardar = false;

            if (txtNombres.Text.Equals(Nombres))
            {

            }
            else

              if (txtApellidos.Text.Equals(Apellidos))
            {

            }
            else

              if (txtContraseña.Text.Equals(txtConfirmar))
            {

            }
            else

            if (!txtContraseña.Text.Equals(Confirmar_Contraseña))
            {
                MessageBox.Show("las contraseñas no coinciden");
            
            }
            else

            if (txtCorreo_Electronico.Text.Equals(Correo_electronico))
                
            {
                
            }
            else 

             if (txtTelefono.Text.Equals(Numero_telefono)) 
            {
            
            
            }
            else 
            {
              
            
            }

            FileStream fs;
            StreamWriter escribe;
            string linea;
            string rutbase = Directory.GetCurrentDirectory();
            string rutarchivo = rutbase.Replace(@"\bin\Debug", @"\Archivos\Usuarios.txt");
            fs = new FileStream(rutarchivo, FileMode.Append);

            escribe = new StreamWriter(fs);
            linea = txtNombres.Text + ";";
            linea += txtApellidos.Text + ";";
            linea += txtContraseña.Text + ";";
            linea += txtConfirmar.Text + ";";
            linea += txtCorreo_Electronico.Text + ";";
            linea += txtTelefono.Text + ";";
            escribe.WriteLine(linea.ToUpper());
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
                txtNombres.ForeColor = Color.DimGray;
            }
        }

        private void txtNombres_Leave(object sender, EventArgs e)
        {
            if (txtNombres.Text == "")
            {
                txtNombres.Text = "Nombres";
                txtNombres.ForeColor = Color.DimGray;
            }
        }

        private void txtApellidos_Enter(object sender, EventArgs e)
        {
            if (txtApellidos.Text == "Apellidos")
            {
                txtApellidos.Text = "";
                txtApellidos.ForeColor = Color.DimGray;
            }
        }

        private void txtApellidos_Leave(object sender, EventArgs e)
        {
            if (txtApellidos.Text == "")
            {
                txtApellidos.Text = "Apellidos";
                txtApellidos.ForeColor = Color.DimGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.DimGray;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.DimGray;
            }
        }

        
        private void txtCorreo_Electronico_Enter(object sender, EventArgs e)
        {
            if (txtCorreo_Electronico.Text == "Correo Electronico")
            {
                txtCorreo_Electronico.Text = "";
                txtCorreo_Electronico.ForeColor = Color.DimGray;
            }
        }

        private void txtCorreo_Electronico_Leave(object sender, EventArgs e)
        {
            if (txtCorreo_Electronico.Text == "")
            {
                txtCorreo_Electronico.Text = "Correo Electronico";
                txtCorreo_Electronico.ForeColor = Color.DimGray;
            }
        }

        private void txtConfirmar_Enter(object sender, EventArgs e)
        {
            if (txtConfirmar.Text == "Confirmar") 
            {
                txtConfirmar.Text = "";
                txtConfirmar.ForeColor = Color.DimGray;
            }
        }

        private void txtConfirmar_Leave(object sender, EventArgs e)
        {
            if (txtConfirmar.Text == "") 
            {
                txtConfirmar.Text = "Confirmar";
                txtConfirmar.ForeColor = Color.DimGray;
            }
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "Telefono") 
            {
                txtTelefono.Text = "";
                txtTelefono.ForeColor = Color.DimGray;
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "") 
            {
                txtTelefono.Text = "Telefono";
                txtTelefono.ForeColor = Color.DimGray;
            }
        }
    }
}
