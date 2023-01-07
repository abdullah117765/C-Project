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
    public partial class Form7 : Form
    {

        Form1 f1;
        public Form7(Form1 f11)
        {
            InitializeComponent();
            // f5 = new form5(this);
            f1 = f11;
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {




            string username = ui_username.Text;
            string email = ui_email.Text;
            string password = ui_passward.Text;
            string name = ui_name.Text;


            if (ui_name.Text.Length == 0 || ui_email.Text.Length == 0 || ui_passward.Text.Length == 0 || ui_username.Text.Length == 0)
            {

                MessageBox.Show("fill the text field", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                TTM ttm = TTM.getinstance();
            int r = ttm.adduser(username, password, email, name);

            if (r == -1)
            {
                MessageBox.Show("user Already exist", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }



            //string username1, string password1, string email1, string name1
           


          

            

            // this.Close();

        }

        private void enter_pas_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();

            f1.Show();
        }
    }
}
