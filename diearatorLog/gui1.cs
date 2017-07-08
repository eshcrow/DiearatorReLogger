using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diearatorLog
{
    public partial class gui1 : Form
    {
        public gui1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Diearator.Scan();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Diearator.attack = true;
            }
            if (checkBox1.Checked == false)
            {
                Diearator.attack = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.guiform.Close();
            Diearator.denyhost(false);
        }
    }
}
