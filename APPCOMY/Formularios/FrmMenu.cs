using APPCOMY.Formularios;
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
    public partial class FrmMenu : Form
    {
        public static bool PnlVisible { get; internal set; }

        public FrmMenu()
        {
            InitializeComponent();
        }


        private void btnRegistro_Estudiantes_Click(object sender, EventArgs e)
        {
            FrmRegistro_Estudiantes registro_estud = new FrmRegistro_Estudiantes();
            registro_estud.MdiParent = this.MdiParent;
            registro_estud.Show();
            this.Close();

        }

        private void btnInformacion_Personal_Click(object sender, EventArgs e)
        {

            FrmPerfil perfil= new FrmPerfil();
            perfil.MdiParent = this.MdiParent;
            perfil.Show();
            this.Close();
        }

        private void btnTabla_Asistencia_Click(object sender, EventArgs e)
        {
            FrmAsistencia asistencia = new FrmAsistencia();
            asistencia.MdiParent = this.MdiParent;
            asistencia.Show();
            this.Close();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            FrmAyuda ayuda = new FrmAyuda();
            ayuda.MdiParent = this.MdiParent;
            ayuda.Show();
            this.Close();
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.MdiParent = this.MdiParent;
            login.Show();
            this.Close();

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            FrmRegistro_Estudiantes registro_usuario = new FrmRegistro_Estudiantes();
            registro_usuario.MdiParent = this.MdiParent;
            registro_usuario.Show();
            this.Close();
        }
    }
}