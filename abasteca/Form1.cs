﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abasteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value = progressBar1.Value + 2;
            }
            catch
            {
                timer1.Enabled = false;

                this.Visible = false;

                frmAbasteca frm = new frmAbasteca();

                frm.ShowDialog();

            }
        }
    }
}
