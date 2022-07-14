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
            string Usuario, Contraseña;
            Usuario = txtUsuario.Text;
            Contraseña = txtContraseña.Text;

            
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
                string rutArch = ruta.Replace(@"\bin\Debug", @"\Archivos\Usuarios.txt");
                StreamReader Leer;
                Leer = new StreamReader(rutArch);

                bool encontrado = false;
                string data;

                data = Leer.ReadLine();

                while (!encontrado && data != null)
                {
                    string[] array = data.Split(';');
                    if (array[2].Equals(txtUsuario.Text.ToUpper()) && array[3].Equals(txtContraseña.Text))
                    {
                        encontrado = true;
                    }
                    else
                    {
                        data = Leer.ReadLine();
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
                    
                   // FrmMenu administrador = new FrmMenu();
                   // administrador.Show();
                   // this.Close();

                }
                else
                if(!encontrado)
                {
                    MessageBox.Show("Usuario no valido");
                }

            }//fin if de busqueda

        }


        private void Recordar_Contraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxMostrar_contraseña.Checked)
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
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.DimGray;

            }
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            FrmPresentacion present = new FrmPresentacion();
            present.MdiParent = this.MdiParent;
            present.Show();
            this.Close();         
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            FrmPresentacion present = new FrmPresentacion();
            present.MdiParent = this.MdiParent;
            present.Show();
            this.Close();

        }
    }
}
