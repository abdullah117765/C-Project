namespace Project2._0
{
    partial class form5
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
            this.view_usr_tt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ui_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // view_usr_tt
            // 
            this.view_usr_tt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_usr_tt.Location = new System.Drawing.Point(258, 101);
            this.view_usr_tt.Name = "view_usr_tt";
            this.view_usr_tt.Size = new System.Drawing.Size(267, 74);
            this.view_usr_tt.TabIndex = 0;
            this.view_usr_tt.Text = "VIEW TIME TABLE";
            this.view_usr_tt.UseVisualStyleBackColor = true;
            this.view_usr_tt.Click += new System.EventHandler(this.view_usr_tt_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(258, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "ARRANGE MAKEUP CLASSES";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ui_back
            // 
            this.ui_back.Location = new System.Drawing.Point(47, 385);
            this.ui_back.Name = "ui_back";
            this.ui_back.Size = new System.Drawing.Size(75, 23);
            this.ui_back.TabIndex = 13;
            this.ui_back.Text = "<=  Home";
            this.ui_back.UseVisualStyleBackColor = true;
            this.ui_back.Click += new System.EventHandler(this.ui_back_Click);
            // 
            // form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ui_back);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.view_usr_tt);
            this.Name = "form5";
            this.Text = "USER PANEL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button view_usr_tt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ui_back;
    }
}