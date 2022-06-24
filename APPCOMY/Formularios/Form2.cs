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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
           
        private void btnAcceder_Click(object sender, EventArgs e)
        {
           Form4 administrador = new Form4();
                administrador.ShowDialog();

            string login = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            bool Acceder = false;


            if (login.Length > 0)
            {
                Acceder = true;
            }
            else

                if (contraseña.Length > 0)
            {
                Acceder = true;
            }
            if (Acceder)
            {
                MessageBox.Show("Bienvenido");
            }



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
