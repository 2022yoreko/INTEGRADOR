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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void txtNumero_Telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Form4 administrador = new Form4();
            administrador.ShowDialog();

            string Nombres = txtNombres.Text;
            string Apellidos = txtApellidos.Text;
            string Contraseña = txtContraseña.Text;
            string Confirmar_Contraseña = txtConfirmar_contraseña.Text;
            string Correo_electronico = txtCorreo_Electronico.Text;
            string Numero_telefono = txtNumero_Telefono.Text;
            bool Acceder = false;

            if (Nombres.Length > 0)
            {

            }
            else

               if (Apellidos.Length > 0)
            {
            
            }
            else

                if (Contraseña.Length > 0)
            {
            
            }
            else

                if (Confirmar_Contraseña.Length > 0)
            {
            
            }
            else

                if (Correo_electronico.Length > 0)
            {

            }
            else

                if (Numero_telefono.Length > 0)
            {
                          
            }
            if (Acceder) 
            {
                Acceder = true;
            }


        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            var newForm = new Form();
            newForm.Show();
            this.Hide();
        }
    }
}
