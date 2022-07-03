using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop;
using System.Runtime.InteropServices;
using System.IO;

namespace APPCOMY
{
    public partial class FrmLogin : Form
    {
        bool valido = true;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                try
                {
                    var addr = new System.Net.MailAddress(txtUsuario.Text);
                }
                catch
                {
                    txtUsuario.Text = "";
                    MessageBox.Show("Usuario no valido, error en el email", "Error de usuario");
                }
            }

            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                valido = false;
            }

            if (valido)
            {
                string ruta = Directory.GetCurrentDirectory();
                string rutArch = ruta.Replace(@"\bin\Debug", @"\Archivos\Usuario.txt");
                StreamReader Leer;
                Leer = new StreamReader(rutArch);

                bool encontrado = false;
                string Usuario;
                string Contraseña;

                Usuario = Leer.ReadLine();
                Contraseña = Leer.ReadLine();

                while (!encontrado && Usuario != null)
                {
                    if (txtUsuario.Text.Equals(Usuario) && txtContraseña.Text.Equals(Contraseña))
                    {
                        encontrado = true;
                    }
                    else
                    {
                        Usuario = Leer.ReadLine();
                        Contraseña = Leer.ReadLine();

                    }

                }//Fin del While
                Leer.Close(); //Cerrar el archivo
                //Si se ha encontrado el usuario
                if (encontrado)
                {
                    FrmMenu frmNav = new FrmMenu();
                    frmNav.MdiParent = this.MdiParent;
                    frmNav.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Usuario no valido");
                }

            }//fin if de busqueda


            FrmMenu administrador = new FrmMenu();
            administrador.ShowDialog();


        }


        private void Recordar_Contraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (Recordar_Contraseña.Checked)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }

        }


        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DimGray;
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

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            var newForm1 = new FrmMenu();
            newForm1.Show();
            this.Hide();
        }
    }
}
