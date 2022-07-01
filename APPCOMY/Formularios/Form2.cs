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
    public partial class Form2 : Form
    {
        bool valido = true;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Form4 administrador = new Form4();
            administrador.ShowDialog();


            string rutaBase = Directory.GetCurrentDirectory();
            string rutArch = rutaBase.Replace(@"\bin\Debug", @"ficheros\Usuario");
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

            }

            if (encontrado)
            {
                Form4 frmNav = new Form4();
                frmNav.MdiParent = this.MdiParent;
                frmNav.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("El usuario no existe");
            }


            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Campo usuario requerido", "Error usuario");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtContraseña.Text))
                {
                    MessageBox.Show("Se requiere escribir una contraseña", "Error contraseña");
                }

            }

            try
            {
                var addr = new System.Net.MailAddress(txtUsuario.Text);
            }
            catch 
            {
                txtUsuario.Text = "";
                MessageBox.Show("Usuario no valido, error en el email", "Error de usuario");
            }


            if (txtUsuario.Text == "katherinesofia719@gmail.com" && txtContraseña.Text == "22040128") 
            {
                Form4.PnlVisible = true;
                this.Dispose();
            }
            else 
            {
                MessageBox.Show("Credenciales no validad", "Acceso Denegado");
            }

            DateTime fecha = DateTime.Now;

            Microsoft.Office.Interop.Excel.Application app;
            app = (Microsoft.Office.Interop.Excel.Application)Marshal.GetActiveObject("Excel.Application");
            Microsoft.Office.Interop.Excel.Workbook activeWB = app.ActiveWorkbook;

            for (int X = 2; X <= 50; X++) 
            {
                  if (Convert.ToString(app.Sheets[1].cells(X,1).text) == "")
                  {
                    app.Sheets[1].cells(X, 1).value = txtUsuario.Text;
                    app.Sheets[2].cells(X, 2).value = txtUsuario.Text;
                    app.Sheets[3].cells(X, 3).value = fecha;
                    break;

                  }

            }



        }

        private void Form2_Load(object sender, EventArgs e)
        {

        

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
                txtUsuario.ForeColor = Color.DarkBlue;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DarkBlue;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
