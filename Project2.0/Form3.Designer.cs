namespace Project2._0
{
    partial class Form3
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
            this.admn_signinbtn = new System.Windows.Forms.Button();
            this.admin_label = new System.Windows.Forms.Label();
            this.admn_user = new System.Windows.Forms.Label();
            this.admnpass = new System.Windows.Forms.Label();
            this.ui_username = new System.Windows.Forms.TextBox();
            this.ui_passward = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // admn_signinbtn
            // 
            this.admn_signinbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admn_signinbtn.Location = new System.Drawing.Point(301, 259);
            this.admn_signinbtn.Name = "admn_signinbtn";
            this.admn_signinbtn.Size = new System.Drawing.Size(140, 32);
            this.admn_signinbtn.TabIndex = 0;
            this.admn_signinbtn.Text = "SIGN IN";
            this.admn_signinbtn.UseVisualStyleBackColor = true;
            this.admn_signinbtn.Click += new System.EventHandler(this.admn_signinbtn_Click);
            // 
            // admin_label
            // 
            this.admin_label.AutoSize = true;
            this.admin_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_label.Location = new System.Drawing.Point(257, 66);
            this.admin_label.Name = "admin_label";
            this.admin_label.Size = new System.Drawing.Size(198, 29);
            this.admin_label.TabIndex = 1;
            this.admin_label.Text = "ADMIN SIGN-IN";
            // 
            // admn_user
            // 
            this.admn_user.AutoSize = true;
            this.admn_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admn_user.Location = new System.Drawing.Point(123, 156);
            this.admn_user.Name = "admn_user";
            this.admn_user.Size = new System.Drawing.Size(132, 29);
            this.admn_user.TabIndex = 2;
            this.admn_user.Text = "Username";
            // 
            // admnpass
            // 
            this.admnpass.AutoSize = true;
            this.admnpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admnpass.Location = new System.Drawing.Point(130, 197);
            this.admnpass.Name = "admnpass";
            this.admnpass.Size = new System.Drawing.Size(128, 29);
            this.admnpass.TabIndex = 3;
            this.admnpass.Text = "Password";
            // 
            // ui_username
            // 
            this.ui_username.Location = new System.Drawing.Point(260, 156);
            this.ui_username.Name = "ui_username";
            this.ui_username.Size = new System.Drawing.Size(243, 22);
            this.ui_username.TabIndex = 4;
            // 
            // ui_passward
            // 
            this.ui_passward.Location = new System.Drawing.Point(260, 197);
            this.ui_passward.Name = "ui_passward";
            this.ui_passward.Size = new System.Drawing.Size(243, 22);
            this.ui_passward.TabIndex = 5;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(50, 401);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 7;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.ui_passward);
            this.Controls.Add(this.ui_username);
            this.Controls.Add(this.admnpass);
            this.Controls.Add(this.admn_user);
            this.Controls.Add(this.admin_label);
            this.Controls.Add(this.admn_signinbtn);
            this.Name = "Form3";
            this.Text = "ADMIN LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button admn_signinbtn;
        private System.Windows.Forms.Label admin_label;
        private System.Windows.Forms.Label admn_user;
        private System.Windows.Forms.Label admnpass;
        private System.Windows.Forms.TextBox ui_username;
        private System.Windows.Forms.TextBox ui_passward;
        private System.Windows.Forms.Button back;
    }
}