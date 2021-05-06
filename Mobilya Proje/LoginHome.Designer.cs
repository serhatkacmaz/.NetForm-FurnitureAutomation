namespace Mobilya_Proje
{
    partial class LoginHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginHome));
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.panel_login = new System.Windows.Forms.Panel();
            this.btn_register = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_selection = new System.Windows.Forms.Panel();
            this.btn_about_us = new System.Windows.Forms.Button();
            this.btn_customer = new System.Windows.Forms.Button();
            this.btn_staff = new System.Windows.Forms.Button();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.pbox_logo = new System.Windows.Forms.PictureBox();
            this.panel_login.SuspendLayout();
            this.panel_selection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_username.Location = new System.Drawing.Point(156, 32);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(135, 22);
            this.txt_username.TabIndex = 0;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_password.Location = new System.Drawing.Point(156, 81);
            this.txt_password.MaxLength = 4;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(135, 22);
            this.txt_password.TabIndex = 2;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(166)))), ((int)(((byte)(230)))));
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(31, 125);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(260, 24);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_username.Location = new System.Drawing.Point(27, 32);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(51, 20);
            this.lbl_username.TabIndex = 4;
            this.lbl_username.Text = "label1";
            // 
            // panel_login
            // 
            this.panel_login.BackColor = System.Drawing.Color.Transparent;
            this.panel_login.Controls.Add(this.btn_register);
            this.panel_login.Controls.Add(this.txt_username);
            this.panel_login.Controls.Add(this.lbl_username);
            this.panel_login.Controls.Add(this.txt_password);
            this.panel_login.Controls.Add(this.label2);
            this.panel_login.Controls.Add(this.btnLogin);
            this.panel_login.Location = new System.Drawing.Point(84, 107);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(336, 189);
            this.panel_login.TabIndex = 7;
            this.panel_login.Visible = false;
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(166)))), ((int)(((byte)(230)))));
            this.btn_register.FlatAppearance.BorderSize = 0;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(31, 156);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(260, 24);
            this.btn_register.TabIndex = 6;
            this.btn_register.Text = "Kayıt Ol";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre :";
            // 
            // panel_selection
            // 
            this.panel_selection.BackColor = System.Drawing.Color.Transparent;
            this.panel_selection.Controls.Add(this.btn_about_us);
            this.panel_selection.Controls.Add(this.btn_customer);
            this.panel_selection.Controls.Add(this.btn_staff);
            this.panel_selection.Location = new System.Drawing.Point(83, 97);
            this.panel_selection.Name = "panel_selection";
            this.panel_selection.Size = new System.Drawing.Size(408, 233);
            this.panel_selection.TabIndex = 8;
            // 
            // btn_about_us
            // 
            this.btn_about_us.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_about_us.FlatAppearance.BorderSize = 0;
            this.btn_about_us.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about_us.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_about_us.ForeColor = System.Drawing.Color.Snow;
            this.btn_about_us.Location = new System.Drawing.Point(318, 205);
            this.btn_about_us.Name = "btn_about_us";
            this.btn_about_us.Size = new System.Drawing.Size(87, 23);
            this.btn_about_us.TabIndex = 2;
            this.btn_about_us.Text = "Hakkımızda";
            this.btn_about_us.UseVisualStyleBackColor = false;
            this.btn_about_us.Click += new System.EventHandler(this.btn_about_us_Click);
            // 
            // btn_customer
            // 
            this.btn_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(166)))), ((int)(((byte)(230)))));
            this.btn_customer.FlatAppearance.BorderSize = 0;
            this.btn_customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_customer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_customer.Location = new System.Drawing.Point(62, 88);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Size = new System.Drawing.Size(202, 68);
            this.btn_customer.TabIndex = 1;
            this.btn_customer.Text = "Müşteri";
            this.btn_customer.UseVisualStyleBackColor = false;
            this.btn_customer.Click += new System.EventHandler(this.btn_customer_Click);
            // 
            // btn_staff
            // 
            this.btn_staff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(166)))), ((int)(((byte)(230)))));
            this.btn_staff.FlatAppearance.BorderSize = 0;
            this.btn_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_staff.ForeColor = System.Drawing.Color.White;
            this.btn_staff.Location = new System.Drawing.Point(62, 14);
            this.btn_staff.Name = "btn_staff";
            this.btn_staff.Size = new System.Drawing.Size(202, 68);
            this.btn_staff.TabIndex = 0;
            this.btn_staff.Text = "Personel";
            this.btn_staff.UseVisualStyleBackColor = false;
            this.btn_staff.Click += new System.EventHandler(this.btn_staff_Click);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Image = global::Mobilya_Proje.Properties.Resources.icons8_back_50px;
            this.pictureBoxBack.Location = new System.Drawing.Point(12, 308);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(45, 26);
            this.pictureBoxBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxBack.TabIndex = 9;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Visible = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            // 
            // pbox_logo
            // 
            this.pbox_logo.BackColor = System.Drawing.Color.Transparent;
            this.pbox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pbox_logo.Image")));
            this.pbox_logo.Location = new System.Drawing.Point(94, 0);
            this.pbox_logo.Name = "pbox_logo";
            this.pbox_logo.Size = new System.Drawing.Size(305, 111);
            this.pbox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_logo.TabIndex = 10;
            this.pbox_logo.TabStop = false;
            // 
            // LoginHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(503, 342);
            this.Controls.Add(this.pbox_logo);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.panel_selection);
            this.Controls.Add(this.panel_login);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.LoginHome_Load);
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.panel_selection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Panel panel_selection;
        private System.Windows.Forms.Button btn_customer;
        private System.Windows.Forms.Button btn_staff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.PictureBox pbox_logo;
        private System.Windows.Forms.Button btn_about_us;
    }
}

