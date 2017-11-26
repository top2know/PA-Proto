using System;
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
    public partial class FormEnter : Form
    {
        FormZakazchik fz = new FormZakazchik();
        public FormEnter()
        {
            InitializeComponent();
        }

        private void button_EnterAcc_Click(object sender, EventArgs e)
        {
            /*
             *Вставить проверку существования 
             */
            if (textBox_PhoneNumber.Text == "88005553535")
            {
                this.Close();
                fz.Show();
            }
        }
    }
}
