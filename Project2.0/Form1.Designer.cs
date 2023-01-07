namespace Project2._0
{
    partial class Form1
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
            this.userselction = new System.Windows.Forms.Button();
            this.adminselction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.signup_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userselction
            // 
            this.userselction.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userselction.Location = new System.Drawing.Point(299, 161);
            this.userselction.Name = "userselction";
            this.userselction.Size = new System.Drawing.Size(163, 23);
            this.userselction.TabIndex = 0;
            this.userselction.Text = "LOGIN AS USER";
            this.userselction.UseVisualStyleBackColor = true;
            this.userselction.Click += new System.EventHandler(this.userselction_Click);
            // 
            // adminselction
            // 
            this.adminselction.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminselction.Location = new System.Drawing.Point(299, 208);
            this.adminselction.Name = "adminselction";
            this.adminselction.Size = new System.Drawing.Size(163, 23);
            this.adminselction.TabIndex = 1;
            this.adminselction.Text = "LOGIN AS ADMIN";
            this.adminselction.UseVisualStyleBackColor = true;
            this.adminselction.Click += new System.EventHandler(this.adminselction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "WELCOME TO TIMETABLE MANAGMENT SYSTEM";
            // 
            // signup_btn
            // 
            this.signup_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_btn.Location = new System.Drawing.Point(299, 258);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(163, 29);
            this.signup_btn.TabIndex = 3;
            this.signup_btn.Text = "SIGN UP";
            this.signup_btn.UseVisualStyleBackColor = true;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(723, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "write";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(723, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "read";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.signup_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminselction);
            this.Controls.Add(this.userselction);
            this.Name = "Form1";
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button userselction;
        private System.Windows.Forms.Button adminselction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

