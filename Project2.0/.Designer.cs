namespace Project2._0
{
    partial class Form4
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
            this.viewtt_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewtt_btn
            // 
            this.viewtt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewtt_btn.Location = new System.Drawing.Point(245, 107);
            this.viewtt_btn.Name = "viewtt_btn";
            this.viewtt_btn.Size = new System.Drawing.Size(238, 81);
            this.viewtt_btn.TabIndex = 1;
            this.viewtt_btn.Text = "VIEW TIMETABLE";
            this.viewtt_btn.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(245, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 74);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete User";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.viewtt_btn);
            this.Name = "Form4";
            this.Text = "ADMIN PANEL";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button viewtt_btn;
        private System.Windows.Forms.Button button2;
    }
}