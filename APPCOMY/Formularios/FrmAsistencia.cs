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
            FrmMenu Menu = new FrmMenu();
            Menu.MdiParent = this.MdiParent;
            Menu.Show();
            this.Close();
            this.Hide();


        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FrmMenu Menu = new FrmMenu();
            Menu.MdiParent = this.MdiParent;
            Menu.Show();
            this.Close();

        }


        private void button1_Click(object sender, EventArgs e)
        {

            string Lu = checkBox1.Checked.ToString();
            string Ma = checkBox2.Checked.ToString();
            string Mi = checkBox2.Checked.ToString();
            string Ju = checkBox2.Checked.ToString();
            string Vi = checkBox2.Checked.ToString();
            string Sa = checkBox2.Checked.ToString();
            string Do = checkBox2.Checked.ToString();
            string Fecha = txtFecha.Text;
            string Hora1 = txtHora1.Text;
            string Hora2 = txtHora2.Text;
            string Hora3 = txtHora3.Text;

            bool validate = validateData(Lu, Ma, Mi, Ju, Vi, Sa, Do);

            if (!validate) return;

            FileStream fs;
            StreamWriter escribe;
            string linea;

            string rutbase = Directory.GetCurrentDirectory();
            string rutarchivo = rutbase.Replace(@"\bin\Debug", @"\Archivos\Agenda.txt");
            fs = new FileStream(rutarchivo, FileMode.Append);
            escribe = new StreamWriter(fs);

            try
            {
                linea = txtNombre.Text + ";";
                linea += checkBox1.Checked.ToString() + ";";
                linea += checkBox2.Checked.ToString() + ";";
                linea += checkBox3.Checked.ToString() + ";";
                linea += checkBox4.Checked.ToString() + ";";
                linea += checkBox5.Checked.ToString() + ";";
                linea += checkBox6.Checked.ToString() + ";";
                linea += checkBox7.Checked.ToString() + ";";
                linea += checkBox8.Checked.ToString() + ";";
                linea += checkBox9.Checked.ToString() + ";";
                linea += checkBox10.Checked.ToString() + ";";
                linea += checkBox11.Checked.ToString() + ";";
                linea += checkBox12.Checked.ToString() + ";";
                linea += checkBox13.Checked.ToString() + ";";
                linea += checkBox14.Checked.ToString() + ";";
                linea += checkBox15.Checked.ToString() + ";";
                linea += checkBox16.Checked.ToString() + ";";
                linea += checkBox17.Checked.ToString() + ";";
                linea += checkBox18.Checked.ToString() + ";";
                linea += checkBox19.Checked.ToString() + ";";
                linea += checkBox20.Checked.ToString() + ";";
                linea += checkBox21.Checked.ToString() + ";";
                linea += txtFecha.Text + ";";
                linea += txtHora1.Text + ";";
                linea += txtHora2.Text + ";";
                linea += txtHora3.Text + ";";
                escribe.WriteLine(linea.ToUpper());
                escribe.Close();
            }
            catch 
            {
                MessageBox.Show("Debe marcar todos los datos");
            }

            if (validate == true) 
            {
                MessageBox.Show("Asistencia Guardada");
            }

        }

        private bool validateData(string lu, string ma, string mi, string ju, string vi, string sa, string @do)
        {
            throw new NotImplementedException();
        }
    }
}
