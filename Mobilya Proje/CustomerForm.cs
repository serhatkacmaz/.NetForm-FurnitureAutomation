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
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp;
using iTextSharp.text;
using System.Globalization;
using System.Threading;

namespace Mobilya_Proje
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        DialogResult result;                                                        // MessageBox işlemleri için bir DialogResult nesnesi oluşturdum.
        DatabaseConnection connection = new DatabaseConnection();                   // Veritabanı işlemleri için
        Dictionary<int, string> staff_info = new Dictionary<int, string>();         // Personel bilgileri için
        Dictionary<int, int> order_detail_info = new Dictionary<int, int>();        // Sipariş detayları için

        //kaynak https://www.c-sharpcorner.com/blogs/convert-a-string-to-title-case-in-c-sharp1
        //string ifadede büyük harf yapma
        CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
        TextInfo textInfo;

        MySqlDataReader province_list;                                              // İl bilgilerini atmak için 

        // Değişkenler
        int staff_number;  //sicil_no   (Siparişte kullanıyoruz)
        public int customer_number; //musteri_no    (Login den çekiyoruz)
        int payment_number; //ödeme_kod (Siparişte kullanıyoruz)
        int branch_number; //sube_no    (Siparişte kullanıyoruz)
        int adress_no;    // adress no  (BİLGİLERİM de kullanıyoruz)
        int province_id;  // il_id      (BİLGİLERİM de kullanıyoruz)
        bool btn_update_perinfo_yes = false;        // Kişisel bilgilerin güncellenebilmesi için bir bool değişkeni
        bool btn_update_adrinfo_yes = false;        // Adres bilgilerin güncellenebilmesi için bir bool değişkeni
        bool close_state;                           // FormClosing event indeki durumu belirlemek için

        #region Bizim oluşturduğumuz fonksiyonlar
        // BİLGİLERİM sekmesindeki Kişisel bilgiler formunu devre dışı bırak
        private void ResetPersonalInfo()
        {
            btn_update_perinfo.Text = "Düzenle";
            btn_update_perinfo_yes = false;
            txt_name.Enabled = false;
            txt_surname.Enabled = false;
            txt_phone_no.Enabled = false;
            txt_email.Enabled = false;
            txt_new_password.Enabled = false;
            txt_repeat_new_password.Enabled = false;

            txt_new_password.Text = "";
            txt_repeat_new_password.Text = "";

        }
        // BİLGİLERİM sekmesindeki Adres formunu devre dışı bırak
        private void ResetAdressInfo()
        {
            btn_update_adrinfo.Text = "Düzenle";
            btn_update_adrinfo_yes = false;
            txt_street.Enabled = false;
            txt_district.Enabled = false;
            txt_avenue.Enabled = false;
            txt_building_no.Enabled = false;
            txt_apartment_no.Enabled = false;
            txt_town.Enabled = false;
            cmbox_province.Enabled = false;
        }
        // Şifre fieldlar için bir kontrol mekanizması
        private bool PasswordControl()
        {
            if (txt_new_password.Text != txt_repeat_new_password.Text)
                return false;
            else
                return true;
        }
        // Adres kısmındaki field ların boş olup olmama durumu
        private bool Adress_ControlEmptyFields()
        {
            if (txt_street.Text == "" || txt_district.Text == "" || txt_avenue.Text == "" || txt_building_no.Text == ""
                || txt_apartment_no.Text == "" || txt_town.Text == "" || cmbox_province.Text == "")
                return false;
            else
                return true;
        }

        // Kişisel bilgiler kısmındaki field ların boş olup olmama durumu
        private bool Personal_ControlEmptyFields()
        {
            // txt_phone_no maskedtxt nesnesinin karakter sınırı 16 değilse boştur (Güncelleme butonunda veritabanına eklenecek şekilde ayarlanacaktır)
            if (txt_name.Text == "" || txt_surname.Text == "" || txt_phone_no.Text.Length != 16 || txt_email.Text == "")
                return false;
            else
                return true;
        }

        // DataGridView Temizleme
        private void ResetDataGridView(DataGridView grid)
        {
            //kaynak https://docs.microsoft.com/tr-tr/dotnet/api/system.windows.forms.datagridviewcolumncollection.clear?view=net-5.0
            grid.CancelEdit();
            grid.Columns.Clear();
            grid.DataSource = null;
        }
        // Sepet datagridview i temizler, sütunlarını yazdırır tekrardan
        private void ResetShoppingCart()
        {

            // Sepeti temizle
            ResetDataGridView(dtgd_shopping_cart);

            // Tekrardan sütunları yazdırdık
            dtgd_shopping_cart.ColumnCount = 3;
            dtgd_shopping_cart.Columns[0].Name = "Ürün NO";
            dtgd_shopping_cart.Columns[1].Name = "Ürün Adı";
            dtgd_shopping_cart.Columns[2].Name = "Adet";

        }

        //fatura bilgisindeki textboxları temizle
        private void Clear_TextBox_Bill()
        {
            lbl_bill_no.Text = "-";
            lbl_branch_title.Text = "-";
            lbl_sales_rep.Text = "-";
            lbl_total_price.Text = "-";
            lbl_bill_date.Text = "-";
        }

        // Sipariş durumunu kontrol edip ilgili checkboxı aktif etme / devre dışı bırakma
        private void Check_Order_Status()
        {

            // Eğer boş ise chckbox devre dışı bırak veya hiç tamamlanmış sipariş yok ise(Tamamlanmış siparişleri göster butonu)
            if (dtgd_order_info_table.RowCount == 0)
                chckbox_completed.Enabled = false;
            // Tablo dolu ise
            else
            {
                int count_completed = 0;        // Sayaç kurdum hangi siparişler tamamlandı ise saydırıcam
                int count_not_completed = 0;    // Sayaç kurdum hangi siparişler tamamlanmadı işe saydırcam
                // Tabloda Sipariş durumu tamamlandı olanları saydır
                foreach (DataGridViewRow row in dtgd_order_info_table.Rows)
                {
                    // Tamamlandı ise sayacı arttır
                    if (row.Cells[3].Value.ToString() == "Tamamlandı")
                    {
                        ++count_completed;
                    }
                    else
                        ++count_not_completed;

                }

                // Tamamlanan siparişler sayacı tablodaki satır sayısına eşit ve tablonun satır sayısı sıfırdan büyük ise
                if (count_completed == dtgd_order_info_table.RowCount && dtgd_order_info_table.RowCount > 0)
                {
                    chckbox_completed.Enabled = false;      // Butonu devre dışı bırak
                }
                else if (count_not_completed >= 0 && count_completed == 0)      // Tamamlanan sipariş yok ama bir tane bile sipariş var ise
                    chckbox_completed.Enabled = false;      // Butonu aktif et
                else
                    chckbox_completed.Enabled = true;       // Butonu devre dışı bırak

            }
        }
        #endregion

        #region Eventler(Olaylar) fonksiyonları
        //  Form yüklenirken olacaklar
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            textInfo = cultureInfo.TextInfo;        // string ifadede büyük harf yapmak için nesneye, nesnenin özelliği atıldı
            chckbox_completed.Enabled = false;      // Tamamlanmış siparişleri gösterme butonunu devre dışı bırak
            connection.OpenConnection();            // Veritabanı bağlantısını aç

            //Şube adı cmbox listesini dolduruyoruz
            MySqlDataReader reader = connection.DataReader("select *from sube");
            while (reader.Read())
            {
                cmbox_branch_selection.Items.Add(reader["ad"]);
            }
            connection.CloseConnection();

            //Ödeme yöntemini cmbox listesini dolduruyoruz
            connection.OpenConnection();
            MySqlDataReader reader2 = connection.DataReader("select *from odeme");
            while (reader2.Read())
            {
                cmbox_payment_selection.Items.Add(reader2["aciklama"]);
            }
            connection.CloseConnection();

            //Kategori combobox içine kategori adını ekleme veritabanı ile
            connection.OpenConnection();
            MySqlDataReader reader3 = connection.DataReader("select *from kategori");
            while (reader3.Read())
            {
                cmbox_category.Items.Add(reader3["ad"]);
            }
            cmbox_category.Items.Add("Hepsi");
            connection.CloseConnection();


            //Sepet tablosunun sütunlarnı yazdırdık
            dtgd_shopping_cart.ColumnCount = 3;
            dtgd_shopping_cart.Columns[0].Name = "Ürün NO";
            dtgd_shopping_cart.Columns[1].Name = "Ürün Adı";
            dtgd_shopping_cart.Columns[2].Name = "Adet";


            // BİLGİLER sekmesindeki il cmbox nesnesini doldurmak için veritabanından bilgileri çekiyoruz
            connection.OpenConnection();
            province_list = connection.DataReader("select * from il");

            // Okuduğu sürece
            while (province_list.Read())
            {
                cmbox_province.Items.Add(province_list["il_isim"]);
            }
            connection.CloseConnection();
        }

        //Formu kapatırken
        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //kaynak https://sanalkurs.net/c-formu-kontrollu-kapatmak-iki-kere-sormasina-cozum-10562.html
            // Mesaj onayında iki kere sormayı engelleme
            if (!close_state)
            {
                result = MessageBox.Show("Çıkış yapmak istiyor musunuz?", "Onaylama", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                close_state = result == DialogResult.Yes;       // "Evet" butonuna basıldıysa
            }

            //  "Hayır" Butonuna basıldıysa
            if (result == DialogResult.No)
                e.Cancel = true;        // İptal et işlemi
            else
                Application.Exit();
        }

        // Şube Seçildiğinde olucak işlemler
        private void cmbox_branch_selection_SelectedIndexChanged(object sender, EventArgs e)
        {
            //bileşen temizleme
            cmbox_staff_selection.Items.Clear();
            txt_product_search.Text = "";
            cmbox_category.Text = "Hepsi";
            staff_info.Clear();
            ResetShoppingCart();        // Sepeti temizler

            //Seçilen şubeye göre ürün bilgilerini getir
            connection.filtering("select u1.urun_kod as 'Ürün NO',u1.ad as 'Ad',k1.ad as 'Kategori',u1.aciklama as 'Açıklama',u1.fiyat as 'Fiyat', s2.adet'Stok Durumu' " +
                "from sube s1,urun u1 ,stok s2,kategori k1 where s1.ad='" + cmbox_branch_selection.Text + "' and " +
                "(s1.sube_no=s2.sube_no and s2.adet>0 and u1.urun_kod=s2.urun_kod and u1.kategori_kod=k1.kategori_kod);", dtgd_product_table);

            //Şeçilen şubeye göre satış temsilcileri
            connection.OpenConnection();
            MySqlDataReader reader = connection.DataReader("select p1.ad,p1.soyad,p1.sicil_no, s1.sube_no from personel p1, sube s1 where s1.ad='" + cmbox_branch_selection.Text + "' and s1.sicil_no<>p1.sicil_no and s1.sube_no=p1.sube_no;");
            while (reader.Read())
            {
                cmbox_staff_selection.Items.Add((reader["ad"] + " " + reader["soyad"]));
                //gelen personelleri sicil no ile tutma
                staff_info.Add(int.Parse(reader["sicil_no"].ToString()), (reader["ad"] + " " + reader["soyad"]));
            }

            //sube_no alma
            branch_number = int.Parse(reader["sube_no"].ToString());
            connection.CloseConnection();
        }

        // Satış Temsilcisi seçme işlemi
        private void cmbox_staff_selection_SelectedIndexChanged(object sender, EventArgs e)
        {
            // personelin sicilini çekme
            foreach (var item in staff_info)
            {
                if (cmbox_staff_selection.Text == item.Value)
                {
                    staff_number = item.Key;
                    break;
                }
            }
        }

        // Ödeme Yöntemi seçme işlemi
        private void cmbox_payment_selection_SelectedIndexChanged(object sender, EventArgs e)
        {
            // odeme kodu alma
            connection.OpenConnection();
            MySqlDataReader reader = connection.DataReader("select odeme_kod from odeme where aciklama='" + cmbox_payment_selection.Text + "'");
            if (reader.Read())
            {
                payment_number = int.Parse(reader["odeme_kod"].ToString());
            }
            connection.CloseConnection();
        }

        // Sepete ürün ekleme butonu
        private void btn_add_to_card_Click(object sender, EventArgs e)
        {
            if (dtgd_product_table.RowCount <= 0)
            {
                MessageBox.Show("Şecili ürün yok", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool Is_exist = false;
                // Ürünler tablosunda seçili olan hücrenin satır indisini çekiyoruz
                int selectedarea_product = dtgd_product_table.SelectedCells[0].RowIndex;
                string[] row = new string[3];

                // Aynı ürün sepette var mı onun kontrolü
                for (int i = 0; i < dtgd_shopping_cart.RowCount; i++)
                {
                    // Aynı ürün varsa hata mesajı göster
                    if (dtgd_product_table.Rows[selectedarea_product].Cells[0].Value.ToString() == dtgd_shopping_cart.Rows[i].Cells[0].Value.ToString())
                    {
                        Is_exist = true;
                        break;
                    }
                }



                // Aynı ürün sepette var ise hata mesajı göster.
                if (Is_exist)
                    MessageBox.Show("Bu ürün zaten ekli!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Yok ise ekleme işini yap
                else
                {
                    row = new string[]
    {
                    dtgd_product_table.Rows[selectedarea_product].Cells[0].Value.ToString(),  // Ürün kod
                    dtgd_product_table.Rows[selectedarea_product].Cells[1].Value.ToString(),  // Ürün ad
                    "1"                                                                       // Ürünün miktarı
    };
                    dtgd_shopping_cart.Rows.Add(row);           // Sepete ilgili ürünü ekle
                }
            }
        }

        // Sepeti temizleme tuşu
        private void btn_clear_cart_Click(object sender, EventArgs e)
        {
            if (dtgd_shopping_cart.RowCount == 0)
                MessageBox.Show("Sepetiniz boş!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                ResetShoppingCart();
                MessageBox.Show("Sepetiniz temizlendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // İlgili ürünün adetini arttırtma
        private void btn_increase_item_Click(object sender, EventArgs e)
        {


            if (dtgd_shopping_cart.RowCount == 0)
                MessageBox.Show("Sepetiniz boş!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {

                //MessageBox.Show("Bu kod kısmına yapıcağın işlemler");
                int selectedarea_cart = dtgd_shopping_cart.SelectedCells[0].RowIndex;  // Seçili hücrenin satır indisi
                int count = 0;

                // Sepetteki seçili hücrenin ürün numarasını alıyorum
                int shop_product_no = int.Parse(dtgd_shopping_cart.Rows[selectedarea_cart].Cells[0].Value.ToString());
                int stock = 0;

                // Ürünler tablosundaki aynı ürün numarasını bulup stok miktarını çekiyorum
                foreach (DataGridViewRow row in dtgd_product_table.Rows)
                {
                    if (int.Parse(row.Cells[0].Value.ToString()) == shop_product_no)
                    {
                        stock = int.Parse(row.Cells[5].Value.ToString());
                        break;
                    }

                }

                // İlgili ürünün stok miktarını çekiyor
                //MessageBox.Show(stock.ToString());

                int amount = int.Parse(dtgd_shopping_cart.Rows[selectedarea_cart].Cells[2].Value.ToString()) + 1;


                // Stok miktarından küçük veya eşit olduğu sürece sepete ürün ekleyebilir
                if (amount <= stock)
                {
                    count = int.Parse(dtgd_shopping_cart.Rows[selectedarea_cart].Cells[2].Value.ToString());
                    count++;
                    dtgd_shopping_cart.Rows[selectedarea_cart].Cells[2].Value = count;
                }
                else
                    MessageBox.Show("Stok miktarı geçilemez!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        // İlgili ürünü sepetten kaldırma veya adetini düşürme
        private void btn_decrease_item_Click(object sender, EventArgs e)
        {
            // Sepet boş ise uyarı mesajı göster
            if (dtgd_shopping_cart.RowCount == 0)
                MessageBox.Show("Sepetiniz boş!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                int selectedarea_cart = dtgd_shopping_cart.SelectedCells[0].RowIndex;
                int count = 0;

                // Eğer ilgili üründen sepette bir tane var ise sepetten kaldır ve müşteriyi mesaj ver
                if (dtgd_shopping_cart.Rows[selectedarea_cart].Cells[2].Value.ToString() == "1")
                {
                    dtgd_shopping_cart.Rows.RemoveAt(selectedarea_cart);
                    MessageBox.Show("Sepetten ürün kaldırıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Eğer ilgili ürünün adeti 1'den fazla ise adet sayısını azalt
                else
                {
                    count = int.Parse(dtgd_shopping_cart.Rows[selectedarea_cart].Cells[2].Value.ToString());
                    count--;
                    dtgd_shopping_cart.Rows[selectedarea_cart].Cells[2].Value = count;
                }

            }
        }

        // Sepeti onaylamak için gerekli işlemler
        private void btn_cart_confirm_Click(object sender, EventArgs e)
        {
            //temizle
            txt_product_search.Text = "";
            cmbox_category.Text = "Hepsi";
            //Seçilen şubeye göre tüm ürün bilgilerini getir
            connection.filtering("select u1.urun_kod as 'Ürün NO',u1.ad as 'Ad',k1.ad as 'Kategori',u1.aciklama as 'Açıklama',u1.fiyat as 'Fiyat', s2.adet'Stok Durumu' " +
                "from sube s1,urun u1 ,stok s2,kategori k1 where s1.ad='" + cmbox_branch_selection.Text + "' and " +
                "(s1.sube_no=s2.sube_no and s2.adet>0 and u1.urun_kod=s2.urun_kod and u1.kategori_kod=k1.kategori_kod);", dtgd_product_table);

            if (dtgd_shopping_cart.RowCount == 0)
                MessageBox.Show("Sepetiniz boş!", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (cmbox_staff_selection.Text == "")
                MessageBox.Show("Lütfen satış temsilcisi seçiniz.", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (cmbox_payment_selection.Text == "")
                MessageBox.Show("Lütfen ödeme yöntemi seçiniz.", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                int order_no = 0;
                // Tarihi çekiyoruz
                DateTime time = DateTime.Now;
                string order_date = time.Year.ToString() + "-" + time.Month.ToString() + "-" + time.Day.ToString() + " " + time.Hour.ToString() + ":" + time.Minute.ToString() + ":" + time.Second.ToString();


                // Siparişimiz oluşturulur.
                connection.SqlProcess("insert into siparis (musteri_no,sube_no,sicil_no,odeme_kod,siparis_tarih,durum) " +
                    "values('" + customer_number + "','" + branch_number + "','" + staff_number + "','" + payment_number + "','" + order_date + "','A')");



                // Siparişin detayları veritabanına ekleniyor.
                // Query : SELECT `siparis_no` FROM `siparis` ORDER BY `siparis_no` DESC LIMIT 1;  --> sipariş numarası çıkart

                connection.OpenConnection();
                MySqlDataReader reader = connection.DataReader("select siparis_no from siparis order by siparis_no desc limit 1");

                // Sipariş numarasını çekiyoruz
                if (reader.Read())
                {
                    order_no = int.Parse(reader["siparis_no"].ToString());
                }

                connection.CloseConnection();

                // Sepetteki ürünlerin kodunu ve adetini çekiyoruz
                for (int i = 0; i < dtgd_shopping_cart.RowCount; i++)
                {
                    int key = int.Parse(dtgd_shopping_cart.Rows[i].Cells[0].Value.ToString());      // Ürün kodu
                    int value = int.Parse(dtgd_shopping_cart.Rows[i].Cells[2].Value.ToString());    // Ürün adeti
                    order_detail_info.Add(key, value);
                }

                // İlgili siparişin detayları veritabanına eklenir
                foreach (var item in order_detail_info)
                {
                    connection.SqlProcess("insert into siparisdetay values('" + order_no + "','" + item.Key + "','" + item.Value + "')");
                }


                // Bütün işlemler bittikten sonra mesaj verilir
                MessageBox.Show("Siparişiniz alınmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Temizleme işlemleri
                order_detail_info.Clear();
                cmbox_staff_selection.Text = "";
                cmbox_branch_selection.Text = "";
                cmbox_payment_selection.Text = "";
                ResetShoppingCart();

            }

        }

        // BİLGİLERİM sekmesine girildiğinde yapılacak eylemler
        private void tbpage_personal_info_Enter(object sender, EventArgs e)
        {

            // Ön hazırlıklar 
            cmbox_province.Text = "";
            ResetPersonalInfo();
            ResetAdressInfo();

            connection.OpenConnection();    // bağlantı açıldı

            // Kişisel bilgiler kısmını doldurmak için eylemler
            MySqlDataReader reader_per = connection.DataReader("select * from musteri where musteri_no='" + customer_number + "'");

            // reader_per nesnesi eğer okuma yapabiliyor ise (Kişisel bilgilerindeki textbox ları doldur)
            if (reader_per.Read())
            {
                // reader_per nesnesinden çektiğimiz bilgileri gerekli alanlara yazdırıyoruz
                txt_name.Text = reader_per["ad"].ToString();                // ad
                txt_surname.Text = reader_per["soyad"].ToString();          // soyad
                txt_phone_no.Text = reader_per["telefon"].ToString();       // telefon
                txt_email.Text = reader_per["email"].ToString();            // email

                adress_no = int.Parse(reader_per["adres_id"].ToString());   // İlgili müşterinin adress id sini çekiyoruz

            }
            else
                MessageBox.Show("Veritabanındaki bilgiler yok veya okunulmuyor", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            connection.CloseConnection();   // bağlantı kapatıldı


            connection.OpenConnection();    // bağlantı açıldı

            // Adres kısmını doldurmak için eylemler
            MySqlDataReader reader_adress = connection.DataReader("select * from adres where adres_id='" + adress_no + "'");

            // reader_adress nesnesi eğer okuma yapabiliyor ise (Adres bilgilerindeki textbox ları doldur)
            if (reader_adress.Read())
            {
                txt_street.Text = reader_adress["sokak"].ToString();                // Sokak
                txt_district.Text = reader_adress["mahalle"].ToString();            // Mahalle
                txt_avenue.Text = reader_adress["cadde"].ToString();                // Cadde
                txt_building_no.Text = reader_adress["bina_no"].ToString();         // Bina NO
                txt_apartment_no.Text = reader_adress["daire_no"].ToString();       // Daire NO
                txt_town.Text = reader_adress["ilce"].ToString();                   // İlçe
            }

            connection.CloseConnection();       // bağlantı kapatıldı


        }

        // Kişisel bilgileri güncellemek için kullanılacak buton
        private void btn_update_perinfo_Click(object sender, EventArgs e)
        {
            // İlk tıklandığında güncellemek için textboxları aktif et
            btn_update_perinfo.Text = "Güncelle";
            txt_name.Enabled = true;
            txt_surname.Enabled = true;
            txt_phone_no.Enabled = true;
            txt_email.Enabled = true;
            txt_new_password.Enabled = true;
            txt_repeat_new_password.Enabled = true;


            if (btn_update_perinfo_yes)
            {

                // Kişisel bilgilerdeki field ların boş olup olmama durumunun kontrolü
                if (!Personal_ControlEmptyFields())
                    MessageBox.Show("Boş geçilemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    // Yeni bir şifre oluşturulacak ise (mevcut olan güncellenecek ise)
                    if (!PasswordControl())
                        MessageBox.Show("Şifre alanları aynı olmalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        if (txt_new_password.Text.Length != 4 && txt_new_password.Text.Length != 0)
                            MessageBox.Show("Şifreler dört haneli olmalıdır", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                        {
                            // Telefon numarasını veritabanına eklenecek şekilde düzenliyoruz
                            string formatted_phone = (((txt_phone_no.Text.Replace("(", "")).Replace(")", "")).Replace("-", "")).Replace(" ", "");

                            // Şifre alanları boş ise şifre bilgisi dışındaki bilgiler güncellenir, değilse şifre bilgisi de güncellenir
                            if (txt_new_password.Text == "" && txt_repeat_new_password.Text == "")
                                connection.SqlProcess("update musteri set ad='" + textInfo.ToTitleCase(txt_name.Text) + "',soyad='" + textInfo.ToTitleCase(txt_surname.Text) + "',email='" + txt_email.Text + "',telefon='" + formatted_phone + "' where musteri_no='" + customer_number + "'");
                            else
                                connection.SqlProcess("update musteri set ad='" + textInfo.ToTitleCase(txt_name.Text) + "',soyad='" + textInfo.ToTitleCase(txt_surname.Text) + "',email='" + txt_email.Text +
                                    "',sifre='" + txt_new_password.Text + "',telefon='" + formatted_phone + "' where musteri_no='" + customer_number + "'");


                            // Veritabanında bilgiler güncellendikten sonra kullanıcıyı bilgilendir
                            MessageBox.Show("Bilgileriniz güncellenmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lbl_customer_info.Text = "Hoşgeldiniz, Sayın " + textInfo.ToTitleCase(txt_name.Text) + " " + txt_surname.Text.ToUpper(); //hosgeldiniz kısmındaki adı soyadı güncelle
                            ResetPersonalInfo();
                        }

                    }
                }
            }
            else
                btn_update_perinfo_yes = true;
        }

        // Adres bilgilerini güncellemek için kullanılacak buton
        private void btn_update_adrinfo_Click(object sender, EventArgs e)
        {

            // İlk tıklandığında güncellemek için textboxları aktif et
            btn_update_adrinfo.Text = "Güncelle";
            txt_street.Enabled = true;
            txt_district.Enabled = true;
            txt_avenue.Enabled = true;
            txt_building_no.Enabled = true;
            txt_apartment_no.Enabled = true;
            txt_town.Enabled = true;
            cmbox_province.Enabled = true;

            if (btn_update_adrinfo_yes)
            {

                if (!Adress_ControlEmptyFields())
                    MessageBox.Show("Boş geçilemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    // Veritabanında ilgili bilgiyi güncellemek için SQL sorgusu
                    connection.SqlProcess("update adres set sokak='" + textInfo.ToTitleCase(txt_street.Text) + "',mahalle='" + textInfo.ToTitleCase(txt_district.Text) + "'," +
                        "cadde='" + textInfo.ToTitleCase(txt_avenue.Text) + "',bina_no='" + txt_building_no.Text + "',daire_no='" + txt_apartment_no.Text + "'" +
                        ",ilce='" + textInfo.ToTitleCase(txt_town.Text) + "',il_id='" + province_id + "' where adres_id='" + adress_no + "'");

                    // Veritabanında bilgiler güncellendikten sonra kullanıcıyı bilgilendir
                    MessageBox.Show("Adres bilgileriniz güncellenmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetAdressInfo();
                }

            }
            else
                btn_update_adrinfo_yes = true;
        }

        // İl cmbox bilgisini çekiyoruz
        private void cmbox_province_SelectedIndexChanged(object sender, EventArgs e)
        {
            // il_id alma
            connection.OpenConnection();
            MySqlDataReader reader = connection.DataReader("select il_id from il where il_isim='" + cmbox_province.Text + "'");
            if (reader.Read())
            {
                // il_id bilgisini cmbox_province nesnesinin o andaki text ine göre çekiyoruz
                province_id = int.Parse(reader["il_id"].ToString());
            }
            connection.CloseConnection();
        }

        //Kategori türü değişince ürünleri ona göre listele
        private void cmbox_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbox_category.Text == "Hepsi")
            {
                //Seçilen şubeye göre tüm ürün bilgilerini getir
                connection.filtering("select u1.urun_kod as 'Ürün NO',u1.ad as 'Ad',k1.ad as 'Kategori',u1.aciklama as 'Açıklama',u1.fiyat as 'Fiyat', s2.adet'Stok Durumu' " +
                    "from sube s1,urun u1 ,stok s2,kategori k1 where s1.ad='" + cmbox_branch_selection.Text + "' and " +
                    "(s1.sube_no=s2.sube_no and s2.adet>0 and u1.urun_kod=s2.urun_kod and u1.kategori_kod=k1.kategori_kod);", dtgd_product_table);
            }
            else
            {
                //Seçilen kategoriye göre ürün bilgilerini getir
                connection.filtering("select u1.urun_kod as 'Ürün NO',u1.ad as 'Ad',k1.ad as 'Kategori',u1.aciklama as 'Açıklama',u1.fiyat as 'Fiyat', s2.adet'Stok Durumu' " +
                    "from sube s1,urun u1 ,stok s2,kategori k1 where s1.ad='" + cmbox_branch_selection.Text + "' and k1.kategori_kod=(select kategori_kod from kategori where ad='" + cmbox_category.Text + "') and" +
                    " (s1.sube_no=s2.sube_no and s2.adet>0 and u1.urun_kod=s2.urun_kod and u1.kategori_kod = k1.kategori_kod);", dtgd_product_table);
            }

        }

        // FATURALARIM sekmesinde Sipariş bilgileri tablosunda herhangi bir hücreye tıklandığında
        private void dtgd_order_info_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgd_order_info_table.RowCount > 0)
            {
                // Sipariş bilgileri tablosunda seçilmiş olan hücrenin satır indisini seç
                int selectedarea = dtgd_order_info_table.SelectedCells[0].RowIndex;
                // Tablodaki sipariş numarasını alıyoruz
                int order_no = int.Parse(dtgd_order_info_table.Rows[selectedarea].Cells[0].Value.ToString());

                // Sipariş detayları tablosunu dolduruyoruz ilgili sipariş numarasına göre
                connection.filtering("SELECT u.urun_kod 'Ürün NO',k.ad 'Ürün Kategori',u.ad 'Ürün Ad',sd.adet 'Adet',u.aciklama 'Açıklama' FROM siparis s INNER JOIN siparisdetay sd ON(s.siparis_no=sd.siparis_no) " +
                    "INNER JOIN urun u ON(u.urun_kod=sd.urun_kod) INNER JOIN kategori k ON(k.kategori_kod = u.kategori_kod) WHERE s.siparis_no='" + order_no + "'", dtgd_order_details);

                // SQL SORGUSU FATURA =
                // "SELECT f.fatura_no 'Fatura NO', su.ad 'Şube Adı',p.ad 'Satış Temsilcisi', f.tutar 'Toplam Tutar', f.kesim_tarih 'Kesim Tarihi' FROM siparis s " +
                // "INNER JOIN sube su ON(su.sube_no=s.sube_no) INNER JOIN fatura f ON(f.siparis_no=s.siparis_no) INNER JOIN personel p ON(p.sicil_no = s.sicil_no) WHERE s.siparis_no='" + order_no + "'"



                // Fatura Bilgisi
                connection.OpenConnection();

                MySqlDataReader read_bill = connection.DataReader("SELECT f.fatura_no 'Fatura NO', su.ad 'Şube Adı',concat(p.ad,' ',p.soyad) 'Satış Temsilcisi', f.tutar 'Toplam Tutar', f.kesim_tarih 'Kesim Tarihi' FROM siparis s " +
                    "INNER JOIN sube su ON(su.sube_no=s.sube_no) INNER JOIN fatura f ON(f.siparis_no=s.siparis_no) INNER JOIN personel p ON(p.sicil_no = s.sicil_no) WHERE s.siparis_no='" + order_no + "' and s.durum='T'");

                if (read_bill.Read())
                {
                    lbl_bill_no.Text = read_bill["Fatura NO"].ToString();
                    lbl_branch_title.Text = read_bill["Şube Adı"].ToString();
                    lbl_sales_rep.Text = read_bill["Satış Temsilcisi"].ToString();
                    lbl_total_price.Text = read_bill["Toplam Tutar"].ToString() + " TL";
                    lbl_bill_date.Text = read_bill["Kesim Tarihi"].ToString();
                }
                else
                {
                    Clear_TextBox_Bill();
                }

                connection.CloseConnection();
            }
        }


        // FATURALAR sekmesine girildiğinde yapılacak işlemler
        private void tbpage_bills_Enter(object sender, EventArgs e)
        {
            // İlgili nesneleri sekmeye girdiğinde resetle ve sipariş tablosunu yenile
            connection.filtering("SELECT s.siparis_no 'Sipariş NO',o.aciklama 'Ödeme Yöntemi',s.siparis_tarih 'Sipariş Tarihi',st.aciklama 'Sipariş Durumu' FROM siparis s  " +
                "INNER JOIN siparisdurum st ON(s.durum=st.durum) INNER JOIN odeme o ON(o.odeme_kod=s.odeme_kod) WHERE s.musteri_no='" + customer_number + "'", dtgd_order_info_table);

            // Tamamlanmış siparişleri göster butonu için kontrol (aktif mi kalıcak devre dışı mı?)  -SK -ÖF
            Check_Order_Status();

            // Temizleme işlemleri
            ResetDataGridView(dtgd_order_details);
            Clear_TextBox_Bill();

        }
        // Fatura bilgisinin PDF olarak çıkartır
        private void btn_save_as_pdf_Click(object sender, EventArgs e)
        {
            if (lbl_bill_no.Text == "-")
                MessageBox.Show("Faturası kesilmemiş", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Document report = new Document();
                SaveFileDialog saveFileDialog = new SaveFileDialog(); //dialog ekranı ile dosya kaydetmek için pencere açma
                saveFileDialog.Filter = "PDF *.pdf|*.pdf";  //kaydetme uzantı türü
                saveFileDialog.FileName = "Fatura"; //default dosya kaydetme adı

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Kaynak http://www.canerkara.com/2013/08/itextsharp-turkce-karakter-sorunu.html
                    //Pdf Türkçe karakter sorunu çözümü 
                    iTextSharp.text.pdf.BaseFont STF_Helvetica_Turkish = iTextSharp.text.pdf.BaseFont.CreateFont("Helvetica", "CP1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);
                    iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(STF_Helvetica_Turkish, 12, iTextSharp.text.Font.NORMAL);

                    //pdf dosyasını seçilen yolda oluştur
                    PdfWriter.GetInstance(report, new FileStream(saveFileDialog.FileName, FileMode.Create));

                    //adres bilgelerini çekme
                    string adress_info = "";
                    connection.OpenConnection();
                    MySqlDataReader reader = connection.DataReader("select sokak,mahalle,cadde,bina_no,daire_no,ilce,i1.il_isim from adres a1 , musteri m1,il i1 where m1.musteri_no='" + customer_number + "' " +
                        "and a1.adres_id=m1.adres_id and a1.il_id=i1.il_id;");
                    if (reader.Read())
                    {
                        adress_info = "ADRES : " + reader["mahalle"] + " " + reader["cadde"] + " " + reader["sokak"] + " No:" + reader["bina_no"] + "/" + reader["daire_no"] + " " + reader["ilce"] + "/" + reader["il_isim"];
                    }
                    connection.CloseConnection();


                    //Dosya açık değil ise aç
                    if (report.IsOpen() == false)
                    {
                        report.Open();
                    }
                    //pdf içine yazdırılacak metin
                    string bill_detail = "FATURA NUMARASI : " + lbl_bill_no.Text + "\n" + "ŞUBE İSMİ : " + lbl_branch_title.Text + "\n" + "SATIŞ TEMSİLCİSİ : " + lbl_sales_rep.Text +
                        "\n" + "KESİLME TARİHİ : " + lbl_bill_date.Text + "\n" + "TOPLAM FİYAT : " + lbl_total_price.Text;
                    report.Add(new Paragraph(bill_detail, fontNormal)); //fatura bilgisini pdf'e ekle
                    report.Add(new Paragraph(adress_info, fontNormal)); //adres bilgisini ekleme
                    report.Close(); //pdf'i kapat

                    // Kullanıcıyı pdf dosyasının konumunu gösterip işlemin başarılı şekilde gerçekleştiğini yazdır.
                    string location = "Konum: " + saveFileDialog.FileName + "\nFaturanız kaydedilmiştir.";
                    MessageBox.Show(location, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //arama textboxı her değistinde ürünleri yenile
        private void txt_product_search_TextChanged(object sender, EventArgs e)
        {
            if (cmbox_category.Text == "Hepsi")
            {
                //Seçilen şubeye göre aranan ürün bilgilerini getir
                connection.filtering("select u1.urun_kod as 'Ürün NO',u1.ad as 'Ad',k1.ad as 'Kategori',u1.aciklama as 'Açıklama',u1.fiyat as 'Fiyat', s2.adet'Stok Durumu' " +
                    "from sube s1,urun u1 ,stok s2,kategori k1 where s1.ad='" + cmbox_branch_selection.Text + "' and " +
                    "(s1.sube_no=s2.sube_no and s2.adet>0 and u1.urun_kod=s2.urun_kod and u1.kategori_kod=k1.kategori_kod and u1.ad like '" + txt_product_search.Text + "%');", dtgd_product_table);
            }
            else
            {
                //Seçilen kategoriye göre aranan ürün bilgilerini getir
                connection.filtering("select u1.urun_kod as 'Ürün NO',u1.ad as 'Ad',k1.ad as 'Kategori',u1.aciklama as 'Açıklama',u1.fiyat as 'Fiyat', s2.adet'Stok Durumu' " +
                    "from sube s1,urun u1 ,stok s2,kategori k1 where s1.ad='" + cmbox_branch_selection.Text + "' and k1.kategori_kod=(select kategori_kod from kategori where ad='" + cmbox_category.Text + "') and" +
                    " (s1.sube_no=s2.sube_no and s2.adet>0 and u1.urun_kod=s2.urun_kod and u1.kategori_kod = k1.kategori_kod and u1.ad like '" + txt_product_search.Text + "%');", dtgd_product_table);
            }

        }

        //Onaylanmayan siparişi kaldırma / iptal etme
        private void btn_order_remove_Click(object sender, EventArgs e)
        {
            //sipariş yok ise
            if (dtgd_order_info_table.RowCount == 0)
                MessageBox.Show("Sipariş Kaldırılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                //seçili satırı alma
                int selectedarea = dtgd_order_info_table.SelectedCells[0].RowIndex;
                if (dtgd_order_info_table.Rows[selectedarea].Cells[3].Value.ToString() == "Alındı")
                {
                    //onay mesajı ve onaylatma
                    DialogResult result = MessageBox.Show("Siparişi iptal etmek istiyor musunuz? ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        //sipariş kaldırma
                        connection.SqlProcess("delete from siparis where siparis_no='" + dtgd_order_info_table.Rows[selectedarea].Cells[0].Value + "';");

                        //sipariş tablosunu yenile
                        connection.filtering("SELECT s.siparis_no 'Sipariş NO',o.aciklama 'Ödeme Yöntemi',s.siparis_tarih 'Sipariş Tarihi',st.aciklama 'Sipariş Durumu' FROM siparis s  " +
                    "INNER JOIN siparisdurum st ON(s.durum=st.durum) INNER JOIN odeme o ON(o.odeme_kod=s.odeme_kod) WHERE s.musteri_no='" + customer_number + "'", dtgd_order_info_table);

                        ResetDataGridView(dtgd_order_details);
                        MessageBox.Show("Sipariş iptal edilmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Tamamlanmış siparişleri göster butonu için kontrol (aktif mi kalıcak devre dışı mı?)  -SK -ÖF
                        Check_Order_Status();
                    }
                }
                else
                    MessageBox.Show("Faturası kesildiğinden sipariş kaldırılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        //  Tamamlanmış siparişleri gösterme
        private void chckbox_completed_CheckedChanged(object sender, EventArgs e)
        {
            // Seçili ise tamamlanmış faturaları getir, değilse tekrardan bütün siparişleri getir
            if (chckbox_completed.Checked == true)
            {
                connection.filtering("SELECT s.siparis_no 'Sipariş NO',o.aciklama 'Ödeme Yöntemi',s.siparis_tarih 'Sipariş Tarihi',st.aciklama 'Sipariş Durumu' FROM siparis s  " +
                "INNER JOIN siparisdurum st ON(s.durum=st.durum) INNER JOIN odeme o ON(o.odeme_kod=s.odeme_kod) WHERE s.musteri_no='" + customer_number + "' and st.aciklama='Tamamlandı'", dtgd_order_info_table);

            }
            else
            {
                connection.filtering("SELECT s.siparis_no 'Sipariş NO',o.aciklama 'Ödeme Yöntemi',s.siparis_tarih 'Sipariş Tarihi',st.aciklama 'Sipariş Durumu' FROM siparis s  " +
                "INNER JOIN siparisdurum st ON(s.durum=st.durum) INNER JOIN odeme o ON(o.odeme_kod=s.odeme_kod) WHERE s.musteri_no='" + customer_number + "'", dtgd_order_info_table);

            }

            // Temizleme
            ResetDataGridView(dtgd_order_details);
            Clear_TextBox_Bill();
        }

        #endregion
    }
}
