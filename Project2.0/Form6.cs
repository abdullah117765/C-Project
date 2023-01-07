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
    public partial class Form6 : Form
    {
        Form1 f1;
        public Form6(Form1 f1  )
        {
            InitializeComponent();
            this.f1 = f1;
        }





        private void arrangeclass(object sender, EventArgs e)
        {

            TTM ttm = TTM.getinstance();
            
            string from = ui_from.Text;
           
            string sem = ui_sem.Text;
            string day = ui_day.Text;
            string Batch_dep = ui_batch_dep.Text;
            string roomno = ui_roomno.Text;
            string Cooursename = ui_course.Text;


            if (ui_day.Text.Length == 0 || ui_from.Text.Length == 0 || ui_sem.Text.Length == 0 || ui_roomno.Text.Length == 0 || ui_course.Text.Length == 0 || ui_batch_dep.Text.Length == 0 )
            {

                MessageBox.Show("fill the text field", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {


                //string batch_dep, string roomno, string coursename, string classduration, string sem
                Console.WriteLine("add");

                int response = ttm.addclass(Batch_dep, roomno, Cooursename, from, sem, day);

                if (response == 1)
                {

                    MessageBox.Show("Added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (response == -1) {

                    MessageBox.Show("Slot already filled", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (response == -3)
                {

                    MessageBox.Show("wrong Slot slected", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    MessageBox.Show("wrong day selected", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void Deleteclass(object sender, EventArgs e)
        {


            TTM ttm = TTM.getinstance();

            string from = ui_from.Text;
            string sem = ui_sem.Text;
            string day = ui_day.Text;
            string Batch_dep = ui_batch_dep.Text;
            string roomno = ui_roomno.Text;
            string Cooursename = ui_course.Text;


            Console.WriteLine("delete");

            if (ui_day.Text.Length == 0 || ui_from.Text.Length == 0 || ui_sem.Text.Length == 0 || ui_roomno.Text.Length == 0 || ui_course.Text.Length == 0 || ui_batch_dep.Text.Length == 0 )
            {

                MessageBox.Show("fill the text field", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                int response = ttm.deleteclass(Batch_dep, roomno, Cooursename, from, sem, day);

                if (response == 1)
                {

                    MessageBox.Show("deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (response == -1)
                {

                    MessageBox.Show("Slot already empty", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (response == -3)
                {

                    MessageBox.Show("wrong Slot slected", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    MessageBox.Show("wrong day selected", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void to_makeup_Click(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ui_back_Click(object sender, EventArgs e)
        {
            this.Hide();

            f1.Show();
        }
    }
}
