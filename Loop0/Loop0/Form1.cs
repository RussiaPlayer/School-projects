﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schleifen0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ende_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Löschen_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void KStart_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i <= 10)
            {
                listBox1.Items.Add(i);
                i++;
            }
        }

        private void FStart_Click(object sender, EventArgs e)
        {
            int i = 0;
            do
            {
                listBox1.Items.Add(i);
                i++;
            }
            while (i <= 10);
        }
    }
}
