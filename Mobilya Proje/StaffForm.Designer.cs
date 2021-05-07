namespace Mobilya_Proje
{
    partial class StaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            this.label_user = new System.Windows.Forms.Label();
            this.tabPageProduct = new System.Windows.Forms.TabPage();
            this.dtgd_product_table = new System.Windows.Forms.DataGridView();
            this.cmbx_category = new System.Windows.Forms.ComboBox();
            this.btn_update_item = new System.Windows.Forms.Button();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.txt_product_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_customer_order = new System.Windows.Forms.TabPage();
            this.picture_order_info_upgrade = new System.Windows.Forms.PictureBox();
            this.dateTime_delivery = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_cost = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_cost_sum = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_confirm_order = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgd_order_detail_table = new System.Windows.Forms.DataGridView();
            this.dtgd_order_table = new System.Windows.Forms.DataGridView();
            this.tabPage_questioning = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgd_confirm_order = new System.Windows.Forms.DataGridView();
            this.btn_confirmed_orders = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_product_code = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtgd_stock_table = new System.Windows.Forms.DataGridView();
            this.btn_search_stock = new System.Windows.Forms.Button();
            this.tabPageProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgd_product_table)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage_customer_order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_order_info_upgrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgd_order_detail_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgd_order_table)).BeginInit();
            this.tabPage_questioning.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgd_confirm_order)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgd_stock_table)).BeginInit();
            this.SuspendLayout();
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Location = new System.Drawing.Point(781, 9);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(36, 13);
            this.label_user.TabIndex = 0;
            this.label_user.Text = "Sayın ";
            // 
            // tabPageProduct
            // 
            this.tabPageProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPageProduct.Controls.Add(this.dtgd_product_table);
            this.tabPageProduct.Controls.Add(this.cmbx_category);
            this.tabPageProduct.Controls.Add(this.btn_update_item);
            this.tabPageProduct.Controls.Add(this.txt_price);
            this.tabPageProduct.Controls.Add(this.txt_description);
            this.tabPageProduct.Controls.Add(this.txt_product_name);
            this.tabPageProduct.Controls.Add(this.label4);
            this.tabPageProduct.Controls.Add(this.label3);
            this.tabPageProduct.Controls.Add(this.label2);
            this.tabPageProduct.Controls.Add(this.label1);
            this.tabPageProduct.Location = new System.Drawing.Point(4, 22);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProduct.Size = new System.Drawing.Size(1000, 400);
            this.tabPageProduct.TabIndex = 0;
            this.tabPageProduct.Text = "ÜRÜN - DÜZENLE";
            this.tabPageProduct.Enter += new System.EventHandler(this.tabPageProduct_Enter);
            // 
            // dtgd_product_table
            // 
            this.dtgd_product_table.AllowUserToAddRows = false;
            this.dtgd_product_table.AllowUserToDeleteRows = false;
            this.dtgd_product_table.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgd_product_table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgd_product_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgd_product_table.Location = new System.Drawing.Point(439, 21);
            this.dtgd_product_table.MultiSelect = false;
            this.dtgd_product_table.Name = "dtgd_product_table";
            this.dtgd_product_table.ReadOnly = true;
            this.dtgd_product_table.RowHeadersVisible = false;
            this.dtgd_product_table.Size = new System.Drawing.Size(520, 350);
            this.dtgd_product_table.TabIndex = 11;
            this.dtgd_product_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgd_product_table_CellClick);
            // 
            // cmbx_category
            // 
            this.cmbx_category.FormattingEnabled = true;
            this.cmbx_category.Location = new System.Drawing.Point(115, 128);
            this.cmbx_category.Name = "cmbx_category";
            this.cmbx_category.Size = new System.Drawing.Size(121, 21);
            this.cmbx_category.TabIndex = 10;
            // 
            // btn_update_item
            // 
            this.btn_update_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btn_update_item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_update_item.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_update_item.FlatAppearance.BorderSize = 0;
            this.btn_update_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_update_item.ForeColor = System.Drawing.Color.White;
            this.btn_update_item.Location = new System.Drawing.Point(41, 326);
            this.btn_update_item.Name = "btn_update_item";
            this.btn_update_item.Size = new System.Drawing.Size(195, 23);
            this.btn_update_item.TabIndex = 9;
            this.btn_update_item.Text = "Güncelle";
            this.btn_update_item.UseVisualStyleBackColor = false;
            this.btn_update_item.Click += new System.EventHandler(this.btn_update_item_Click);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(115, 175);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(121, 20);
            this.txt_price.TabIndex = 7;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(115, 214);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(237, 81);
            this.txt_description.TabIndex = 5;
            // 
            // txt_product_name
            // 
            this.txt_product_name.Location = new System.Drawing.Point(115, 89);
            this.txt_product_name.Name = "txt_product_name";
            this.txt_product_name.Size = new System.Drawing.Size(121, 20);
            this.txt_product_name.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(38, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fiyat :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(38, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Açıklama :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(38, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategori :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı :";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_customer_order);
            this.tabControl1.Controls.Add(this.tabPageProduct);
            this.tabControl1.Controls.Add(this.tabPage_questioning);
            this.tabControl1.Location = new System.Drawing.Point(12, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1008, 426);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_customer_order
            // 
            this.tabPage_customer_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage_customer_order.Controls.Add(this.picture_order_info_upgrade);
            this.tabPage_customer_order.Controls.Add(this.dateTime_delivery);
            this.tabPage_customer_order.Controls.Add(this.label12);
            this.tabPage_customer_order.Controls.Add(this.label11);
            this.tabPage_customer_order.Controls.Add(this.label10);
            this.tabPage_customer_order.Controls.Add(this.lbl_cost);
            this.tabPage_customer_order.Controls.Add(this.label9);
            this.tabPage_customer_order.Controls.Add(this.lbl_cost_sum);
            this.tabPage_customer_order.Controls.Add(this.label8);
            this.tabPage_customer_order.Controls.Add(this.label7);
            this.tabPage_customer_order.Controls.Add(this.btn_confirm_order);
            this.tabPage_customer_order.Controls.Add(this.label6);
            this.tabPage_customer_order.Controls.Add(this.label5);
            this.tabPage_customer_order.Controls.Add(this.dtgd_order_detail_table);
            this.tabPage_customer_order.Controls.Add(this.dtgd_order_table);
            this.tabPage_customer_order.Location = new System.Drawing.Point(4, 22);
            this.tabPage_customer_order.Name = "tabPage_customer_order";
            this.tabPage_customer_order.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_customer_order.Size = new System.Drawing.Size(1000, 400);
            this.tabPage_customer_order.TabIndex = 1;
            this.tabPage_customer_order.Text = "MÜŞTERİ SİPARİŞ";
            this.tabPage_customer_order.Enter += new System.EventHandler(this.tabPage_customer_order_Enter);
            // 
            // picture_order_info_upgrade
            // 
            this.picture_order_info_upgrade.Image = global::Mobilya_Proje.Properties.Resources.icons8_upgrade;
            this.picture_order_info_upgrade.Location = new System.Drawing.Point(469, 289);
            this.picture_order_info_upgrade.Name = "picture_order_info_upgrade";
            this.picture_order_info_upgrade.Size = new System.Drawing.Size(60, 36);
            this.picture_order_info_upgrade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_order_info_upgrade.TabIndex = 15;
            this.picture_order_info_upgrade.TabStop = false;
            this.picture_order_info_upgrade.Click += new System.EventHandler(this.picture_order_info_upgrade_Click);
            // 
            // dateTime_delivery
            // 
            this.dateTime_delivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTime_delivery.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_delivery.Location = new System.Drawing.Point(124, 303);
            this.dateTime_delivery.Name = "dateTime_delivery";
            this.dateTime_delivery.Size = new System.Drawing.Size(178, 22);
            this.dateTime_delivery.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(15, 305);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Teslimat Tarihi :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(564, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Sipariş Detay";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(16, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Sipariş Bilgisi";
            // 
            // lbl_cost
            // 
            this.lbl_cost.AutoSize = true;
            this.lbl_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cost.Location = new System.Drawing.Point(918, 325);
            this.lbl_cost.Name = "lbl_cost";
            this.lbl_cost.Size = new System.Drawing.Size(58, 16);
            this.lbl_cost.TabIndex = 10;
            this.lbl_cost.Text = "00.00 TL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(774, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Sipariş Toplam Fiyat :";
            // 
            // lbl_cost_sum
            // 
            this.lbl_cost_sum.AutoSize = true;
            this.lbl_cost_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cost_sum.Location = new System.Drawing.Point(867, 315);
            this.lbl_cost_sum.Name = "lbl_cost_sum";
            this.lbl_cost_sum.Size = new System.Drawing.Size(0, 16);
            this.lbl_cost_sum.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(768, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(9, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 5;
            // 
            // btn_confirm_order
            // 
            this.btn_confirm_order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btn_confirm_order.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_confirm_order.FlatAppearance.BorderSize = 0;
            this.btn_confirm_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirm_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_confirm_order.ForeColor = System.Drawing.Color.White;
            this.btn_confirm_order.Location = new System.Drawing.Point(19, 352);
            this.btn_confirm_order.Name = "btn_confirm_order";
            this.btn_confirm_order.Size = new System.Drawing.Size(283, 26);
            this.btn_confirm_order.TabIndex = 4;
            this.btn_confirm_order.Text = "Sipariş Onayla";
            this.btn_confirm_order.UseVisualStyleBackColor = false;
            this.btn_confirm_order.Click += new System.EventHandler(this.btn_confirm_order_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(558, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(10, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 2;
            // 
            // dtgd_order_detail_table
            // 
            this.dtgd_order_detail_table.AllowUserToAddRows = false;
            this.dtgd_order_detail_table.AllowUserToDeleteRows = false;
            this.dtgd_order_detail_table.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgd_order_detail_table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgd_order_detail_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgd_order_detail_table.Location = new System.Drawing.Point(564, 32);
            this.dtgd_order_detail_table.MultiSelect = false;
            this.dtgd_order_detail_table.Name = "dtgd_order_detail_table";
            this.dtgd_order_detail_table.ReadOnly = true;
            this.dtgd_order_detail_table.RowHeadersVisible = false;
            this.dtgd_order_detail_table.Size = new System.Drawing.Size(402, 247);
            this.dtgd_order_detail_table.TabIndex = 1;
            // 
            // dtgd_order_table
            // 
            this.dtgd_order_table.AllowUserToAddRows = false;
            this.dtgd_order_table.AllowUserToDeleteRows = false;
            this.dtgd_order_table.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgd_order_table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgd_order_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgd_order_table.Location = new System.Drawing.Point(16, 32);
            this.dtgd_order_table.MultiSelect = false;
            this.dtgd_order_table.Name = "dtgd_order_table";
            this.dtgd_order_table.ReadOnly = true;
            this.dtgd_order_table.RowHeadersVisible = false;
            this.dtgd_order_table.Size = new System.Drawing.Size(503, 247);
            this.dtgd_order_table.TabIndex = 0;
            this.dtgd_order_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgd_order_table_CellClick);
            // 
            // tabPage_questioning
            // 
            this.tabPage_questioning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage_questioning.Controls.Add(this.groupBox2);
            this.tabPage_questioning.Controls.Add(this.groupBox1);
            this.tabPage_questioning.Location = new System.Drawing.Point(4, 22);
            this.tabPage_questioning.Name = "tabPage_questioning";
            this.tabPage_questioning.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_questioning.Size = new System.Drawing.Size(1000, 400);
            this.tabPage_questioning.TabIndex = 2;
            this.tabPage_questioning.Text = "SORGULAMA";
            this.tabPage_questioning.Enter += new System.EventHandler(this.tabPage_questioning_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgd_confirm_order);
            this.groupBox2.Controls.Add(this.btn_confirmed_orders);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(427, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(562, 346);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sipariş";
            // 
            // dtgd_confirm_order
            // 
            this.dtgd_confirm_order.AllowUserToAddRows = false;
            this.dtgd_confirm_order.AllowUserToDeleteRows = false;
            this.dtgd_confirm_order.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgd_confirm_order.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgd_confirm_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgd_confirm_order.Location = new System.Drawing.Point(37, 38);
            this.dtgd_confirm_order.MultiSelect = false;
            this.dtgd_confirm_order.Name = "dtgd_confirm_order";
            this.dtgd_confirm_order.ReadOnly = true;
            this.dtgd_confirm_order.RowHeadersVisible = false;
            this.dtgd_confirm_order.Size = new System.Drawing.Size(501, 181);
            this.dtgd_confirm_order.TabIndex = 9;
            // 
            // btn_confirmed_orders
            // 
            this.btn_confirmed_orders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btn_confirmed_orders.FlatAppearance.BorderSize = 0;
            this.btn_confirmed_orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmed_orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_confirmed_orders.ForeColor = System.Drawing.Color.White;
            this.btn_confirmed_orders.Location = new System.Drawing.Point(209, 300);
            this.btn_confirmed_orders.Name = "btn_confirmed_orders";
            this.btn_confirmed_orders.Size = new System.Drawing.Size(184, 28);
            this.btn_confirmed_orders.TabIndex = 6;
            this.btn_confirmed_orders.Text = "Onaylanan Siparişler";
            this.btn_confirmed_orders.UseVisualStyleBackColor = false;
            this.btn_confirmed_orders.Click += new System.EventHandler(this.btn_confirmed_orders_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_product_code);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.dtgd_stock_table);
            this.groupBox1.Controls.Add(this.btn_search_stock);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(11, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 346);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stok Sorgula";
            // 
            // txt_product_code
            // 
            this.txt_product_code.Location = new System.Drawing.Point(155, 254);
            this.txt_product_code.Name = "txt_product_code";
            this.txt_product_code.Size = new System.Drawing.Size(100, 22);
            this.txt_product_code.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(73, 255);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Ürün Kodu :";
            // 
            // dtgd_stock_table
            // 
            this.dtgd_stock_table.AllowUserToAddRows = false;
            this.dtgd_stock_table.AllowUserToDeleteRows = false;
            this.dtgd_stock_table.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgd_stock_table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgd_stock_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgd_stock_table.Location = new System.Drawing.Point(39, 38);
            this.dtgd_stock_table.MultiSelect = false;
            this.dtgd_stock_table.Name = "dtgd_stock_table";
            this.dtgd_stock_table.ReadOnly = true;
            this.dtgd_stock_table.RowHeadersVisible = false;
            this.dtgd_stock_table.Size = new System.Drawing.Size(303, 181);
            this.dtgd_stock_table.TabIndex = 0;
            // 
            // btn_search_stock
            // 
            this.btn_search_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(190)))), ((int)(((byte)(100)))));
            this.btn_search_stock.FlatAppearance.BorderSize = 0;
            this.btn_search_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_search_stock.ForeColor = System.Drawing.Color.White;
            this.btn_search_stock.Location = new System.Drawing.Point(76, 300);
            this.btn_search_stock.Name = "btn_search_stock";
            this.btn_search_stock.Size = new System.Drawing.Size(204, 28);
            this.btn_search_stock.TabIndex = 3;
            this.btn_search_stock.Text = "Stok Ara";
            this.btn_search_stock.UseVisualStyleBackColor = false;
            this.btn_search_stock.Click += new System.EventHandler(this.btn_search_stock_Click);
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 459);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StaffForm_FormClosing);
            this.Load += new System.EventHandler(this.StaffForm_Load);
            this.tabPageProduct.ResumeLayout(false);
            this.tabPageProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgd_product_table)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_customer_order.ResumeLayout(false);
            this.tabPage_customer_order.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_order_info_upgrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgd_order_detail_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgd_order_table)).EndInit();
            this.tabPage_questioning.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgd_confirm_order)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgd_stock_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label_user;
        private System.Windows.Forms.TabPage tabPageProduct;
        private System.Windows.Forms.Button btn_update_item;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.TextBox txt_product_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_customer_order;
        private System.Windows.Forms.Label lbl_cost_sum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_confirm_order;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgd_order_detail_table;
        private System.Windows.Forms.DataGridView dtgd_order_table;
        private System.Windows.Forms.Label lbl_cost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbx_category;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage_questioning;
        private System.Windows.Forms.DataGridView dtgd_stock_table;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_product_code;
        private System.Windows.Forms.Button btn_confirmed_orders;
        private System.Windows.Forms.Button btn_search_stock;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTime_delivery;
        private System.Windows.Forms.DataGridView dtgd_product_table;
        private System.Windows.Forms.DataGridView dtgd_confirm_order;
        private System.Windows.Forms.PictureBox picture_order_info_upgrade;
    }
}