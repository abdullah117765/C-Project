namespace Project2._0
{
    partial class Form2
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
            this.usrlabel1 = new System.Windows.Forms.Label();
            this.username_user = new System.Windows.Forms.Label();
            this.password_user = new System.Windows.Forms.Label();
            this.ui_username = new System.Windows.Forms.TextBox();
            this.ui_passward = new System.Windows.Forms.TextBox();
            this.userlgn_btn = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usrlabel1
            // 
            this.usrlabel1.AutoSize = true;
            this.usrlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrlabel1.Location = new System.Drawing.Point(289, 74);
            this.usrlabel1.Name = "usrlabel1";
            this.usrlabel1.Size = new System.Drawing.Size(187, 29);
            this.usrlabel1.TabIndex = 0;
            this.usrlabel1.Text = "USER SIGN-IN";
            // 
            // username_user
            // 
            this.username_user.AutoSize = true;
            this.username_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_user.Location = new System.Drawing.Point(156, 146);
            this.username_user.Name = "username_user";
            this.username_user.Size = new System.Drawing.Size(132, 29);
            this.username_user.TabIndex = 1;
            this.username_user.Text = "Username";
            // 
            // password_user
            // 
            this.password_user.AutoSize = true;
            this.password_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_user.Location = new System.Drawing.Point(156, 196);
            this.password_user.Name = "password_user";
            this.password_user.Size = new System.Drawing.Size(128, 29);
            this.password_user.TabIndex = 2;
            this.password_user.Text = "Password";
            // 
            // ui_username
            // 
            this.ui_username.Location = new System.Drawing.Point(293, 151);
            this.ui_username.Name = "ui_username";
            this.ui_username.Size = new System.Drawing.Size(224, 22);
            this.ui_username.TabIndex = 3;
            this.ui_username.TextChanged += new System.EventHandler(this.txtbox_userid_TextChanged);
            // 
            // ui_passward
            // 
            this.ui_passward.Location = new System.Drawing.Point(294, 196);
            this.ui_passward.Name = "ui_passward";
            this.ui_passward.Size = new System.Drawing.Size(224, 22);
            this.ui_passward.TabIndex = 4;
            // 
            // userlgn_btn
            // 
            this.userlgn_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlgn_btn.Location = new System.Drawing.Point(397, 235);
            this.userlgn_btn.Name = "userlgn_btn";
            this.userlgn_btn.Size = new System.Drawing.Size(121, 34);
            this.userlgn_btn.TabIndex = 5;
            this.userlgn_btn.Text = "SIGN IN";
            this.userlgn_btn.UseVisualStyleBackColor = true;
            this.userlgn_btn.Click += new System.EventHandler(this.userlgn_btn_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(84, 394);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 6;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.userlgn_btn);
            this.Controls.Add(this.ui_passward);
            this.Controls.Add(this.ui_username);
            this.Controls.Add(this.password_user);
            this.Controls.Add(this.username_user);
            this.Controls.Add(this.usrlabel1);
            this.Name = "Form2";
            this.Text = "USER LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usrlabel1;
        private System.Windows.Forms.Label username_user;
        private System.Windows.Forms.Label password_user;
        private System.Windows.Forms.TextBox ui_username;
        private System.Windows.Forms.TextBox ui_passward;
        private System.Windows.Forms.Button userlgn_btn;
        private System.Windows.Forms.Button back;
    }
}