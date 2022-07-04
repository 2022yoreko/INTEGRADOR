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
    public partial class FrmPerfil : Form
    {

        public FrmPerfil()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            var newForm4 = new FrmMenu();
            newForm4.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            var newForm4 = new FrmMenu();
            newForm4.Show();
            this.Hide();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)| *.jpg;*.jpeg|PNG (*.png)|*.png";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                imgPerfil.ImageLocation = getImage.FileName;

            }
            else 
            {
                MessageBox.Show("No selecciono ninguna imagen", "Sin selecion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)| *.jpg;*.jpeg|PNG (*.png)|*.png";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                img1.ImageLocation = getImage.FileName;

            }
            else
            {
                MessageBox.Show("No selecciono ninguna imagen", "Sin selecion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)| *.jpg;*.jpeg|PNG (*.png)|*.png";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                img2.ImageLocation = getImage.FileName;

            }
            else
            {
                MessageBox.Show("No selecciono ninguna imagen", "Sin selecion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)| *.jpg;*.jpeg|PNG (*.png)|*.png";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                img3.ImageLocation = getImage.FileName;

            }
            else
            {
                MessageBox.Show("No selecciono ninguna imagen", "Sin selecion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)| *.jpg;*.jpeg|PNG (*.png)|*.png";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                img4.ImageLocation = getImage.FileName;

            }
            else
            {
                MessageBox.Show("No selecciono ninguna imagen", "Sin selecion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)| *.jpg;*.jpeg|PNG (*.png)|*.png";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                img5.ImageLocation = getImage.FileName;

            }
            else
            {
                MessageBox.Show("No selecciono ninguna imagen", "Sin selecion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)| *.jpg;*.jpeg|PNG (*.png)|*.png";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                img6.ImageLocation = getImage.FileName;

            }
            else
            {
                MessageBox.Show("No selecciono ninguna imagen", "Sin selecion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)| *.jpg;*.jpeg|PNG (*.png)|*.png";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                img7.ImageLocation = getImage.FileName;

            }
            else
            {
                MessageBox.Show("No selecciono ninguna imagen", "Sin selecion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)| *.jpg;*.jpeg|PNG (*.png)|*.png";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                img8.ImageLocation = getImage.FileName;

            }
            else
            {
                MessageBox.Show("No selecciono ninguna imagen", "Sin selecion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)| *.jpg;*.jpeg|PNG (*.png)|*.png";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                img9.ImageLocation = getImage.FileName;

            }
            else
            {
                MessageBox.Show("No selecciono ninguna imagen", "Sin selecion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)| *.jpg;*.jpeg|PNG (*.png)|*.png";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                img10.ImageLocation = getImage.FileName;

            }
            else
            {
                MessageBox.Show("No selecciono ninguna imagen", "Sin selecion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)| *.jpg;*.jpeg|PNG (*.png)|*.png";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                img11.ImageLocation = getImage.FileName;

            }
            else
            {
                MessageBox.Show("No selecciono ninguna imagen", "Sin selecion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)| *.jpg;*.jpeg|PNG (*.png)|*.png";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                img12.ImageLocation = getImage.FileName;

            }
            else
            {
                MessageBox.Show("No selecciono ninguna imagen", "Sin selecion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FrmPerfil_Load(object sender, EventArgs e)
        {
            panelPerfil.BackColor = Color.FromArgb(50, 0, 0, 0);
        }
    }
}
