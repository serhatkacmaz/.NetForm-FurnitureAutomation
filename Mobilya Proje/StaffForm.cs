using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Mobilya_Proje
{
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }

        DatabaseConnection connection = new DatabaseConnection();

        public string staff_number;  //sicil no (loginden cekiyoruz)
        public string branch_number;    //sube no (loginden cekiyoruz)
        int order_number;   //sipariş no
        int product_code;  //ürün kodu
        DateTime date = DateTime.Now; // tarih bilgileri 
        string year, month, day, hour, second, minute;
        float cost;  //siparişdeki ürünlerin toplam maliyeti
        private bool close_state; //formu kapatma mesajını kontrol etme
        DialogResult result;

        //urun_kodu ve adet bilgisini tutar
        Dictionary<int, int> product_and_count = new Dictionary<int, int>();

        #region Bizim Kurduğumuz fonksiyonlar
        // DataGridView Temizleme
        private void ResetDataGridView(DataGridView grid)
        {
            //kaynak //kaynak https://docs.microsoft.com/tr-tr/dotnet/api/system.windows.forms.datagridviewcolumncollection.clear?view=net-5.0
            grid.CancelEdit();
            grid.Columns.Clear();
            grid.DataSource = null;
        }

        //sorgulama kısmında datagridviewleri temizler
        private void ResetDataGridView_QuestioningPage()
        {
            ResetDataGridView(dtgd_confirm_order);
            ResetDataGridView(dtgd_stock_table);
        }

        //urün sayfasındaki textboxları temizler
        private void Clear_TextBox_ProductPage()
        {
            txt_product_name.Clear();
            cmbx_category.Text = "";
            txt_description.Clear();
            txt_price.Clear();
        }

        //Güncel tarih zaman bilgisi
        private void Update_Date()
        {
            year = date.Year.ToString();
            month = date.Month.ToString();
            day = date.Day.ToString();
            hour = date.Hour.ToString();
            minute = date.Minute.ToString();
            second = date.Second.ToString();
        }
        #endregion

        #region Eventler(Olaylar) Fonksiyonlar
        //Form yüklenince
        private void StaffForm_Load(object sender, EventArgs e)
        {
            Update_Date();

            //datetimepicker için minimum tarih ayarı
            dateTime_delivery.MinDate = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));

            //ürün bilgelerini çekme
            connection.filtering("select u1.urun_kod as 'Ürün No',k1.ad as 'Kategori Ad', u1.ad 'Ürün Ad',u1.aciklama as 'Açıklama' ,u1.fiyat as'Fiyat' " +
                "from urun u1 inner join kategori k1 on u1.kategori_kod=k1.kategori_kod order by u1.urun_kod; ", dtgd_product_table);

            //sipariş bilgilerini çeker
            connection.filtering("select spr.siparis_no as'Sipariş No', concat(mst.ad ,' ', mst.soyad) as'Müşteri',mst.telefon as 'Telefon',mst.tc_no 'TC No',spr.siparis_tarih'Sipariş Tarihi'" +
                " from siparis spr, musteri mst  where spr.sicil_no='" + staff_number + "' and spr.durum='A' and (spr.musteri_no=mst.musteri_no);", dtgd_order_table);

            // kategori combobox içine kategori adını ekleme veritabanı ile
            connection.OpenConnection();
            MySqlDataReader reader = connection.DataReader("select *from kategori");
            while (reader.Read())
            {
                cmbx_category.Items.Add(reader["ad"]);
            }
            connection.CloseConnection();
        }

        //Sipraiş Onaylama Butonu
        private void btn_confirm_order_Click(object sender, EventArgs e)
        {
            if (dtgd_order_detail_table.RowCount == 0)
                MessageBox.Show("Seçili sipariş yok!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Update_Date();

                //fatura için anlık tarih alma
                string bill_date = year + "-" + month + "-" + day + " " + hour + ":" + minute + ":" + second;

                //teslimat tarihi 
                string txt_delivery = dateTime_delivery.Value.Year + "-" + dateTime_delivery.Value.Month + "-" + dateTime_delivery.Value.Day;

                //durumu T yap ve teslimat tarihi ekle
                string query = "update siparis set durum='T',teslimat_tarih ='" + txt_delivery + "' where siparis_no='" + order_number + "'";
                connection.SqlProcess(query);
                query = "";

                //fatura kesme
                query = "insert into fatura (siparis_no,kesim_tarih,tutar) values('" + order_number + "','" + bill_date + "','" + cost.ToString().Replace(',', '.') + "')";
                connection.SqlProcess(query);

                //dtgd_order_table güncelle
                connection.filtering("select spr.siparis_no as'Sipariş No', concat(mst.ad ,' ', mst.soyad) as'Müşteri',mst.telefon as 'Telefon',mst.tc_no 'TC No',spr.siparis_tarih'Sipariş Tarihi'" +
                    " from siparis spr, musteri mst  where spr.sicil_no='" + staff_number + "' and spr.durum='A' and (spr.musteri_no=mst.musteri_no);", dtgd_order_table);

                //sipariş detay tablosunu temizle
                ResetDataGridView(dtgd_order_detail_table);

                //stok bilgisi güncelleme
                foreach (var item in product_and_count)
                {
                    connection.SqlProcess("update stok set adet=adet-'" + item.Value + "' where sube_no='" + branch_number + "' and urun_kod='" + item.Key + "'");
                }

                //txt temizleme
                lbl_cost.Text = "00.00 TL";
                MessageBox.Show("Sipariş onaylandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        // Ürün Güncelleme Buton
        private void btn_update_item_Click(object sender, EventArgs e)
        {
            if (txt_product_name.Text == "" || cmbx_category.Text == "" || txt_price.Text == "" || txt_description.Text == "")
                MessageBox.Show("Güncelleme Olamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                //ürün bilgilerini güncelle 
                connection.SqlProcess("update urun set kategori_kod=(select kategori_kod from kategori where ad='" + cmbx_category.Text + "'), ad='" + txt_product_name.Text + "'," +
                    "fiyat='" + txt_price.Text.Replace(',', '.') + "',aciklama='" + txt_description.Text + "' where urun_kod='" + product_code + "'");
                // ürün bilgilerini datagridview için yenile
                connection.filtering("select u1.urun_kod as 'Ürün Kod',k1.ad as 'Kategori', u1.ad 'Ürün Ad',u1.aciklama as 'Açıklama' ,u1.fiyat as'Fiyat' " +
                "from urun u1 inner join kategori k1 on u1.kategori_kod=k1.kategori_kod order by u1.urun_kod; ", dtgd_product_table);
            }
        }

        // sipariş bilgileri için olan dataGridView de bir hücreye tıklarsa
        private void dtgd_order_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgd_order_table.RowCount > 0)
            {
                product_and_count.Clear(); //Dictionary her seferinde sıfırlansın

                int selectedarea = dtgd_order_table.SelectedCells[0].RowIndex;  //seçili satır 
                order_number = int.Parse(dtgd_order_table.Rows[selectedarea].Cells[0].Value.ToString()); //sipariş_no

                //datagridView_order_detail için sipariş detaylarını filtreler
                connection.filtering("select sprdty.urun_kod as'Ürün Kodu', urn.ad as 'Ürün Adı', sprdty.adet as 'Adet', round(urn.fiyat*adet,2) as 'Toplam Fiyat'" +
                    "from siparis spr, siparisdetay sprdty,urun urn where spr.siparis_no='" + order_number + "' and" +
                    "(spr.siparis_no=sprdty.siparis_no and urn.urun_kod=sprdty.urun_kod);", dtgd_order_detail_table);

                //toplam fiyatı hesapla ve yaz
                int grid_row = dtgd_order_detail_table.RowCount; //sipariş detay tablosundaki satır sayısı
                cost = 0;
                for (int i = 0; i < grid_row; i++)
                {
                    cost += float.Parse(dtgd_order_detail_table.Rows[i].Cells[3].Value.ToString()); //maliyet
                    int key = int.Parse(dtgd_order_detail_table.Rows[i].Cells[0].Value.ToString());  //urun_kod
                    int value = int.Parse(dtgd_order_detail_table.Rows[i].Cells[2].Value.ToString());   //adet
                    product_and_count.Add(key, value);  // urun_kod ve adet olarak dictionary içinde eşleştir
                }
                lbl_cost.Text = cost.ToString() + " TL";
            }

        }

        //ürün koduna göre stok durumu arama
        private void btn_search_stock_Click(object sender, EventArgs e)
        {

            #region Serhat Kod

            if (txt_product_code.Text == "")
                MessageBox.Show("Ürün Kodu Yazılmadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                //stok bilgisi getir 
                connection.filtering("select u1.ad as ' Ürün Ad', s1.ad as 'Şube İsmi',st.adet as 'Stok' " +
                    "from sube s1,urun u1,stok st where u1.urun_kod='" + txt_product_code.Text + "' and " +
                    "(u1.urun_kod=st.urun_kod and st.sube_no=s1.sube_no) and st.adet<>0", dtgd_stock_table);

            }
            if (dtgd_stock_table.RowCount == 0 && txt_product_code.Text != "")
            {
                ResetDataGridView(dtgd_stock_table);
                MessageBox.Show("Böyle bir ürün kodu yoktur", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //temizle
            txt_product_code.Text = "";

            #endregion

            #region Barış Kod (Pasif)
            /*
            bool flag = false;
            if (txt_product_code.Text == "")
                MessageBox.Show("Ürün Kodu Yazılmadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {

                if (dtgd_stock_table.RowCount == 0 && flag)
                {
                    MessageBox.Show("Böyle bir ürün kodu sistemde yoktur ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ResetDataGridView(dtgd_stock_table);
                }
                else
                {
                    //stok bilgisi getir 
                    connection.filtering("select u1.ad as ' Ürün Ad', s1.ad as 'Şube İsmi',st.adet as 'Stok' " +
                        "from sube s1,urun u1,stok st where u1.urun_kod='" + txt_product_code.Text + "' and " +
                        "(u1.urun_kod=st.urun_kod and st.sube_no=s1.sube_no) and st.adet<>0", dtgd_stock_table);

                }

                //temizle
                txt_product_code.Text = "";
            }
            */
            #endregion

        }

        //personelin onayladığı siparişler
        private void btn_confirmed_orders_Click(object sender, EventArgs e)
        {
            //onaylanan sipariş bilgileri
            connection.filtering("select s1.siparis_no as 'Sipariş No',CONCAT(m.ad ,' ', m.soyad) as 'Müşteri Ad Soyad',s1.siparis_tarih as'Sipariş Tarih',f1.kesim_tarih as 'Onaylanma Tarih',s1.teslimat_tarih as 'Teslimat Tarih' " +
                "from siparis s1, fatura f1, musteri m where  s1.durum='T' and s1.sicil_no='" + staff_number + "' and f1.siparis_no=s1.siparis_no and s1.musteri_no=m.musteri_no  order by f1.kesim_tarih desc;", dtgd_confirm_order);

            if (dtgd_confirm_order.RowCount == 0)
            {
                MessageBox.Show("Onaylı siparişiniz bulunmamaktadır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //Müsteri siparişleri sayfasına giriş
        private void tabPage_customer_order_Enter(object sender, EventArgs e)
        {
            //sipariş bilgilerini çeker
            connection.filtering("select spr.siparis_no as'Sipariş No', concat(mst.ad ,' ', mst.soyad) as'Müşteri',mst.telefon as 'Telefon',mst.tc_no 'TC No',spr.siparis_tarih'Sipariş Tarihi'" +
                " from siparis spr, musteri mst  where spr.sicil_no='" + staff_number + "' and spr.durum='A' and (spr.musteri_no=mst.musteri_no);", dtgd_order_table);

            ResetDataGridView_QuestioningPage();
            Clear_TextBox_ProductPage();
        }

        //ürün düzenleme sayfasına giriş
        private void tabPageProduct_Enter(object sender, EventArgs e)
        {
            ResetDataGridView_QuestioningPage();
        }

        //sorgulama sayfasına giriş
        private void tabPage_questioning_Enter(object sender, EventArgs e)
        {
            Clear_TextBox_ProductPage();
        }

        //sipariş bilgilerini güncelle
        private void picture_order_info_upgrade_Click(object sender, EventArgs e)
        {
            //sipariş bilgilerini çeker
            connection.filtering("select spr.siparis_no as'Sipariş No', concat(mst.ad ,' ', mst.soyad) as'Müşteri',mst.telefon as 'Telefon',mst.tc_no 'TC No',spr.siparis_tarih'Sipariş Tarihi'" +
                " from siparis spr, musteri mst  where spr.sicil_no='" + staff_number + "' and spr.durum='A' and (spr.musteri_no=mst.musteri_no);", dtgd_order_table);
        }


        //ürünler için dataGridView de bir hücreye tıklarsa
        private void dtgd_product_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedarea_product = dtgd_product_table.SelectedCells[0].RowIndex;
            product_code = int.Parse(dtgd_product_table.Rows[selectedarea_product].Cells[0].Value.ToString()); //urun kod
            txt_product_name.Text = dtgd_product_table.Rows[selectedarea_product].Cells[2].Value.ToString();   //ad
            cmbx_category.Text = dtgd_product_table.Rows[selectedarea_product].Cells[1].Value.ToString();  //ktg ad
            txt_price.Text = dtgd_product_table.Rows[selectedarea_product].Cells[4].Value.ToString();  //fiyat
            txt_description.Text = dtgd_product_table.Rows[selectedarea_product].Cells[3].Value.ToString(); //açıklama
        }

        //Form kapatmaya kalkma
        private void StaffForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //https://sanalkurs.net/c-formu-kontrollu-kapatmak-iki-kere-sormasina-cozum-10562.html
            //mesaj onayında iki kere sormayı engelleme.
            if (!close_state)
            {
                result = MessageBox.Show("Çıkmak yapmak istiyor musun?", "Onaylama", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                close_state = result == DialogResult.Yes;
            }

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
                Application.Exit();
        }
        #endregion

    }
}
