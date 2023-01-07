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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Project2._0
{
    public partial class Form2 : Form
    {

        form5 f5;
        Form1 f1;
        public Form2(Form1 f11)
        {
            InitializeComponent();
            f1=f11;
            f5 = new form5(this.f1);
        }

        private void userlgn_btn_Click(object sender, EventArgs e)
        {
            TTM ttm = TTM.getinstance();


            string username = ui_username.Text;
            string password = ui_passward.Text;


            if (ui_passward.Text.Length == 0 || ui_username.Text.Length == 0 )
            {

                MessageBox.Show("fill the text field", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                int check = ttm.verifyuser(username, password);
            if (check == -1)
            {

                MessageBox.Show("wrong userid or passward", "failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();

                f5.Show();


            }


        }

            
        }

        private void txtbox_userid_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();

            f1.Show();
        }
    }
}
