using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPCOMY.Formularios
{
    public partial class FrmPerfil : Form
    {
        private string N_carnet, N_becado, nombres, apellidos, correo, telefono, depto, domicilio, facultad, carrera, año, promedio;
        public string pN_carnet 
        {
            set 
            {
                N_carnet = value;
            }
        
        }
        public string pN_becado
        {
            set
            {
                N_becado = value;
            }

        }
        public string pnombres
        {
            set
            {
                nombres = value;
            }

        }
        public string papellidos
        {
            set
            {
                apellidos = value;
            }

        }
        public string pcorreo
        {
            set
            {
               correo = value;
            }

        }
        public string ptelefono
        {
            set
            {
               telefono = value;
            }

        }
        public string pdepto
        {
            set
            {
              depto = value;
            }

        }
        public string pdomicilio
        {
            set
            {
               domicilio = value;
            }

        }
        public string pfacultad
        {
            set
            {
                facultad = value;
            }

        }
        public string pcarrera
        {
            set
            {
               carrera = value;
            }

        }
        public string paño
        {
            set
            {
                año = value;
            }

        }
        public string ppromedio
        {
            set
            {
               promedio = value;
            }

        }
        public FrmPerfil()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            var newForm4 = new FrmMenu();
            newForm4.Show();
            this.Hide();

        }

        private void FrmPerfil_Load(object sender, EventArgs e)
        {

        }

        private void txtBusqueda_Enter(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "Appcomy")
            {
                txtBusqueda.Text = "";
                txtBusqueda.ForeColor = Color.DimGray;

            }

        }

        private void txtBusqueda_Leave(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "")
            {
                txtBusqueda.Text = "Appcomy";
                txtBusqueda.ForeColor = Color.DimGray;

            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
          /* int renglon dataGridView1.Rows.Add;*/
        }
    }
}
