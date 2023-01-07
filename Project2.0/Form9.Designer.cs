namespace Project2._0
{
    partial class Form9
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
            this.ui_delete = new System.Windows.Forms.Button();
            this.ui_username = new System.Windows.Forms.TextBox();
            this.username_user = new System.Windows.Forms.Label();
            this.usrlabel1 = new System.Windows.Forms.Label();
            this.ui_back = new System.Windows.Forms.Button();
            this.ui_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ui_delete
            // 
            this.ui_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_delete.Location = new System.Drawing.Point(323, 251);
            this.ui_delete.Name = "ui_delete";
            this.ui_delete.Size = new System.Drawing.Size(121, 34);
            this.ui_delete.TabIndex = 11;
            this.ui_delete.Text = "Delete";
            this.ui_delete.UseVisualStyleBackColor = true;
            this.ui_delete.Click += new System.EventHandler(this.ui_delete_Click);
            // 
            // ui_username
            // 
            this.ui_username.Location = new System.Drawing.Point(309, 148);
            this.ui_username.Name = "ui_username";
            this.ui_username.Size = new System.Drawing.Size(224, 22);
            this.ui_username.TabIndex = 9;
            // 
            // username_user
            // 
            this.username_user.AutoSize = true;
            this.username_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_user.Location = new System.Drawing.Point(172, 143);
            this.username_user.Name = "username_user";
            this.username_user.Size = new System.Drawing.Size(132, 29);
            this.username_user.TabIndex = 7;
            this.username_user.Text = "Username";
            // 
            // usrlabel1
            // 
            this.usrlabel1.AutoSize = true;
            this.usrlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrlabel1.Location = new System.Drawing.Point(305, 71);
            this.usrlabel1.Name = "usrlabel1";
            this.usrlabel1.Size = new System.Drawing.Size(152, 29);
            this.usrlabel1.TabIndex = 6;
            this.usrlabel1.Text = "Delete User";
            // 
            // ui_back
            // 
            this.ui_back.Location = new System.Drawing.Point(43, 391);
            this.ui_back.Name = "ui_back";
            this.ui_back.Size = new System.Drawing.Size(75, 23);
            this.ui_back.TabIndex = 12;
            this.ui_back.Text = "Back";
            this.ui_back.UseVisualStyleBackColor = true;
            this.ui_back.Click += new System.EventHandler(this.ui_back_Click);
            // 
            // ui_password
            // 
            this.ui_password.Location = new System.Drawing.Point(309, 189);
            this.ui_password.Name = "ui_password";
            this.ui_password.Size = new System.Drawing.Size(224, 22);
            this.ui_password.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Passward";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ui_password);
            this.Controls.Add(this.ui_back);
            this.Controls.Add(this.ui_delete);
            this.Controls.Add(this.ui_username);
            this.Controls.Add(this.username_user);
            this.Controls.Add(this.usrlabel1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ui_delete;
        private System.Windows.Forms.TextBox ui_username;
        private System.Windows.Forms.Label username_user;
        private System.Windows.Forms.Label usrlabel1;
        private System.Windows.Forms.Button ui_back;
        private System.Windows.Forms.TextBox ui_password;
        private System.Windows.Forms.Label label1;
    }
}