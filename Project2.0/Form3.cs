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

namespace Project2._0
{
    public partial class Form3 : Form
    {
        Form11 f11;
        Form1 f1;
        public Form3(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
            f11 = new Form11(this.f1);
        }

        private void admn_signinbtn_Click(object sender, EventArgs e)
        {


            TTM ttm = TTM.getinstance();


            string username = ui_username.Text;
            string password = ui_passward.Text;

            if (ui_passward.Text.Length == 0 || ui_username.Text.Length == 0)
            {

                MessageBox.Show("fill the text field", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                int check = ttm.verifyadmin(username, password);
            if (check == -1)
            {

                MessageBox.Show("wrong userid or passward", "failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();

                f11.Show();


            }

        }



        }

        private void back_Click(object sender, EventArgs e)
        {

            this.Hide();

            f1.Show();
        }
    }
}
