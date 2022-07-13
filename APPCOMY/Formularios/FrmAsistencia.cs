using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPCOMY
{
    public partial class FrmAsistencia : Form
    {
        public FrmAsistencia()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu back = new FrmMenu();
            back.Show();


        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            var newForm4 = new FrmMenu();
            newForm4.Show();
            this.Hide();
        }

       

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void FrmAsistencia_Load(object sender, EventArgs e)
        {
            var newForm4 = new FrmMenu();
            newForm4.Show();
            this.Hide();
        }

        private void imgAsistencia_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;
            string Fecha = txtFecha.Text;
            string Hora1 = txtHora1.Text;
            string Hora2 = txtHora2.Text;
            string Hora3 = txtHora3.Text;

            bool Guardar = true;

            FileStream fs;
            StreamWriter escribe;
            string linea;

            string rutbase = Directory.GetCurrentDirectory();
            string rutarchivo = rutbase.Replace(@"\bin\Debug", @"\Archivos\Asistencia.txt");
            fs = new FileStream(rutarchivo, FileMode.Append);
            escribe = new StreamWriter(fs);

            try
            {
                linea = txtNombre.Text + ";";
                linea = txtFecha.Text + ";";
                linea += txtHora1.Text + ";";
                linea += txtHora2.Text + ";";
                linea += txtHora3.Text + ";";
            }
            catch 
            {
                MessageBox.Show("Debe marcar todos los datos");
            }

            if (Guardar == true) 
            {
                MessageBox.Show("Asistencia Guardada");
            }

        }
    }
}
