﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GROCERIO_PROJECT_OOP2
{
    public partial class Thanks : Form
    {
        public Thanks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }

        private void Thanks_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you want to logout?", "Confirmation", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                this.Close();
                new Landing().Show();
            }
            else if (result == DialogResult.No)
            {

            }
        }
    }
}
