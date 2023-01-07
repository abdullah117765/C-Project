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
    public partial class Form10 : Form
    {
        Form1 f1;
        public Form10(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Table.Rows.Clear();

           
            TTM ttm = TTM.getinstance();

            LinkedList<User> mm = ttm.viewuser();


            for (int i = 0; i < mm.Count; i++)
            {
                Table.Rows.Add( mm.ElementAt(i).Username, mm.ElementAt(i).Name, mm.ElementAt(i).Password, mm.ElementAt(i).Email);
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            f1.Show();
        }
    }
}
