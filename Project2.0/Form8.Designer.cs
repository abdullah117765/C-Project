namespace Project2._0
{
    partial class Form8
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
            this.Table = new System.Windows.Forms.DataGridView();
            this.TimeSlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Batch_Dep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ui_day = new System.Windows.Forms.TextBox();
            this.Display = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeSlot,
            this.Batch_Dep,
            this.Room,
            this.CourseName,
            this.Sem});
            this.Table.Location = new System.Drawing.Point(129, 12);
            this.Table.Name = "Table";
            this.Table.RowHeadersWidth = 51;
            this.Table.RowTemplate.Height = 24;
            this.Table.Size = new System.Drawing.Size(659, 435);
            this.Table.TabIndex = 1;
            // 
            // TimeSlot
            // 
            this.TimeSlot.HeaderText = "TimeSlot";
            this.TimeSlot.MinimumWidth = 6;
            this.TimeSlot.Name = "TimeSlot";
            this.TimeSlot.Width = 125;
            // 
            // Batch_Dep
            // 
            this.Batch_Dep.HeaderText = "Batch_Dep";
            this.Batch_Dep.MinimumWidth = 6;
            this.Batch_Dep.Name = "Batch_Dep";
            this.Batch_Dep.Width = 125;
            // 
            // Room
            // 
            this.Room.HeaderText = "Room";
            this.Room.MinimumWidth = 6;
            this.Room.Name = "Room";
            this.Room.Width = 125;
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "CourseName";
            this.CourseName.MinimumWidth = 6;
            this.CourseName.Name = "CourseName";
            this.CourseName.Width = 125;
            // 
            // Sem
            // 
            this.Sem.HeaderText = "Sem";
            this.Sem.MinimumWidth = 6;
            this.Sem.Name = "Sem";
            this.Sem.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ui_day);
            this.panel1.Controls.Add(this.Display);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 449);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "e.g 1-5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Day";
            // 
            // ui_day
            // 
            this.ui_day.Location = new System.Drawing.Point(11, 119);
            this.ui_day.Name = "ui_day";
            this.ui_day.Size = new System.Drawing.Size(100, 22);
            this.ui_day.TabIndex = 1;
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Display.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Display.Location = new System.Drawing.Point(24, 34);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(75, 35);
            this.Display.TabIndex = 0;
            this.Display.Text = "Display ";
            this.Display.UseVisualStyleBackColor = false;
            this.Display.Click += new System.EventHandler(this.button1_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 475);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 8;
            this.back.Text = "<=  Home";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 510);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.panel1);
            this.Name = "Form8";
            this.Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeSlot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Batch_Dep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.TextBox ui_day;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
    }
}