﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public class Elements
    {
        
    } 
    
    public partial class EnterForm : Form
    {
        FormEnter formEnter = new FormEnter();

        public EnterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Enter_Click(object sender, EventArgs e)
        {
            
            formEnter.Show();

        }

        private void button_Registration_Click(object sender, EventArgs e)
        {

        }

        private void EnterForm_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void EnterForm_Leave(object sender, EventArgs e)
        {
        }
    }
}
