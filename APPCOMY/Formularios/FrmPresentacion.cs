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
    public partial class FrmPresentacion : Form
    {
        public FrmPresentacion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            FrmRegistro_Usuario administrador = new FrmRegistro_Usuario();
            administrador.ShowDialog();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            FrmLogin administrador = new FrmLogin();
            administrador.ShowDialog();
        }
    }
}
