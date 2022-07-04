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
            FrmMenu frmNav = new FrmMenu();
            frmNav.MdiParent = this.MdiParent;
            frmNav.Show();
            this.Close();
        }

        private void presentacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPresentacion P = new FrmPresentacion();
            P.MdiParent = this;
            P.Show();
        }
    }
}
