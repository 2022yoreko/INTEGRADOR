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
            administrador.MdiParent = this.MdiParent;
            administrador.Show();
            this.Close(); //Cerrar la ventana actual que hizo la llamada
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            FrmLogin formLogin = new FrmLogin();
            formLogin.MdiParent = this.MdiParent; //Indicar que el contenedor padre es el mismo del que hizo la llamada
            formLogin.Show();
            this.Close(); //Cerrar la ventana que  hizo la llamada
        }
    }
}
