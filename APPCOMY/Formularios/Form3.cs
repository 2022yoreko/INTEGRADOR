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
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            var newForm = new Form();
            newForm.Show();
            this.Hide();
        }
    }
}
