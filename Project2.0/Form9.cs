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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void ui_delete_Click(object sender, EventArgs e)
        {
            string username = ui_username.Text;
            string pass = ui_password.Text;

            if (ui_password.Text.Length == 0 || ui_username.Text.Length == 0)
            {

                MessageBox.Show("fill the text field", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                TTM ttm = TTM.getinstance();
            int r = ttm.deleteuser(username, pass);

            if (r == -1)
            {
                MessageBox.Show("no such user", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        }

        private void ui_back_Click(object sender, EventArgs e)
        {

        }
    }
}
