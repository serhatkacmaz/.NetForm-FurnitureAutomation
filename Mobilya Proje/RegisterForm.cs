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
using System.Globalization;
using System.Threading;

namespace Mobilya_Proje
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        DatabaseConnection connection = new DatabaseConnection();
        int province_number; // il_kodu

        //kaynak https://www.c-sharpcorner.com/blogs/convert-a-string-to-title-case-in-c-sharp1
        //string ifadede büyük harf yapma
        CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
        TextInfo textInfo;

        //Form Yüklenince
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            textInfo = cultureInfo.TextInfo;

            //illeri çekme
            connection.OpenConnection();
            MySqlDataReader reader = connection.DataReader("select *from il");
            while (reader.Read())
            {
                cmbox_province.Items.Add(reader["il_isim"]);
            }
            connection.CloseConnection();
        }

        //Müşteri kayıt etme butonu
        private void btn_register_customer_Click(object sender, EventArgs e)
        {
            //textbox boş mu değil mi için bool değişkenler
            bool adress_state = txt_street.Text == "" || txt_district.Text == "" || txt_avenue.Text == "" || txt_building_no.Text == "" || txt_apartment_no.Text == "" || txt_town.Text == "" || cmbox_province.Text == "";
            bool personel_state = txt_name.Text == "" || txt_surname.Text == "" || txt_identification.Text == "" || txt_phone_no.Text == "" || txt_email.Text == "" || txt_new_password.Text == "" || txt_repeat_new_password.Text == "";

            //bilgiler eksik mi?
            if (adress_state || personel_state)
                MessageBox.Show("Bilgiler Eksik", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                //şifreler aynı mı kontrolu
                if (txt_new_password.Text != txt_repeat_new_password.Text)
                    MessageBox.Show("Şifreler Eşleşmiyor", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (txt_new_password.Text.Length != 4 && txt_repeat_new_password.Text.Length != 4)
                    MessageBox.Show("Şifreler dört haneli olmalıdır", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    //müşteri adres ekleme
                    connection.SqlProcess("insert into adres (sokak,mahalle,cadde,bina_no,daire_no,ilce,il_id)" +
                        "values('" + textInfo.ToTitleCase(txt_street.Text) + "','" + textInfo.ToTitleCase(txt_district.Text) + "','" + textInfo.ToTitleCase(txt_avenue.Text) + "'," +
                        "'" + txt_building_no.Text + "','" + txt_apartment_no.Text + "','" + textInfo.ToTitleCase(txt_town.Text) + "','" + province_number + "')");


                    //eklenen adres_id alma
                    int adress_no = 0;
                    connection.OpenConnection();
                    MySqlDataReader reader = connection.DataReader("select adres_id from adres order by adres_id desc limit 1;");
                    if (reader.Read())
                    {
                        adress_no = int.Parse(reader["adres_id"].ToString());
                    }
                    connection.CloseConnection();


                    //telefon numarası formatlama
                    string formatted_phone = (((txt_phone_no.Text.Replace("(", "")).Replace(")", "")).Replace("-", "")).Replace(" ", "");

                    //müsteri bilgi ekleme
                    connection.SqlProcess("insert into musteri (ad,soyad,email,sifre,tc_no,telefon,adres_id)" +
                        "values('" + textInfo.ToTitleCase(txt_name.Text) + "','" + textInfo.ToTitleCase(txt_surname.Text) + "','" + txt_email.Text + "','" + txt_new_password.Text + "','" + txt_identification.Text + "','" + formatted_phone + "','" + adress_no + "')");

                    MessageBox.Show("Kayıt işleminiz yapıldı.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // kayıt işleminden sonra pencereyi kapat
                }
            }
        }

        //il combobox'ın texti değişince yapılan işlemler
        private void cmbox_province_SelectedIndexChanged(object sender, EventArgs e)
        {
            //il_id alma
            connection.OpenConnection();
            MySqlDataReader reader = connection.DataReader("select il_id from il where il_isim='" + cmbox_province.Text + "'");
            if (reader.Read())
            {
                province_number = int.Parse(reader["il_id"].ToString());
            }
            connection.CloseConnection();
        }
    }
}
