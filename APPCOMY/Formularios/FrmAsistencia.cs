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
            string Nombre = txtNombre.Text;
            string Fecha = txtFecha.Text;
            string Hora1 = txtHora1.Text;
            string Hora2 = txtHora2.Text;
            string Hora3 = txtHora3.Text;
           
            bool Lu, Ma, Mi, Ju, Vi, Sa, Do;

            bool Guardar = true;


            FileStream fs;
            StreamWriter escribe;
            string linea;

            string rutbase = Directory.GetCurrentDirectory();
            string rutarchivo = rutbase.Replace(@"\bin\Debug", @"\Archivos\Agenda.txt");
            fs = new FileStream(rutarchivo, FileMode.Append);
            escribe = new StreamWriter(fs);

            Lu = Convert.ToBoolean(Console.ReadLine());
            Ma = Convert.ToBoolean(Console.ReadLine());
            Mi = Convert.ToBoolean(Console.ReadLine());
            Ju = Convert.ToBoolean(Console.ReadLine());
            Vi = Convert.ToBoolean(Console.ReadLine());
            Sa = Convert.ToBoolean(Console.ReadLine());
            Do = Convert.ToBoolean(Console.ReadLine());


            if (Lu == true)
            {
                Lu = checkBox1.Checked;
            }
            else if (Lu == true)
            {
                Lu = checkBox2.Checked;
            }
            else if (Lu == true)
            {
                Lu = checkBox3.Checked;
            }



            if (Ma == true)
            {
                Ma = checkBox4.Checked;
            }
            else if (Ma == true)
            {
                Ma = checkBox5.Checked;
            }
            else if (Ma == true)
            {
                Ma = checkBox6.Checked;
            }



            if (Mi == true)
            {
                Mi = checkBox7.Checked;
            }
            else if (Mi == true)
            {
                Mi = checkBox8.Checked;
            }
            else if (Mi == true)
            {
                Mi = checkBox9.Checked;
            }



            if (Ju == true)
            {
                Ju = checkBox10.Checked;
            }
            else if (Ju == true)
            {
                Ju = checkBox11.Checked;
            }
            else if (Ju == true)
            {
                Ju = checkBox12.Checked;
            }



            if (Vi == true)
            {
                Vi = checkBox13.Checked;
            }
            else if (Vi == true)
            {
                Vi = checkBox14.Checked;
            }
            else if (Vi == true)
            {
                Vi = checkBox15.Checked;
            }



            if (Sa == true)
            {
                Sa = checkBox16.Checked;
            }
            else if (Sa == true)
            {
                Sa = checkBox17.Checked;
            }
            else if (Sa == true)
            {
                Sa = checkBox18.Checked;
            }



            if (Do == true)
            {
                Do = checkBox19.Checked;
            }
            else if (Do == true)
            {
                Do = checkBox20.Checked;
            }
            else if (Do == true)
            {
                Do = checkBox21.Checked;
            }

            
            linea = txtNombre.Text + ";";
            linea = txtFecha.Text + ";";
            linea += txtHora1.Text + ";";
            linea += txtHora2.Text + ";";
            linea += txtHora3.Text + ";";

            
              /*  MessageBox.Show("Debe marcar todos los datos");*/
            if (Guardar == true) 
            {
                MessageBox.Show("Asistencia Guardada");
            }

        }
    }
}
