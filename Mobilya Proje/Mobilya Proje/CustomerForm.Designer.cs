namespace Mobilya_Proje
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.tabctrl_customer_panel = new System.Windows.Forms.TabControl();
            this.tblpage_order = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_product_search = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbox_category = new System.Windows.Forms.ComboBox();
            this.btn_add_to_card = new System.Windows.Forms.Button();
            this.cmbox_payment_selection = new System.Windows.Forms.ComboBox();
            this.lbl_payment_title = new System.Windows.Forms.Label();
            this.btn_cart_confirm = new System.Windows.Forms.Button();
            this.btn_clear_cart = new System.Windows.Forms.Button();
            this.btn_decrease_item = new System.Windows.Forms.Button();
            this.lbl_staff_names = new System.Windows.Forms.Label();
            this.cmbox_staff_selection = new System.Windows.Forms.ComboBox();
            this.btn_increase_item = new System.Windows.Forms.Button();
            this.lbl_shopping_cart_title = new System.Windows.Forms.Label();
            this.dtgd_shopping_cart = new System.Windows.Forms.DataGridView();
            this.lbl_product_title = new System.Windows.Forms.Label();
            this.dtgd_product_table = new System.Windows.Forms.DataGridView();
            this.lbl_branch_name = new System.Windows.Forms.Label();
            this.cmbox_branch_selection = new System.Windows.Forms.ComboBox();
            this.tbpage_personal_info = new System.Windows.Forms.TabPage();
            this.gpbox_adress_info = new System.Windows.Forms.GroupBox();
            this.btn_update_adrinfo = new System.Windows.Forms.Button();
            this.cmbox_province = new System.Windows.Forms.ComboBox();
            this.txt_town = new System.Windows.Forms.TextBox();
            this.txt_apartment_no = new System.Windows.Forms.MaskedTextBox();
            this.txt_building_no = new System.Windows.Forms.MaskedTextBox();
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
            this.gpbox_personal_info = new System.Windows.Forms.GroupBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_new_password = new System.Windows.Forms.Label();
            this.lbl_repeat_new_password = new System.Windows.Forms.Label();
            this.btn_update_perinfo = new System.Windows.Forms.Button();
            this.lbl_phone_no = new System.Windows.Forms.Label();
            this.txt_repeat_new_password = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_new_password = new System.Windows.Forms.TextBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.txt_phone_no = new System.Windows.Forms.MaskedTextBox();
            this.tbpage_bills = new System.Windows.Forms.TabPage();
            this.btn_order_remove = new System.Windows.Forms.Button();
            this.gpbox_bill_info = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_bill_date = new System.Windows.Forms.Label();
            this.lbl_total_price = new System.Windows.Forms.Label();
            this.lbl_sales_rep = new System.Windows.Forms.Label();
            this.lbl_branch_title = new System.Windows.Forms.Label();
            this.lbl_bill_no = new System.Windows.Forms.Label();
            this.btn_save_as_pdf = new System.Windows.Forms.Button();
            this.dtgd_order_details = new System.Windows.Forms.DataGridView();
            this.lbl_order_detail_title = new System.Windows.Forms.Label();
            this.lbl_order_table_title = new System.Windows.Forms.Label();
            this.dtgd_order_info_table = new System.Windows.Forms.DataGridView();
            this.lbl_customer_info = new System.Windows.Forms.Label();
            this.chckbox_completed = new System.Windows.Forms.CheckBox();
            this.tabctrl_customer_panel.SuspendLayout();
            this.tblpage_order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgd_shopping_cart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgd_product_table)).BeginInit();
            this.tbpage_personal_info.SuspendLayout();
            this.gpbox_adress_info.SuspendLayout();
            this.gpbox_personal_info.SuspendLayout();
            this.tbpage_bills.SuspendLayout();
            this.gpbox_bill_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgd_order_details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgd_order_info_table)).BeginInit();
            this.SuspendLayout();
            // 
            // tabctrl_customer_panel
            // 
            this.tabctrl_customer_panel.Controls.Add(this.tblpage_order);
            this.tabctrl_customer_panel.Controls.Add(this.tbpage_personal_info);
            this.tabctrl_customer_panel.Controls.Add(this.tbpage_bills);
            this.tabctrl_customer_panel.Location = new System.Drawing.Point(12, 12);
            this.tabctrl_customer_panel.Name = "tabctrl_customer_panel";
            this.tabctrl_customer_panel.SelectedIndex = 0;
            this.tabctrl_customer_panel.Size = new System.Drawing.Size(973, 464);
            this.tabctrl_customer_panel.TabIndex = 0;
            // 
            // tblpage_order
            // 
            this.tblpage_order.BackColor = System.Drawing.Color.Linen;
            this.tblpage_order.Controls.Add(this.label7);
            this.tblpage_order.Controls.Add(this.txt_product_search);
            this.tblpage_order.Controls.Add(this.label6);
            this.tblpage_order.Controls.Add(this.cmbox_category);
            this.tblpage_order.Controls.Add(this.btn_add_to_card);
            this.tblpage_order.Controls.Add(this.cmbox_payment_selection);
            this.tblpage_order.Controls.Add(this.lbl_payment_title);
            this.tblpage_order.Controls.Add(this.btn_cart_confirm);
            this.tblpage_order.Controls.Add(this.btn_clear_cart);
            this.tblpage_order.Controls.Add(this.btn_decrease_item);
            this.tblpage_order.Controls.Add(this.lbl_staff_names);
            this.tblpage_order.Controls.Add(this.cmbox_staff_selection);
            this.tblpage_order.Controls.Add(this.btn_increase_item);
            this.tblpage_order.Controls.Add(this.lbl_shopping_cart_title);
            this.tblpage_order.Controls.Add(this.dtgd_shopping_cart);
            this.tblpage_order.Controls.Add(this.lbl_product_title);
            this.tblpage_order.Controls.Add(this.dtgd_product_table);
            this.tblpage_order.Controls.Add(this.lbl_branch_name);
            this.tblpage_order.Controls.Add(this.cmbox_branch_selection);
            this.tblpage_order.Location = new System.Drawing.Point(4, 22);
            this.tblpage_order.Name = "tblpage_order";
            this.tblpage_order.Padding = new System.Windows.Forms.Padding(3);
            this.tblpage_order.Size = new System.Drawing.Size(965, 438);
            this.tblpage_order.TabIndex = 0;
            this.tblpage_order.Text = "SİPARİŞ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(476, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ürün Ara";
            // 
            // txt_product_search
            // 
            this.txt_product_search.Location = new System.Drawing.Point(562, 368);
            this.txt_product_search.Name = "txt_product_search";
            this.txt_product_search.Size = new System.Drawing.Size(121, 20);
            this.txt_product_search.TabIndex = 17;
            this.txt_product_search.TextChanged += new System.EventHandler(this.txt_product_search_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(476, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kategori";
            // 
            // cmbox_category
            // 
            this.cmbox_category.FormattingEnabled = true;
            this.cmbox_category.Location = new System.Drawing.Point(562, 327);
            this.cmbox_category.Name = "cmbox_category";
            this.cmbox_category.Size = new System.Drawing.Size(121, 21);
            this.cmbox_category.TabIndex = 15;
            this.cmbox_category.SelectedIndexChanged += new System.EventHandler(this.cmbox_category_SelectedIndexChanged);
            // 
            // btn_add_to_card
            // 
            this.btn_add_to_card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btn_add_to_card.FlatAppearance.BorderSize = 0;
            this.btn_add_to_card.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_to_card.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_add_to_card.ForeColor = System.Drawing.Color.White;
            this.btn_add_to_card.Location = new System.Drawing.Point(812, 325);
            this.btn_add_to_card.Name = "btn_add_to_card";
            this.btn_add_to_card.Size = new System.Drawing.Size(136, 24);
            this.btn_add_to_card.TabIndex = 14;
            this.btn_add_to_card.Text = "Sepete Ekle";
            this.btn_add_to_card.UseVisualStyleBackColor = false;
            this.btn_add_to_card.Click += new System.EventHandler(this.btn_add_to_card_Click);
            // 
            // cmbox_payment_selection
            // 
            this.cmbox_payment_selection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_payment_selection.FormattingEnabled = true;
            this.cmbox_payment_selection.Location = new System.Drawing.Point(138, 113);
            this.cmbox_payment_selection.Name = "cmbox_payment_selection";
            this.cmbox_payment_selection.Size = new System.Drawing.Size(121, 21);
            this.cmbox_payment_selection.TabIndex = 13;
            this.cmbox_payment_selection.SelectedIndexChanged += new System.EventHandler(this.cmbox_payment_selection_SelectedIndexChanged);
            // 
            // lbl_payment_title
            // 
            this.lbl_payment_title.AutoSize = true;
            this.lbl_payment_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_payment_title.Location = new System.Drawing.Point(16, 110);
            this.lbl_payment_title.Name = "lbl_payment_title";
            this.lbl_payment_title.Size = new System.Drawing.Size(105, 16);
            this.lbl_payment_title.TabIndex = 12;
            this.lbl_payment_title.Text = "Ödeme Yöntemi";
            // 
            // btn_cart_confirm
            // 
            this.btn_cart_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btn_cart_confirm.FlatAppearance.BorderSize = 0;
            this.btn_cart_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cart_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cart_confirm.ForeColor = System.Drawing.Color.White;
            this.btn_cart_confirm.Location = new System.Drawing.Point(190, 379);
            this.btn_cart_confirm.Name = "btn_cart_confirm";
            this.btn_cart_confirm.Size = new System.Drawing.Size(114, 25);
            this.btn_cart_confirm.TabIndex = 11;
            this.btn_cart_confirm.Text = "Sepeti Onayla";
            this.btn_cart_confirm.UseVisualStyleBackColor = false;
            this.btn_cart_confirm.Click += new System.EventHandler(this.btn_cart_confirm_Click);
            // 
            // btn_clear_cart
            // 
            this.btn_clear_cart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btn_clear_cart.FlatAppearance.BorderSize = 0;
            this.btn_clear_cart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear_cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_clear_cart.ForeColor = System.Drawing.Color.White;
            this.btn_clear_cart.Location = new System.Drawing.Point(19, 379);
            this.btn_clear_cart.Name = "btn_clear_cart";
            this.btn_clear_cart.Size = new System.Drawing.Size(128, 25);
            this.btn_clear_cart.TabIndex = 10;
            this.btn_clear_cart.Text = "Sepeti Temizle";
            this.btn_clear_cart.UseVisualStyleBackColor = false;
            this.btn_clear_cart.Click += new System.EventHandler(this.btn_clear_cart_Click);
            // 
            // btn_decrease_item
            // 
            this.btn_decrease_item.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_decrease_item.FlatAppearance.BorderSize = 0;
            this.btn_decrease_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_decrease_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_decrease_item.ForeColor = System.Drawing.Color.White;
            this.btn_decrease_item.Location = new System.Drawing.Point(261, 322);
            this.btn_decrease_item.Name = "btn_decrease_item";
            this.btn_decrease_item.Size = new System.Drawing.Size(33, 27);
            this.btn_decrease_item.TabIndex = 9;
            this.btn_decrease_item.Text = "-";
            this.btn_decrease_item.UseVisualStyleBackColor = false;
            this.btn_decrease_item.Click += new System.EventHandler(this.btn_decrease_item_Click);
            // 
            // lbl_staff_names
            // 
            this.lbl_staff_names.AutoSize = true;
            this.lbl_staff_names.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_staff_names.Location = new System.Drawing.Point(16, 68);
            this.lbl_staff_names.Name = "lbl_staff_names";
            this.lbl_staff_names.Size = new System.Drawing.Size(102, 16);
            this.lbl_staff_names.TabIndex = 8;
            this.lbl_staff_names.Text = "Satış Temsilcisi";
            // 
            // cmbox_staff_selection
            // 
            this.cmbox_staff_selection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_staff_selection.FormattingEnabled = true;
            this.cmbox_staff_selection.Location = new System.Drawing.Point(138, 63);
            this.cmbox_staff_selection.Name = "cmbox_staff_selection";
            this.cmbox_staff_selection.Size = new System.Drawing.Size(121, 21);
            this.cmbox_staff_selection.TabIndex = 7;
            this.cmbox_staff_selection.SelectedIndexChanged += new System.EventHandler(this.cmbox_staff_selection_SelectedIndexChanged);
            // 
            // btn_increase_item
            // 
            this.btn_increase_item.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_increase_item.FlatAppearance.BorderSize = 0;
            this.btn_increase_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_increase_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_increase_item.ForeColor = System.Drawing.Color.White;
            this.btn_increase_item.Location = new System.Drawing.Point(222, 322);
            this.btn_increase_item.Name = "btn_increase_item";
            this.btn_increase_item.Size = new System.Drawing.Size(33, 27);
            this.btn_increase_item.TabIndex = 6;
            this.btn_increase_item.Text = "+";
            this.btn_increase_item.UseVisualStyleBackColor = false;
            this.btn_increase_item.Click += new System.EventHandler(this.btn_increase_item_Click);
            // 
            // lbl_shopping_cart_title
            // 
            this.lbl_shopping_cart_title.AutoSize = true;
            this.lbl_shopping_cart_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_shopping_cart_title.Location = new System.Drawing.Point(16, 142);
            this.lbl_shopping_cart_title.Name = "lbl_shopping_cart_title";
            this.lbl_shopping_cart_title.Size = new System.Drawing.Size(69, 18);
            this.lbl_shopping_cart_title.TabIndex = 5;
            this.lbl_shopping_cart_title.Text = "Sepetim";
            // 
            // dtgd_shopping_cart
            // 
            this.dtgd_shopping_cart.AllowUserToAddRows = false;
            this.dtgd_shopping_cart.AllowUserToDeleteRows = false;
            this.dtgd_shopping_cart.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgd_shopping_cart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgd_shopping_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgd_shopping_cart.Location = new System.Drawing.Point(6, 166);
            this.dtgd_shopping_cart.MultiSelect = false;
            this.dtgd_shopping_cart.Name = "dtgd_shopping_cart";
            this.dtgd_shopping_cart.ReadOnly = true;
            this.dtgd_shopping_cart.RowHeadersVisible = false;
            this.dtgd_shopping_cart.Size = new System.Drawing.Size(288, 150);
            this.dtgd_shopping_cart.TabIndex = 4;
            // 
            // lbl_product_title
            // 
            this.lbl_product_title.AutoSize = true;
            this.lbl_product_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_product_title.Location = new System.Drawing.Point(329, 19);
            this.lbl_product_title.Name = "lbl_product_title";
            this.lbl_product_title.Size = new System.Drawing.Size(63, 18);
            this.lbl_product_title.TabIndex = 3;
            this.lbl_product_title.Text = "Ürünler";
            // 
            // dtgd_product_table
            // 
            this.dtgd_product_table.AllowUserToAddRows = false;
            this.dtgd_product_table.AllowUserToDeleteRows = false;
            this.dtgd_product_table.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgd_product_table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgd_product_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgd_product_table.Location = new System.Drawing.Point(327, 40);
            this.dtgd_product_table.MultiSelect = false;
            this.dtgd_product_table.Name = "dtgd_product_table";
            this.dtgd_product_table.ReadOnly = true;
            this.dtgd_product_table.RowHeadersVisible = false;
            this.dtgd_product_table.Size = new System.Drawing.Size(616, 276);
            this.dtgd_product_table.TabIndex = 2;
            // 
            // lbl_branch_name
            // 
            this.lbl_branch_name.AutoSize = true;
            this.lbl_branch_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_branch_name.Location = new System.Drawing.Point(16, 25);
            this.lbl_branch_name.Name = "lbl_branch_name";
            this.lbl_branch_name.Size = new System.Drawing.Size(67, 16);
            this.lbl_branch_name.TabIndex = 1;
            this.lbl_branch_name.Text = "Şube İsmi";
            // 
            // cmbox_branch_selection
            // 
            this.cmbox_branch_selection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_branch_selection.FormattingEnabled = true;
            this.cmbox_branch_selection.Location = new System.Drawing.Point(138, 20);
            this.cmbox_branch_selection.Name = "cmbox_branch_selection";
            this.cmbox_branch_selection.Size = new System.Drawing.Size(121, 21);
            this.cmbox_branch_selection.TabIndex = 0;
            this.cmbox_branch_selection.SelectedIndexChanged += new System.EventHandler(this.cmbox_branch_selection_SelectedIndexChanged);
            // 
            // tbpage_personal_info
            // 
            this.tbpage_personal_info.BackColor = System.Drawing.Color.Linen;
            this.tbpage_personal_info.Controls.Add(this.gpbox_adress_info);
            this.tbpage_personal_info.Controls.Add(this.gpbox_personal_info);
            this.tbpage_personal_info.Location = new System.Drawing.Point(4, 22);
            this.tbpage_personal_info.Name = "tbpage_personal_info";
            this.tbpage_personal_info.Padding = new System.Windows.Forms.Padding(3);
            this.tbpage_personal_info.Size = new System.Drawing.Size(965, 438);
            this.tbpage_personal_info.TabIndex = 1;
            this.tbpage_personal_info.Text = "BİLGİLERİM";
            this.tbpage_personal_info.Enter += new System.EventHandler(this.tbpage_personal_info_Enter);
            // 
            // gpbox_adress_info
            // 
            this.gpbox_adress_info.Controls.Add(this.btn_update_adrinfo);
            this.gpbox_adress_info.Controls.Add(this.cmbox_province);
            this.gpbox_adress_info.Controls.Add(this.txt_town);
            this.gpbox_adress_info.Controls.Add(this.txt_apartment_no);
            this.gpbox_adress_info.Controls.Add(this.txt_building_no);
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
            this.gpbox_adress_info.Location = new System.Drawing.Point(542, 44);
            this.gpbox_adress_info.Name = "gpbox_adress_info";
            this.gpbox_adress_info.Size = new System.Drawing.Size(372, 370);
            this.gpbox_adress_info.TabIndex = 19;
            this.gpbox_adress_info.TabStop = false;
            this.gpbox_adress_info.Text = "Adres";
            // 
            // btn_update_adrinfo
            // 
            this.btn_update_adrinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btn_update_adrinfo.FlatAppearance.BorderSize = 0;
            this.btn_update_adrinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_adrinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_update_adrinfo.ForeColor = System.Drawing.Color.White;
            this.btn_update_adrinfo.Location = new System.Drawing.Point(28, 312);
            this.btn_update_adrinfo.Name = "btn_update_adrinfo";
            this.btn_update_adrinfo.Size = new System.Drawing.Size(322, 26);
            this.btn_update_adrinfo.TabIndex = 13;
            this.btn_update_adrinfo.Text = "Düzenle";
            this.btn_update_adrinfo.UseVisualStyleBackColor = false;
            this.btn_update_adrinfo.Click += new System.EventHandler(this.btn_update_adrinfo_Click);
            // 
            // cmbox_province
            // 
            this.cmbox_province.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_province.Enabled = false;
            this.cmbox_province.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbox_province.FormattingEnabled = true;
            this.cmbox_province.Location = new System.Drawing.Point(170, 260);
            this.cmbox_province.Name = "cmbox_province";
            this.cmbox_province.Size = new System.Drawing.Size(121, 24);
            this.cmbox_province.TabIndex = 26;
            this.cmbox_province.SelectedIndexChanged += new System.EventHandler(this.cmbox_province_SelectedIndexChanged);
            // 
            // txt_town
            // 
            this.txt_town.Enabled = false;
            this.txt_town.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_town.Location = new System.Drawing.Point(170, 225);
            this.txt_town.MaxLength = 20;
            this.txt_town.Name = "txt_town";
            this.txt_town.Size = new System.Drawing.Size(100, 22);
            this.txt_town.TabIndex = 25;
            // 
            // txt_apartment_no
            // 
            this.txt_apartment_no.Enabled = false;
            this.txt_apartment_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_apartment_no.Location = new System.Drawing.Point(170, 178);
            this.txt_apartment_no.Mask = "00";
            this.txt_apartment_no.Name = "txt_apartment_no";
            this.txt_apartment_no.PromptChar = ' ';
            this.txt_apartment_no.Size = new System.Drawing.Size(100, 22);
            this.txt_apartment_no.TabIndex = 24;
            this.txt_apartment_no.ValidatingType = typeof(int);
            // 
            // txt_building_no
            // 
            this.txt_building_no.Enabled = false;
            this.txt_building_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_building_no.Location = new System.Drawing.Point(170, 143);
            this.txt_building_no.Mask = "00";
            this.txt_building_no.Name = "txt_building_no";
            this.txt_building_no.PromptChar = ' ';
            this.txt_building_no.Size = new System.Drawing.Size(100, 22);
            this.txt_building_no.TabIndex = 23;
            this.txt_building_no.ValidatingType = typeof(int);
            // 
            // txt_avenue
            // 
            this.txt_avenue.Enabled = false;
            this.txt_avenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_avenue.Location = new System.Drawing.Point(170, 105);
            this.txt_avenue.MaxLength = 45;
            this.txt_avenue.Name = "txt_avenue";
            this.txt_avenue.Size = new System.Drawing.Size(100, 22);
            this.txt_avenue.TabIndex = 22;
            // 
            // txt_district
            // 
            this.txt_district.Enabled = false;
            this.txt_district.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_district.Location = new System.Drawing.Point(170, 68);
            this.txt_district.MaxLength = 45;
            this.txt_district.Name = "txt_district";
            this.txt_district.Size = new System.Drawing.Size(100, 22);
            this.txt_district.TabIndex = 21;
            // 
            // txt_street
            // 
            this.txt_street.Enabled = false;
            this.txt_street.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_street.Location = new System.Drawing.Point(170, 28);
            this.txt_street.MaxLength = 45;
            this.txt_street.Name = "txt_street";
            this.txt_street.Size = new System.Drawing.Size(100, 22);
            this.txt_street.TabIndex = 20;
            // 
            // lbl_province
            // 
            this.lbl_province.AutoSize = true;
            this.lbl_province.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_province.Location = new System.Drawing.Point(69, 263);
            this.lbl_province.Name = "lbl_province";
            this.lbl_province.Size = new System.Drawing.Size(14, 16);
            this.lbl_province.TabIndex = 19;
            this.lbl_province.Text = "İl";
            // 
            // lbl_town
            // 
            this.lbl_town.AutoSize = true;
            this.lbl_town.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_town.Location = new System.Drawing.Point(69, 228);
            this.lbl_town.Name = "lbl_town";
            this.lbl_town.Size = new System.Drawing.Size(29, 16);
            this.lbl_town.TabIndex = 18;
            this.lbl_town.Text = "İlçe";
            // 
            // lbl_building_no
            // 
            this.lbl_building_no.AutoSize = true;
            this.lbl_building_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_building_no.Location = new System.Drawing.Point(69, 143);
            this.lbl_building_no.Name = "lbl_building_no";
            this.lbl_building_no.Size = new System.Drawing.Size(58, 16);
            this.lbl_building_no.TabIndex = 16;
            this.lbl_building_no.Text = "Bina NO";
            // 
            // lbl_street_name
            // 
            this.lbl_street_name.AutoSize = true;
            this.lbl_street_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_street_name.Location = new System.Drawing.Point(69, 31);
            this.lbl_street_name.Name = "lbl_street_name";
            this.lbl_street_name.Size = new System.Drawing.Size(47, 16);
            this.lbl_street_name.TabIndex = 13;
            this.lbl_street_name.Text = "Sokak";
            // 
            // lbl_aparment_no
            // 
            this.lbl_aparment_no.AutoSize = true;
            this.lbl_aparment_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_aparment_no.Location = new System.Drawing.Point(69, 178);
            this.lbl_aparment_no.Name = "lbl_aparment_no";
            this.lbl_aparment_no.Size = new System.Drawing.Size(64, 16);
            this.lbl_aparment_no.TabIndex = 17;
            this.lbl_aparment_no.Text = "Daire NO";
            // 
            // lbl_district
            // 
            this.lbl_district.AutoSize = true;
            this.lbl_district.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_district.Location = new System.Drawing.Point(69, 68);
            this.lbl_district.Name = "lbl_district";
            this.lbl_district.Size = new System.Drawing.Size(56, 16);
            this.lbl_district.TabIndex = 14;
            this.lbl_district.Text = "Mahalle";
            // 
            // lbl_avenue
            // 
            this.lbl_avenue.AutoSize = true;
            this.lbl_avenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_avenue.Location = new System.Drawing.Point(69, 105);
            this.lbl_avenue.Name = "lbl_avenue";
            this.lbl_avenue.Size = new System.Drawing.Size(49, 16);
            this.lbl_avenue.TabIndex = 15;
            this.lbl_avenue.Text = "Cadde";
            // 
            // gpbox_personal_info
            // 
            this.gpbox_personal_info.Controls.Add(this.txt_email);
            this.gpbox_personal_info.Controls.Add(this.lbl_name);
            this.gpbox_personal_info.Controls.Add(this.lbl_surname);
            this.gpbox_personal_info.Controls.Add(this.lbl_email);
            this.gpbox_personal_info.Controls.Add(this.lbl_new_password);
            this.gpbox_personal_info.Controls.Add(this.lbl_repeat_new_password);
            this.gpbox_personal_info.Controls.Add(this.btn_update_perinfo);
            this.gpbox_personal_info.Controls.Add(this.lbl_phone_no);
            this.gpbox_personal_info.Controls.Add(this.txt_repeat_new_password);
            this.gpbox_personal_info.Controls.Add(this.txt_name);
            this.gpbox_personal_info.Controls.Add(this.txt_new_password);
            this.gpbox_personal_info.Controls.Add(this.txt_surname);
            this.gpbox_personal_info.Controls.Add(this.txt_phone_no);
            this.gpbox_personal_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gpbox_personal_info.Location = new System.Drawing.Point(33, 44);
            this.gpbox_personal_info.Name = "gpbox_personal_info";
            this.gpbox_personal_info.Size = new System.Drawing.Size(414, 370);
            this.gpbox_personal_info.TabIndex = 18;
            this.gpbox_personal_info.TabStop = false;
            this.gpbox_personal_info.Text = "Kişisel Bilgiler";
            // 
            // txt_email
            // 
            this.txt_email.Enabled = false;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_email.Location = new System.Drawing.Point(204, 151);
            this.txt_email.MaxLength = 35;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 22);
            this.txt_email.TabIndex = 9;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_name.Location = new System.Drawing.Point(72, 36);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(25, 16);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Ad";
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_surname.Location = new System.Drawing.Point(72, 73);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(48, 16);
            this.lbl_surname.TabIndex = 1;
            this.lbl_surname.Text = "Soyad";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_email.Location = new System.Drawing.Point(72, 154);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(46, 16);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "E-mail";
            // 
            // lbl_new_password
            // 
            this.lbl_new_password.AutoSize = true;
            this.lbl_new_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_new_password.Location = new System.Drawing.Point(72, 236);
            this.lbl_new_password.Name = "lbl_new_password";
            this.lbl_new_password.Size = new System.Drawing.Size(110, 16);
            this.lbl_new_password.TabIndex = 3;
            this.lbl_new_password.Text = "Yeni şifrenizi girin";
            // 
            // lbl_repeat_new_password
            // 
            this.lbl_repeat_new_password.AutoSize = true;
            this.lbl_repeat_new_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_repeat_new_password.Location = new System.Drawing.Point(72, 268);
            this.lbl_repeat_new_password.Name = "lbl_repeat_new_password";
            this.lbl_repeat_new_password.Size = new System.Drawing.Size(86, 16);
            this.lbl_repeat_new_password.TabIndex = 4;
            this.lbl_repeat_new_password.Text = "Bir daha girin";
            // 
            // btn_update_perinfo
            // 
            this.btn_update_perinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btn_update_perinfo.FlatAppearance.BorderSize = 0;
            this.btn_update_perinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_perinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_update_perinfo.ForeColor = System.Drawing.Color.White;
            this.btn_update_perinfo.Location = new System.Drawing.Point(39, 312);
            this.btn_update_perinfo.Name = "btn_update_perinfo";
            this.btn_update_perinfo.Size = new System.Drawing.Size(321, 26);
            this.btn_update_perinfo.TabIndex = 12;
            this.btn_update_perinfo.Text = "Düzenle";
            this.btn_update_perinfo.UseVisualStyleBackColor = false;
            this.btn_update_perinfo.Click += new System.EventHandler(this.btn_update_perinfo_Click);
            // 
            // lbl_phone_no
            // 
            this.lbl_phone_no.AutoSize = true;
            this.lbl_phone_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_phone_no.Location = new System.Drawing.Point(72, 113);
            this.lbl_phone_no.Name = "lbl_phone_no";
            this.lbl_phone_no.Size = new System.Drawing.Size(112, 16);
            this.lbl_phone_no.TabIndex = 5;
            this.lbl_phone_no.Text = "Telefon numarası";
            // 
            // txt_repeat_new_password
            // 
            this.txt_repeat_new_password.Enabled = false;
            this.txt_repeat_new_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_repeat_new_password.Location = new System.Drawing.Point(204, 268);
            this.txt_repeat_new_password.MaxLength = 4;
            this.txt_repeat_new_password.Name = "txt_repeat_new_password";
            this.txt_repeat_new_password.Size = new System.Drawing.Size(100, 22);
            this.txt_repeat_new_password.TabIndex = 11;
            this.txt_repeat_new_password.UseSystemPasswordChar = true;
            // 
            // txt_name
            // 
            this.txt_name.Enabled = false;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_name.Location = new System.Drawing.Point(204, 36);
            this.txt_name.MaxLength = 20;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 22);
            this.txt_name.TabIndex = 6;
            // 
            // txt_new_password
            // 
            this.txt_new_password.Enabled = false;
            this.txt_new_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_new_password.Location = new System.Drawing.Point(204, 229);
            this.txt_new_password.MaxLength = 4;
            this.txt_new_password.Name = "txt_new_password";
            this.txt_new_password.Size = new System.Drawing.Size(100, 22);
            this.txt_new_password.TabIndex = 10;
            this.txt_new_password.UseSystemPasswordChar = true;
            // 
            // txt_surname
            // 
            this.txt_surname.Enabled = false;
            this.txt_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_surname.Location = new System.Drawing.Point(204, 73);
            this.txt_surname.MaxLength = 25;
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(100, 22);
            this.txt_surname.TabIndex = 7;
            // 
            // txt_phone_no
            // 
            this.txt_phone_no.Enabled = false;
            this.txt_phone_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_phone_no.Location = new System.Drawing.Point(204, 113);
            this.txt_phone_no.Mask = "(000) 00-00-0000";
            this.txt_phone_no.Name = "txt_phone_no";
            this.txt_phone_no.Size = new System.Drawing.Size(100, 22);
            this.txt_phone_no.TabIndex = 8;
            // 
            // tbpage_bills
            // 
            this.tbpage_bills.BackColor = System.Drawing.Color.Linen;
            this.tbpage_bills.Controls.Add(this.chckbox_completed);
            this.tbpage_bills.Controls.Add(this.btn_order_remove);
            this.tbpage_bills.Controls.Add(this.gpbox_bill_info);
            this.tbpage_bills.Controls.Add(this.dtgd_order_details);
            this.tbpage_bills.Controls.Add(this.lbl_order_detail_title);
            this.tbpage_bills.Controls.Add(this.lbl_order_table_title);
            this.tbpage_bills.Controls.Add(this.dtgd_order_info_table);
            this.tbpage_bills.Location = new System.Drawing.Point(4, 22);
            this.tbpage_bills.Name = "tbpage_bills";
            this.tbpage_bills.Size = new System.Drawing.Size(965, 438);
            this.tbpage_bills.TabIndex = 2;
            this.tbpage_bills.Text = "FATURALARIM";
            this.tbpage_bills.Enter += new System.EventHandler(this.tbpage_bills_Enter);
            // 
            // btn_order_remove
            // 
            this.btn_order_remove.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_order_remove.FlatAppearance.BorderSize = 0;
            this.btn_order_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_order_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_order_remove.ForeColor = System.Drawing.Color.White;
            this.btn_order_remove.Location = new System.Drawing.Point(17, 192);
            this.btn_order_remove.Name = "btn_order_remove";
            this.btn_order_remove.Size = new System.Drawing.Size(151, 28);
            this.btn_order_remove.TabIndex = 8;
            this.btn_order_remove.Text = "Sipariş Kaldır";
            this.btn_order_remove.UseVisualStyleBackColor = false;
            this.btn_order_remove.Click += new System.EventHandler(this.btn_order_remove_Click);
            // 
            // gpbox_bill_info
            // 
            this.gpbox_bill_info.Controls.Add(this.label4);
            this.gpbox_bill_info.Controls.Add(this.label5);
            this.gpbox_bill_info.Controls.Add(this.label1);
            this.gpbox_bill_info.Controls.Add(this.label2);
            this.gpbox_bill_info.Controls.Add(this.label3);
            this.gpbox_bill_info.Controls.Add(this.lbl_bill_date);
            this.gpbox_bill_info.Controls.Add(this.lbl_total_price);
            this.gpbox_bill_info.Controls.Add(this.lbl_sales_rep);
            this.gpbox_bill_info.Controls.Add(this.lbl_branch_title);
            this.gpbox_bill_info.Controls.Add(this.lbl_bill_no);
            this.gpbox_bill_info.Controls.Add(this.btn_save_as_pdf);
            this.gpbox_bill_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gpbox_bill_info.ForeColor = System.Drawing.Color.Black;
            this.gpbox_bill_info.Location = new System.Drawing.Point(17, 239);
            this.gpbox_bill_info.Name = "gpbox_bill_info";
            this.gpbox_bill_info.Size = new System.Drawing.Size(928, 185);
            this.gpbox_bill_info.TabIndex = 7;
            this.gpbox_bill_info.TabStop = false;
            this.gpbox_bill_info.Text = "Fatura Bilgilerim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(466, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Toplam Tutar : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(466, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Satış Temsilcisi : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kesilme Tarihi : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Şube İsmi : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(27, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fatura Numarası : ";
            // 
            // lbl_bill_date
            // 
            this.lbl_bill_date.AutoSize = true;
            this.lbl_bill_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bill_date.Location = new System.Drawing.Point(163, 129);
            this.lbl_bill_date.Name = "lbl_bill_date";
            this.lbl_bill_date.Size = new System.Drawing.Size(13, 18);
            this.lbl_bill_date.TabIndex = 7;
            this.lbl_bill_date.Text = "-";
            // 
            // lbl_total_price
            // 
            this.lbl_total_price.AutoSize = true;
            this.lbl_total_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_total_price.Location = new System.Drawing.Point(595, 86);
            this.lbl_total_price.Name = "lbl_total_price";
            this.lbl_total_price.Size = new System.Drawing.Size(13, 18);
            this.lbl_total_price.TabIndex = 6;
            this.lbl_total_price.Text = "-";
            // 
            // lbl_sales_rep
            // 
            this.lbl_sales_rep.AutoSize = true;
            this.lbl_sales_rep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sales_rep.Location = new System.Drawing.Point(595, 46);
            this.lbl_sales_rep.Name = "lbl_sales_rep";
            this.lbl_sales_rep.Size = new System.Drawing.Size(13, 18);
            this.lbl_sales_rep.TabIndex = 5;
            this.lbl_sales_rep.Text = "-";
            // 
            // lbl_branch_title
            // 
            this.lbl_branch_title.AutoSize = true;
            this.lbl_branch_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_branch_title.Location = new System.Drawing.Point(163, 86);
            this.lbl_branch_title.Name = "lbl_branch_title";
            this.lbl_branch_title.Size = new System.Drawing.Size(13, 18);
            this.lbl_branch_title.TabIndex = 4;
            this.lbl_branch_title.Text = "-";
            // 
            // lbl_bill_no
            // 
            this.lbl_bill_no.AutoSize = true;
            this.lbl_bill_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bill_no.Location = new System.Drawing.Point(163, 46);
            this.lbl_bill_no.Name = "lbl_bill_no";
            this.lbl_bill_no.Size = new System.Drawing.Size(13, 18);
            this.lbl_bill_no.TabIndex = 3;
            this.lbl_bill_no.Text = "-";
            // 
            // btn_save_as_pdf
            // 
            this.btn_save_as_pdf.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_save_as_pdf.FlatAppearance.BorderSize = 0;
            this.btn_save_as_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_as_pdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_save_as_pdf.ForeColor = System.Drawing.Color.White;
            this.btn_save_as_pdf.Location = new System.Drawing.Point(771, 151);
            this.btn_save_as_pdf.Name = "btn_save_as_pdf";
            this.btn_save_as_pdf.Size = new System.Drawing.Size(151, 28);
            this.btn_save_as_pdf.TabIndex = 2;
            this.btn_save_as_pdf.Text = "PDF Kaydet";
            this.btn_save_as_pdf.UseVisualStyleBackColor = false;
            this.btn_save_as_pdf.Click += new System.EventHandler(this.btn_save_as_pdf_Click);
            // 
            // dtgd_order_details
            // 
            this.dtgd_order_details.AllowUserToAddRows = false;
            this.dtgd_order_details.AllowUserToDeleteRows = false;
            this.dtgd_order_details.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgd_order_details.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgd_order_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgd_order_details.Location = new System.Drawing.Point(486, 41);
            this.dtgd_order_details.MultiSelect = false;
            this.dtgd_order_details.Name = "dtgd_order_details";
            this.dtgd_order_details.ReadOnly = true;
            this.dtgd_order_details.RowHeadersVisible = false;
            this.dtgd_order_details.Size = new System.Drawing.Size(453, 145);
            this.dtgd_order_details.TabIndex = 6;
            // 
            // lbl_order_detail_title
            // 
            this.lbl_order_detail_title.AutoSize = true;
            this.lbl_order_detail_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_order_detail_title.Location = new System.Drawing.Point(483, 22);
            this.lbl_order_detail_title.Name = "lbl_order_detail_title";
            this.lbl_order_detail_title.Size = new System.Drawing.Size(124, 16);
            this.lbl_order_detail_title.TabIndex = 5;
            this.lbl_order_detail_title.Text = "Sipariş Detayları";
            // 
            // lbl_order_table_title
            // 
            this.lbl_order_table_title.AutoSize = true;
            this.lbl_order_table_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_order_table_title.Location = new System.Drawing.Point(14, 22);
            this.lbl_order_table_title.Name = "lbl_order_table_title";
            this.lbl_order_table_title.Size = new System.Drawing.Size(126, 16);
            this.lbl_order_table_title.TabIndex = 1;
            this.lbl_order_table_title.Text = "Sipariş Bilgilerim";
            // 
            // dtgd_order_info_table
            // 
            this.dtgd_order_info_table.AllowUserToAddRows = false;
            this.dtgd_order_info_table.AllowUserToDeleteRows = false;
            this.dtgd_order_info_table.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgd_order_info_table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgd_order_info_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgd_order_info_table.Location = new System.Drawing.Point(17, 41);
            this.dtgd_order_info_table.MultiSelect = false;
            this.dtgd_order_info_table.Name = "dtgd_order_info_table";
            this.dtgd_order_info_table.ReadOnly = true;
            this.dtgd_order_info_table.RowHeadersVisible = false;
            this.dtgd_order_info_table.Size = new System.Drawing.Size(399, 145);
            this.dtgd_order_info_table.TabIndex = 0;
            this.dtgd_order_info_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgd_order_info_table_CellClick);
            // 
            // lbl_customer_info
            // 
            this.lbl_customer_info.AutoSize = true;
            this.lbl_customer_info.Location = new System.Drawing.Point(643, 14);
            this.lbl_customer_info.Name = "lbl_customer_info";
            this.lbl_customer_info.Size = new System.Drawing.Size(93, 13);
            this.lbl_customer_info.TabIndex = 1;
            this.lbl_customer_info.Text = "Hoşgeldiniz, Sayın";
            // 
            // chckbox_completed
            // 
            this.chckbox_completed.AutoSize = true;
            this.chckbox_completed.Location = new System.Drawing.Point(239, 199);
            this.chckbox_completed.Name = "chckbox_completed";
            this.chckbox_completed.Size = new System.Drawing.Size(177, 17);
            this.chckbox_completed.TabIndex = 9;
            this.chckbox_completed.Text = "Tamamlanmış siparişlerimi göster";
            this.chckbox_completed.UseVisualStyleBackColor = true;
            this.chckbox_completed.CheckedChanged += new System.EventHandler(this.chckbox_completed_CheckedChanged);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(997, 488);
            this.Controls.Add(this.lbl_customer_info);
            this.Controls.Add(this.tabctrl_customer_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerForm_FormClosing);
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.tabctrl_customer_panel.ResumeLayout(false);
            this.tblpage_order.ResumeLayout(false);
            this.tblpage_order.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgd_shopping_cart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgd_product_table)).EndInit();
            this.tbpage_personal_info.ResumeLayout(false);
            this.gpbox_adress_info.ResumeLayout(false);
            this.gpbox_adress_info.PerformLayout();
            this.gpbox_personal_info.ResumeLayout(false);
            this.gpbox_personal_info.PerformLayout();
            this.tbpage_bills.ResumeLayout(false);
            this.tbpage_bills.PerformLayout();
            this.gpbox_bill_info.ResumeLayout(false);
            this.gpbox_bill_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgd_order_details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgd_order_info_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabctrl_customer_panel;
        private System.Windows.Forms.TabPage tblpage_order;
        private System.Windows.Forms.TabPage tbpage_personal_info;
        private System.Windows.Forms.TabPage tbpage_bills;
        public System.Windows.Forms.Label lbl_customer_info;
        private System.Windows.Forms.Label lbl_branch_name;
        private System.Windows.Forms.ComboBox cmbox_branch_selection;
        private System.Windows.Forms.Label lbl_product_title;
        private System.Windows.Forms.DataGridView dtgd_product_table;
        private System.Windows.Forms.Label lbl_shopping_cart_title;
        private System.Windows.Forms.DataGridView dtgd_shopping_cart;
        private System.Windows.Forms.Button btn_increase_item;
        private System.Windows.Forms.ComboBox cmbox_staff_selection;
        private System.Windows.Forms.Label lbl_staff_names;
        private System.Windows.Forms.Button btn_decrease_item;
        private System.Windows.Forms.Button btn_cart_confirm;
        private System.Windows.Forms.Button btn_clear_cart;
        private System.Windows.Forms.ComboBox cmbox_payment_selection;
        private System.Windows.Forms.Label lbl_payment_title;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_repeat_new_password;
        private System.Windows.Forms.Label lbl_new_password;
        private System.Windows.Forms.Label lbl_phone_no;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.MaskedTextBox txt_phone_no;
        private System.Windows.Forms.TextBox txt_repeat_new_password;
        private System.Windows.Forms.TextBox txt_new_password;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_update_perinfo;
        private System.Windows.Forms.Label lbl_street_name;
        private System.Windows.Forms.Label lbl_aparment_no;
        private System.Windows.Forms.Label lbl_building_no;
        private System.Windows.Forms.Label lbl_avenue;
        private System.Windows.Forms.Label lbl_district;
        private System.Windows.Forms.GroupBox gpbox_personal_info;
        private System.Windows.Forms.GroupBox gpbox_adress_info;
        private System.Windows.Forms.Label lbl_province;
        private System.Windows.Forms.Label lbl_town;
        private System.Windows.Forms.TextBox txt_district;
        private System.Windows.Forms.TextBox txt_street;
        private System.Windows.Forms.TextBox txt_avenue;
        private System.Windows.Forms.MaskedTextBox txt_building_no;
        private System.Windows.Forms.MaskedTextBox txt_apartment_no;
        private System.Windows.Forms.TextBox txt_town;
        private System.Windows.Forms.ComboBox cmbox_province;
        private System.Windows.Forms.Button btn_update_adrinfo;
        private System.Windows.Forms.DataGridView dtgd_order_info_table;
        private System.Windows.Forms.Label lbl_order_table_title;
        private System.Windows.Forms.Button btn_add_to_card;
        private System.Windows.Forms.Button btn_save_as_pdf;
        private System.Windows.Forms.Label lbl_order_detail_title;
        private System.Windows.Forms.DataGridView dtgd_order_details;
        private System.Windows.Forms.GroupBox gpbox_bill_info;
        private System.Windows.Forms.Label lbl_branch_title;
        private System.Windows.Forms.Label lbl_bill_no;
        private System.Windows.Forms.Label lbl_sales_rep;
        private System.Windows.Forms.Label lbl_total_price;
        private System.Windows.Forms.Label lbl_bill_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_order_remove;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_product_search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbox_category;
        private System.Windows.Forms.CheckBox chckbox_completed;
    }
}