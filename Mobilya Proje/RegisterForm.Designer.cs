namespace Mobilya_Proje
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.gpbox_adress_info = new System.Windows.Forms.GroupBox();
            this.txt_apartment_no = new System.Windows.Forms.TextBox();
            this.txt_building_no = new System.Windows.Forms.TextBox();
            this.cmbox_province = new System.Windows.Forms.ComboBox();
            this.txt_town = new System.Windows.Forms.TextBox();
            this.txt_avenue = new System.Windows.Forms.TextBox();
            this.txt_district = new System.Windows.Forms.TextBox();
            this.txt_street = new System.Windows.Forms.TextBox();
            this.lbl_province = new System.Windows.Forms.Label();
            this.lbl_town = new System.Windows.Forms.Label();
            this.lbl_building_no = new System.Windows.Forms.Label();
            this.lbl_street_name = new System.Windows.Forms.Label();
            this.lbl_aparment_no = new System.Windows.Forms.Label();
            this.lbl_district = new System.Windows.Forms.Label();
            this.lbl_avenue = new System.Windows.Forms.Label();
            this.btn_register_customer = new System.Windows.Forms.Button();
            this.gpbox_personal_info = new System.Windows.Forms.GroupBox();
            this.txt_identification = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_new_password = new System.Windows.Forms.Label();
            this.lbl_repeat_new_password = new System.Windows.Forms.Label();
            this.lbl_phone_no = new System.Windows.Forms.Label();
            this.txt_repeat_new_password = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_new_password = new System.Windows.Forms.TextBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.txt_phone_no = new System.Windows.Forms.MaskedTextBox();
            this.gpbox_adress_info.SuspendLayout();
            this.gpbox_personal_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbox_adress_info
            // 
            this.gpbox_adress_info.Controls.Add(this.txt_apartment_no);
            this.gpbox_adress_info.Controls.Add(this.txt_building_no);
            this.gpbox_adress_info.Controls.Add(this.cmbox_province);
            this.gpbox_adress_info.Controls.Add(this.txt_town);
            this.gpbox_adress_info.Controls.Add(this.txt_avenue);
            this.gpbox_adress_info.Controls.Add(this.txt_district);
            this.gpbox_adress_info.Controls.Add(this.txt_street);
            this.gpbox_adress_info.Controls.Add(this.lbl_province);
            this.gpbox_adress_info.Controls.Add(this.lbl_town);
            this.gpbox_adress_info.Controls.Add(this.lbl_building_no);
            this.gpbox_adress_info.Controls.Add(this.lbl_street_name);
            this.gpbox_adress_info.Controls.Add(this.lbl_aparment_no);
            this.gpbox_adress_info.Controls.Add(this.lbl_district);
            this.gpbox_adress_info.Controls.Add(this.lbl_avenue);
            this.gpbox_adress_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gpbox_adress_info.Location = new System.Drawing.Point(564, 53);
            this.gpbox_adress_info.Name = "gpbox_adress_info";
            this.gpbox_adress_info.Size = new System.Drawing.Size(303, 338);
            this.gpbox_adress_info.TabIndex = 21;
            this.gpbox_adress_info.TabStop = false;
            this.gpbox_adress_info.Text = "Adres";
            // 
            // txt_apartment_no
            // 
            this.txt_apartment_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_apartment_no.Location = new System.Drawing.Point(130, 174);
            this.txt_apartment_no.MaxLength = 2;
            this.txt_apartment_no.Name = "txt_apartment_no";
            this.txt_apartment_no.Size = new System.Drawing.Size(100, 22);
            this.txt_apartment_no.TabIndex = 24;
            // 
            // txt_building_no
            // 
            this.txt_building_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_building_no.Location = new System.Drawing.Point(130, 137);
            this.txt_building_no.MaxLength = 2;
            this.txt_building_no.Name = "txt_building_no";
            this.txt_building_no.Size = new System.Drawing.Size(100, 22);
            this.txt_building_no.TabIndex = 23;
            // 
            // cmbox_province
            // 
            this.cmbox_province.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_province.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbox_province.FormattingEnabled = true;
            this.cmbox_province.Location = new System.Drawing.Point(130, 262);
            this.cmbox_province.Name = "cmbox_province";
            this.cmbox_province.Size = new System.Drawing.Size(121, 24);
            this.cmbox_province.TabIndex = 26;
            this.cmbox_province.SelectedIndexChanged += new System.EventHandler(this.cmbox_province_SelectedIndexChanged);
            // 
            // txt_town
            // 
            this.txt_town.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_town.Location = new System.Drawing.Point(130, 219);
            this.txt_town.MaxLength = 20;
            this.txt_town.Name = "txt_town";
            this.txt_town.Size = new System.Drawing.Size(100, 22);
            this.txt_town.TabIndex = 25;
            // 
            // txt_avenue
            // 
            this.txt_avenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_avenue.Location = new System.Drawing.Point(130, 99);
            this.txt_avenue.MaxLength = 45;
            this.txt_avenue.Name = "txt_avenue";
            this.txt_avenue.Size = new System.Drawing.Size(100, 22);
            this.txt_avenue.TabIndex = 22;
            // 
            // txt_district
            // 
            this.txt_district.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_district.Location = new System.Drawing.Point(130, 62);
            this.txt_district.MaxLength = 45;
            this.txt_district.Name = "txt_district";
            this.txt_district.Size = new System.Drawing.Size(100, 22);
            this.txt_district.TabIndex = 21;
            // 
            // txt_street
            // 
            this.txt_street.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_street.Location = new System.Drawing.Point(130, 22);
            this.txt_street.MaxLength = 45;
            this.txt_street.Name = "txt_street";
            this.txt_street.Size = new System.Drawing.Size(100, 22);
            this.txt_street.TabIndex = 20;
            // 
            // lbl_province
            // 
            this.lbl_province.AutoSize = true;
            this.lbl_province.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_province.Location = new System.Drawing.Point(29, 265);
            this.lbl_province.Name = "lbl_province";
            this.lbl_province.Size = new System.Drawing.Size(20, 16);
            this.lbl_province.TabIndex = 19;
            this.lbl_province.Text = "İl :";
            // 
            // lbl_town
            // 
            this.lbl_town.AutoSize = true;
            this.lbl_town.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_town.Location = new System.Drawing.Point(29, 222);
            this.lbl_town.Name = "lbl_town";
            this.lbl_town.Size = new System.Drawing.Size(35, 16);
            this.lbl_town.TabIndex = 18;
            this.lbl_town.Text = "İlçe :";
            // 
            // lbl_building_no
            // 
            this.lbl_building_no.AutoSize = true;
            this.lbl_building_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_building_no.Location = new System.Drawing.Point(29, 137);
            this.lbl_building_no.Name = "lbl_building_no";
            this.lbl_building_no.Size = new System.Drawing.Size(64, 16);
            this.lbl_building_no.TabIndex = 16;
            this.lbl_building_no.Text = "Bina NO :";
            // 
            // lbl_street_name
            // 
            this.lbl_street_name.AutoSize = true;
            this.lbl_street_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_street_name.Location = new System.Drawing.Point(29, 25);
            this.lbl_street_name.Name = "lbl_street_name";
            this.lbl_street_name.Size = new System.Drawing.Size(53, 16);
            this.lbl_street_name.TabIndex = 13;
            this.lbl_street_name.Text = "Sokak :";
            // 
            // lbl_aparment_no
            // 
            this.lbl_aparment_no.AutoSize = true;
            this.lbl_aparment_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_aparment_no.Location = new System.Drawing.Point(29, 172);
            this.lbl_aparment_no.Name = "lbl_aparment_no";
            this.lbl_aparment_no.Size = new System.Drawing.Size(70, 16);
            this.lbl_aparment_no.TabIndex = 17;
            this.lbl_aparment_no.Text = "Daire NO :";
            // 
            // lbl_district
            // 
            this.lbl_district.AutoSize = true;
            this.lbl_district.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_district.Location = new System.Drawing.Point(29, 62);
            this.lbl_district.Name = "lbl_district";
            this.lbl_district.Size = new System.Drawing.Size(62, 16);
            this.lbl_district.TabIndex = 14;
            this.lbl_district.Text = "Mahalle :";
            // 
            // lbl_avenue
            // 
            this.lbl_avenue.AutoSize = true;
            this.lbl_avenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_avenue.Location = new System.Drawing.Point(29, 99);
            this.lbl_avenue.Name = "lbl_avenue";
            this.lbl_avenue.Size = new System.Drawing.Size(55, 16);
            this.lbl_avenue.TabIndex = 15;
            this.lbl_avenue.Text = "Cadde :";
            // 
            // btn_register_customer
            // 
            this.btn_register_customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(205)))), ((int)(((byte)(128)))));
            this.btn_register_customer.FlatAppearance.BorderSize = 0;
            this.btn_register_customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_register_customer.ForeColor = System.Drawing.Color.White;
            this.btn_register_customer.Location = new System.Drawing.Point(348, 430);
            this.btn_register_customer.Name = "btn_register_customer";
            this.btn_register_customer.Size = new System.Drawing.Size(244, 26);
            this.btn_register_customer.TabIndex = 13;
            this.btn_register_customer.Text = "Kaydet";
            this.btn_register_customer.UseVisualStyleBackColor = false;
            this.btn_register_customer.Click += new System.EventHandler(this.btn_register_customer_Click);
            // 
            // gpbox_personal_info
            // 
            this.gpbox_personal_info.Controls.Add(this.txt_identification);
            this.gpbox_personal_info.Controls.Add(this.txt_email);
            this.gpbox_personal_info.Controls.Add(this.label1);
            this.gpbox_personal_info.Controls.Add(this.lbl_name);
            this.gpbox_personal_info.Controls.Add(this.lbl_surname);
            this.gpbox_personal_info.Controls.Add(this.lbl_email);
            this.gpbox_personal_info.Controls.Add(this.lbl_new_password);
            this.gpbox_personal_info.Controls.Add(this.lbl_repeat_new_password);
            this.gpbox_personal_info.Controls.Add(this.lbl_phone_no);
            this.gpbox_personal_info.Controls.Add(this.txt_repeat_new_password);
            this.gpbox_personal_info.Controls.Add(this.txt_name);
            this.gpbox_personal_info.Controls.Add(this.txt_new_password);
            this.gpbox_personal_info.Controls.Add(this.txt_surname);
            this.gpbox_personal_info.Controls.Add(this.txt_phone_no);
            this.gpbox_personal_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gpbox_personal_info.Location = new System.Drawing.Point(30, 53);
            this.gpbox_personal_info.Name = "gpbox_personal_info";
            this.gpbox_personal_info.Size = new System.Drawing.Size(373, 338);
            this.gpbox_personal_info.TabIndex = 20;
            this.gpbox_personal_info.TabStop = false;
            this.gpbox_personal_info.Text = "Kişisel Bilgiler";
            // 
            // txt_identification
            // 
            this.txt_identification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_identification.Location = new System.Drawing.Point(193, 101);
            this.txt_identification.MaxLength = 11;
            this.txt_identification.Name = "txt_identification";
            this.txt_identification.Size = new System.Drawing.Size(100, 22);
            this.txt_identification.TabIndex = 8;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_email.Location = new System.Drawing.Point(193, 172);
            this.txt_email.MaxLength = 35;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 22);
            this.txt_email.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(61, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "TC :";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_name.Location = new System.Drawing.Point(61, 30);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(31, 16);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Ad :";
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_surname.Location = new System.Drawing.Point(61, 67);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(57, 16);
            this.lbl_surname.TabIndex = 1;
            this.lbl_surname.Text = " Soyad :";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_email.Location = new System.Drawing.Point(61, 175);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(52, 16);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "E-mail :";
            // 
            // lbl_new_password
            // 
            this.lbl_new_password.AutoSize = true;
            this.lbl_new_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_new_password.Location = new System.Drawing.Point(61, 230);
            this.lbl_new_password.Name = "lbl_new_password";
            this.lbl_new_password.Size = new System.Drawing.Size(90, 16);
            this.lbl_new_password.TabIndex = 3;
            this.lbl_new_password.Text = "Şifrenizi Girin :";
            // 
            // lbl_repeat_new_password
            // 
            this.lbl_repeat_new_password.AutoSize = true;
            this.lbl_repeat_new_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_repeat_new_password.Location = new System.Drawing.Point(61, 262);
            this.lbl_repeat_new_password.Name = "lbl_repeat_new_password";
            this.lbl_repeat_new_password.Size = new System.Drawing.Size(84, 16);
            this.lbl_repeat_new_password.TabIndex = 4;
            this.lbl_repeat_new_password.Text = "Tekrar Şifre :";
            // 
            // lbl_phone_no
            // 
            this.lbl_phone_no.AutoSize = true;
            this.lbl_phone_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_phone_no.Location = new System.Drawing.Point(61, 134);
            this.lbl_phone_no.Name = "lbl_phone_no";
            this.lbl_phone_no.Size = new System.Drawing.Size(121, 16);
            this.lbl_phone_no.TabIndex = 5;
            this.lbl_phone_no.Text = "Telefon Numarası :";
            // 
            // txt_repeat_new_password
            // 
            this.txt_repeat_new_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_repeat_new_password.Location = new System.Drawing.Point(193, 262);
            this.txt_repeat_new_password.MaxLength = 4;
            this.txt_repeat_new_password.Name = "txt_repeat_new_password";
            this.txt_repeat_new_password.Size = new System.Drawing.Size(100, 22);
            this.txt_repeat_new_password.TabIndex = 12;
            this.txt_repeat_new_password.UseSystemPasswordChar = true;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_name.Location = new System.Drawing.Point(193, 30);
            this.txt_name.MaxLength = 20;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 22);
            this.txt_name.TabIndex = 6;
            // 
            // txt_new_password
            // 
            this.txt_new_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_new_password.Location = new System.Drawing.Point(193, 223);
            this.txt_new_password.MaxLength = 4;
            this.txt_new_password.Name = "txt_new_password";
            this.txt_new_password.Size = new System.Drawing.Size(100, 22);
            this.txt_new_password.TabIndex = 11;
            this.txt_new_password.UseSystemPasswordChar = true;
            // 
            // txt_surname
            // 
            this.txt_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_surname.Location = new System.Drawing.Point(193, 67);
            this.txt_surname.MaxLength = 25;
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(100, 22);
            this.txt_surname.TabIndex = 7;
            // 
            // txt_phone_no
            // 
            this.txt_phone_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_phone_no.Location = new System.Drawing.Point(193, 134);
            this.txt_phone_no.Mask = "(000) 00-00-0000";
            this.txt_phone_no.Name = "txt_phone_no";
            this.txt_phone_no.Size = new System.Drawing.Size(100, 22);
            this.txt_phone_no.TabIndex = 9;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(921, 468);
            this.Controls.Add(this.btn_register_customer);
            this.Controls.Add(this.gpbox_adress_info);
            this.Controls.Add(this.gpbox_personal_info);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Formu";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.gpbox_adress_info.ResumeLayout(false);
            this.gpbox_adress_info.PerformLayout();
            this.gpbox_personal_info.ResumeLayout(false);
            this.gpbox_personal_info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbox_adress_info;
        private System.Windows.Forms.ComboBox cmbox_province;
        private System.Windows.Forms.TextBox txt_town;
        private System.Windows.Forms.TextBox txt_avenue;
        private System.Windows.Forms.TextBox txt_district;
        private System.Windows.Forms.TextBox txt_street;
        private System.Windows.Forms.Label lbl_province;
        private System.Windows.Forms.Label lbl_town;
        private System.Windows.Forms.Label lbl_building_no;
        private System.Windows.Forms.Label lbl_street_name;
        private System.Windows.Forms.Label lbl_aparment_no;
        private System.Windows.Forms.Label lbl_district;
        private System.Windows.Forms.Label lbl_avenue;
        private System.Windows.Forms.Button btn_register_customer;
        private System.Windows.Forms.GroupBox gpbox_personal_info;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_new_password;
        private System.Windows.Forms.Label lbl_repeat_new_password;
        private System.Windows.Forms.Label lbl_phone_no;
        private System.Windows.Forms.TextBox txt_repeat_new_password;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_new_password;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.MaskedTextBox txt_phone_no;
        private System.Windows.Forms.TextBox txt_identification;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_apartment_no;
        private System.Windows.Forms.TextBox txt_building_no;
    }
}