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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            var newForm4 = new Form4();
            newForm4.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            var newForm4 = new Form4();
            newForm4.Show();
            this.Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
