﻿using System;
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
    public partial class FrmMdi : Form
    {
        public FrmMdi()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmMdi_Load(object sender, EventArgs e)
        {
            FrmPresentacion Presentacion = new FrmPresentacion();
            Presentacion.MdiParent = this;
            Presentacion.Show();
        }
    }
}
