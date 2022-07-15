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

namespace APPCOMY.Formularios
{
    public partial class FrmAyuda : Form
    {
        public FrmAyuda()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            var newForm4 = new FrmMenu();
            newForm4.Show();
            this.Hide();
        }

        private void FrmAyuda_Load(object sender, EventArgs e)
        {
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            var newForm4 = new FrmMenu();
            newForm4.Show();
            this.Hide();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            Rest(1);

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rest(2);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rest(3);
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rest(4);
        }
        private void Rest(int options) 
        {
            string ruta = Directory.GetCurrentDirectory();
            string rutArch = ruta.Replace(@"\bin\Debug", @"\Archivos\Respuesta"+options+".txt");
            StreamReader Leer;
            Leer = new StreamReader(rutArch);

            string data;
            data = Leer.ReadLine();

            string parrafo = "";

            while (data != null)
            {
                parrafo = parrafo + "\n" + data;

                data = Leer.ReadLine();

            }//Fin del While
            Leer.Close();
            richTextBox1.Text = parrafo;
        }
        
    }
}
