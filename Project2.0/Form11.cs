using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2._0
{
    public partial class Form11 : Form
    {
        Form1 f1;
        Form8 f8;
        Form10 f10;
        public Form11(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
            f8 = new Form8(this.f1);
            f10 = new Form10(this.f1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            f8.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            f10.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // back
            this.Hide();

            f1.Show();
        }
    }
}
