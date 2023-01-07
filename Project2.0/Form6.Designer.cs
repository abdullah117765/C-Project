namespace Project2._0
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.from_makeup = new System.Windows.Forms.Label();
            this.arrange_mkupbtn2 = new System.Windows.Forms.Button();
            this.ui_from = new System.Windows.Forms.TextBox();
            this.ui_batch_dep = new System.Windows.Forms.TextBox();
            this.ui_roomno = new System.Windows.Forms.TextBox();
            this.ui_sem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ui_course = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ui_day = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.ui_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = " ARRANGE MAKEUP CLASS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // from_makeup
            // 
            this.from_makeup.AutoSize = true;
            this.from_makeup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_makeup.Location = new System.Drawing.Point(60, 157);
            this.from_makeup.Name = "from_makeup";
            this.from_makeup.Size = new System.Drawing.Size(50, 25);
            this.from_makeup.TabIndex = 2;
            this.from_makeup.Text = "Slot";
            // 
            // arrange_mkupbtn2
            // 
            this.arrange_mkupbtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrange_mkupbtn2.Location = new System.Drawing.Point(589, 332);
            this.arrange_mkupbtn2.Name = "arrange_mkupbtn2";
            this.arrange_mkupbtn2.Size = new System.Drawing.Size(117, 30);
            this.arrange_mkupbtn2.TabIndex = 5;
            this.arrange_mkupbtn2.Text = "Delete Class";
            this.arrange_mkupbtn2.UseVisualStyleBackColor = true;
            this.arrange_mkupbtn2.Click += new System.EventHandler(this.Deleteclass);
            // 
            // ui_from
            // 
            this.ui_from.Location = new System.Drawing.Point(184, 160);
            this.ui_from.Name = "ui_from";
            this.ui_from.Size = new System.Drawing.Size(148, 22);
            this.ui_from.TabIndex = 6;
            // 
            // ui_batch_dep
            // 
            this.ui_batch_dep.Location = new System.Drawing.Point(544, 148);
            this.ui_batch_dep.Name = "ui_batch_dep";
            this.ui_batch_dep.Size = new System.Drawing.Size(162, 22);
            this.ui_batch_dep.TabIndex = 10;
            // 
            // ui_roomno
            // 
            this.ui_roomno.Location = new System.Drawing.Point(544, 188);
            this.ui_roomno.Name = "ui_roomno";
            this.ui_roomno.Size = new System.Drawing.Size(162, 22);
            this.ui_roomno.TabIndex = 11;
            this.ui_roomno.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ui_sem
            // 
            this.ui_sem.Location = new System.Drawing.Point(544, 232);
            this.ui_sem.Name = "ui_sem";
            this.ui_sem.Size = new System.Drawing.Size(162, 22);
            this.ui_sem.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 13;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Batch_Dep";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(394, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Semester";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(401, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Room no";
            // 
            // ui_course
            // 
            this.ui_course.Location = new System.Drawing.Point(544, 267);
            this.ui_course.Name = "ui_course";
            this.ui_course.Size = new System.Drawing.Size(162, 22);
            this.ui_course.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(394, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Course Name";
            // 
            // ui_day
            // 
            this.ui_day.Location = new System.Drawing.Point(184, 215);
            this.ui_day.Name = "ui_day";
            this.ui_day.Size = new System.Drawing.Size(148, 22);
            this.ui_day.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Day";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(181, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "e.g 1-5 ,1 for monday";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(451, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 30);
            this.button1.TabIndex = 22;
            this.button1.Text = "Arrange Class";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.arrangeclass);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(181, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "e.g 1-9     1 for  9:00 to 9:30";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // ui_back
            // 
            this.ui_back.Location = new System.Drawing.Point(48, 393);
            this.ui_back.Name = "ui_back";
            this.ui_back.Size = new System.Drawing.Size(75, 23);
            this.ui_back.TabIndex = 25;
            this.ui_back.Text = "<=  Home";
            this.ui_back.UseVisualStyleBackColor = true;
            this.ui_back.Click += new System.EventHandler(this.ui_back_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ui_back);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ui_day);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ui_course);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ui_sem);
            this.Controls.Add(this.ui_roomno);
            this.Controls.Add(this.ui_batch_dep);
            this.Controls.Add(this.ui_from);
            this.Controls.Add(this.arrange_mkupbtn2);
            this.Controls.Add(this.from_makeup);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label from_makeup;
        private System.Windows.Forms.Button arrange_mkupbtn2;
        private System.Windows.Forms.TextBox ui_from;
        private System.Windows.Forms.TextBox ui_batch_dep;
        private System.Windows.Forms.TextBox ui_roomno;
        private System.Windows.Forms.TextBox ui_sem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ui_course;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ui_day;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ui_back;
    }
}