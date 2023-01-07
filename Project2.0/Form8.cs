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
    public partial class Form8 : Form
    {

        Form1 f1;
        public Form8(Form1 f1  )
        {
            InitializeComponent();
            this.f1 = f1;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Table.Rows.Clear();
            if (ui_day.Text.Length != 0)
            {
                
                int day = Int16.Parse(ui_day.Text);
                TTM ttm = TTM.getinstance();
                if (day>0 && day < 6) {
                    LinkedList<Mclass> mm = ttm.viewclass(day);


                    for (int i = 0; i < mm.Count; i++)
                    {
                        Table.Rows.Add(i + 1, mm.ElementAt(i).Batch_dep, mm.ElementAt(i).Roomno, mm.ElementAt(i).Coursename, mm.ElementAt(i).Sem);
                    }
                }
                else
                {
                    MessageBox.Show("invalid day", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                   
            }
            else
            {
                MessageBox.Show("fill the text field", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();

            f1.Show();
        }
    }
}
