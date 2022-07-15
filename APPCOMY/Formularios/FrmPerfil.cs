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
    public partial class FrmPerfil : Form
    {
        private List<String> listTemp = new List<String>();
        private DataGrid dt;

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

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbOption_SelectedIndexChanged(object sender, EventArgs e)
        {

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



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            search(txtBusqueda.Text, cbOption.SelectedIndex);
            
        }

        private void search(string txtSearch, int index)
        {
            listTemp.Clear();
            string ruta = Directory.GetCurrentDirectory();
            string rutArch = ruta.Replace(@"\bin\Debug", @"\Archivos\Estudiantes.txt");
            StreamReader Leer;
            Leer = new StreamReader(rutArch);

            string data;
            string cod = null;
            data = Leer.ReadLine();

            while ( data != null)
            {
                string[] array = data.Split(';');
                if (array[index].Contains(txtSearch.ToUpper()) )
                {
                    if (cod != array[0])
                    {
                        listTemp.Add(data);
                    }
                    cod = array[0];
                }
                data = Leer.ReadLine();

            }//Fin del While
            Leer.Close(); //Cerrar el archivo
            loadData();
        }
        private void loadData()
        {
            // Clear data
            dataGridView1.Rows.Clear();
            for (int i = 0; i < listTemp.Count; i++)
            {

                string[] row = listTemp[i].Split(';');
                //  dataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row [11]);
                dataGridView1.Rows.Add("", row[0], row[1], row[2], row[3], row[7], row[10], row[9], row[4], row[5], row[6], row[8]);
                                             // "", row 0,1,2,3,7,10,9,4,5,6,8
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
          
        }

        public FrmPerfil()
        {
            InitializeComponent();
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmMenu frmNav = new FrmMenu();
            frmNav.MdiParent = this.MdiParent;
            frmNav.Show();
            this.Close();

        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            int renglon = dataGridView1.Rows.Add();

            dataGridView1.Rows[renglon].Cells["CN_carnet"].Value = N_carnet;
            dataGridView1.Rows[renglon].Cells["CN_becado"].Value = N_becado;
            dataGridView1.Rows[renglon].Cells["Cnombres"].Value = nombres;
            dataGridView1.Rows[renglon].Cells["Capellidos"].Value = apellidos;
            dataGridView1.Rows[renglon].Cells["Ccorreo"].Value = correo;
            dataGridView1.Rows[renglon].Cells["Ctelefono"].Value = telefono;
            dataGridView1.Rows[renglon].Cells["Cdepto"].Value = depto;
            dataGridView1.Rows[renglon].Cells["Cdomicilio"].Value = domicilio;
            dataGridView1.Rows[renglon].Cells["Cfacultad"].Value = facultad;
            dataGridView1.Rows[renglon].Cells["Ccarrera"].Value = carrera;
            dataGridView1.Rows[renglon].Cells["Caño"].Value = año;
            dataGridView1.Rows[renglon].Cells["Cpromedio"].Value = promedio;

        }
    }
}
