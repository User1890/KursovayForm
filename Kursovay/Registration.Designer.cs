namespace Kursovay
{
    partial class Registration
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.register = new System.Windows.Forms.Button();
            this.passwordR = new System.Windows.Forms.TextBox();
            this.usernameR = new System.Windows.Forms.TextBox();
            this.AvatarR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarR)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(142, 275);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(31, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Вход";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(145, 191);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(128, 23);
            this.register.TabIndex = 8;
            this.register.Text = "Зарегистрироваться";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // passwordR
            // 
            this.passwordR.Location = new System.Drawing.Point(108, 101);
            this.passwordR.Name = "passwordR";
            this.passwordR.Size = new System.Drawing.Size(165, 20);
            this.passwordR.TabIndex = 7;
            this.passwordR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordR.TextChanged += new System.EventHandler(this.passwordR_TextChanged);
            // 
            // usernameR
            // 
            this.usernameR.AccessibleDescription = "";
            this.usernameR.AccessibleName = "";
            this.usernameR.Location = new System.Drawing.Point(108, 71);
            this.usernameR.Name = "usernameR";
            this.usernameR.Size = new System.Drawing.Size(165, 20);
            this.usernameR.TabIndex = 6;
            this.usernameR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usernameR.TextChanged += new System.EventHandler(this.usernameR_TextChanged);
            // 
            // AvatarR
            // 
            this.AvatarR.BackColor = System.Drawing.Color.Wheat;
            this.AvatarR.Location = new System.Drawing.Point(53, 71);
            this.AvatarR.Name = "AvatarR";
            this.AvatarR.Size = new System.Drawing.Size(49, 50);
            this.AvatarR.TabIndex = 5;
            this.AvatarR.TabStop = false;
            this.AvatarR.Click += new System.EventHandler(this.AvatarR_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 362);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.register);
            this.Controls.Add(this.passwordR);
            this.Controls.Add(this.usernameR);
            this.Controls.Add(this.AvatarR);
            this.Name = "Registration";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AvatarR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.TextBox passwordR;
        private System.Windows.Forms.TextBox usernameR;
        private System.Windows.Forms.PictureBox AvatarR;
    }
}