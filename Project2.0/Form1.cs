using Project2._0.backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace Project2._0
{
    public partial class Form1 : Form
    {
        TTM ttm = TTM.getinstance();

        Form2 f2;
        Form3 f3;
        Form7 f7;
        public Form1()
        {
           
            InitializeComponent();
            f2 = new Form2(this);
            f7 = new Form7(this);
            f3 = new Form3(this);
        }

        private void userselction_Click(object sender, EventArgs e)
        {
            this.Hide();
           
            f2.Show();
          
    }

        private void adminselction_Click(object sender, EventArgs e)
        {
            this.Hide();
           
            f3.Show();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            f7.Show();
           // this.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            TTM.getinstance().writeuser();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TTM.getinstance().readuser();
        }
    }
}
