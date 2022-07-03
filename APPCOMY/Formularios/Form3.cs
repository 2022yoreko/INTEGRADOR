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
    public partial class FrmRegistrate : Form
    {
        public FrmRegistrate()
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
            string Confirmar_Contraseña = txtConfirmar_contraseña.Text;
            string Correo_electronico = txtCorreo_Electronico.Text;
            string Numero_telefono = txtNumero_telefono.Text;
            bool Guardar = false;

            FileStream fs;
            StreamWriter escribe;

            string rutbase = Directory.GetCurrentDirectory();
            string rutarchivo = rutbase.Replace(@"\bin\Debug", @"\Archivos\Usuario.txt");
            fs = new FileStream(rutarchivo, FileMode.Append);

            escribe = new StreamWriter(fs);
            escribe.WriteLine(txtCarne.Text);










            DateTime fecha = DateTime.Now;

            Microsoft.Office.Interop.Excel.Application app;
            app = (Microsoft.Office.Interop.Excel.Application)Marshal.GetActiveObject("Excel.Application");
            Microsoft.Office.Interop.Excel.Workbook activeWB = app.ActiveWorkbook;

            for (int X = 2; X <= 50; X++)
            {
                if (Convert.ToString(app.Sheets[1].cells(X, 1).text) == "")
                {
                    app.Sheets[1].cells(X, 1).value = txtNombres.Text;
                    app.Sheets[2].cells(X, 2).value = txtApellidos.Text;
                    app.Sheets[2].cells(X, 2).value = txtContraseña.Text;
                    app.Sheets[1].cells(X, 1).value = txtConfirmar_contraseña.Text;
                    app.Sheets[1].cells(X, 1).value = txtCorreo_Electronico.Text;
                    app.Sheets[1].cells(X, 1).value = txtNumero_telefono.Text;
                    app.Sheets[3].cells(X, 3).value = fecha;
                    break;

                }

            }
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

        private void txtConfirmar_Contraseña_Enter(object sender, EventArgs e)
        {
            if (txtConfirmar_contraseña.Text == "Confirmar contraseña")
            {
                txtConfirmar_contraseña.Text = "";
                txtConfirmar_contraseña.ForeColor = Color.DarkBlue;
            }
        }

        private void txtConfirmar_contraseña_Leave(object sender, EventArgs e)
        {
            if (txtConfirmar_contraseña.Text == "")
            {
                txtConfirmar_contraseña.Text = "Confirmar contraseña";
                txtConfirmar_contraseña.ForeColor = Color.DarkBlue;
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

        private void txtNumero_Telefono_Enter(object sender, EventArgs e)
        {
            if (txtNumero_telefono.Text == "Numero de telefono")
            {
                txtNumero_telefono.Text = "";
                txtNumero_telefono.ForeColor = Color.DarkBlue;
            }
        }


        private void txtNumero_Telefono_Leave(object sender, EventArgs e)
        {
            if (txtNumero_telefono.Text == "")
            {
                txtNumero_telefono.Text = "Numero Telefono";
                txtNumero_telefono.ForeColor = Color.DarkBlue;
            }
         
            
        }
    }
}
