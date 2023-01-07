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
    public partial class form5 : Form
    {
        Form1 f1;
        Form6 f6;
        Form8 f8;
       
        public form5(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
            f8 = new Form8(this.f1);
            f6 = new Form6(this.f1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();   
            f6.Show();    
           
        }

        

        private void view_usr_tt_Click(object sender, EventArgs e)
        {
            this.Hide();
            f8.Show();

        }

        private void ui_back_Click(object sender, EventArgs e)
        {
            this.Hide();

            f1.Show();

        }
    }
}
