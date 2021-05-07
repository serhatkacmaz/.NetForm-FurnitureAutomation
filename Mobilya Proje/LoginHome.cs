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
    public partial class LoginHome : Form
    {
        public LoginHome()
        {
            InitializeComponent();
        }

        //DatabaseConnection classından veritabanı işlemlerini yapmak için nesne
        DatabaseConnection connection = new DatabaseConnection();
        bool state; // personel ise true, müşteri ise false
        string query; //sql sorgusu


        //Giriş Formu yüklenince
        private void LoginHome_Load(object sender, EventArgs e)
        {
            try
            {
                connection.OpenConnection();  // Bağlantı açılıyor
                if (connection.State()) // Tanımın durumunu kontrol ediyoruz (bağlı mı bağlı değil mi?)
                    MessageBox.Show("Bağlantı başarılı bir şekilde gerçekleşti.");
                else
                    MessageBox.Show("Veritabanına bağlanılmadı.");
                connection.CloseConnection();
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata oluştu : " + err.Message, "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        //Giriş Yap butonuna tıklanınca
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                connection.OpenConnection();
                if (state) //Personel sorgusu
                {
                    query = "select *from personel where sicil_no='" + txt_username.Text + "'and sifre='" + txt_password.Text + "'";
                }
                else //müşteri sorgusu
                {
                    query = "select *from musteri where email='" + txt_username.Text + "'and sifre='" + txt_password.Text + "'";
                }

                MySqlDataReader reader = connection.DataReader(query);

                if (reader.Read())
                {
                    if (state)//personel sayfasına giriş
                    {
                        if (reader["sifre"].ToString() == txt_password.Text && reader["sicil_no"].ToString() == txt_username.Text)
                        {
                            StaffForm staffForm = new StaffForm();
                            staffForm.label_user.Text += reader.GetString("ad") + " " + reader.GetString("soyad").ToUpper();
                            staffForm.staff_number = reader.GetString("sicil_no");
                            staffForm.branch_number = reader.GetString("sube_no");
                            staffForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            incorrect_entry();
                        }
                    }
                    else //müsteri sayfasına giriş
                    {
                        if (reader["sifre"].ToString() == txt_password.Text && reader["email"].ToString() == txt_username.Text)
                        {
                            CustomerForm customerForm = new CustomerForm();
                            customerForm.lbl_customer_info.Text += " " + reader.GetString("ad") + " " + reader.GetString("soyad").ToUpper();
                            customerForm.customer_number = reader.GetInt32("musteri_no");
                            customerForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            incorrect_entry();
                        }
                    }
                }
                else
                {
                    incorrect_entry();
                }
                connection.CloseConnection();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        //Hatalı Bilgi girişi
        private void incorrect_entry()
        {
            MessageBox.Show("Girilen Bilgiler Eksik veya Hatalı", "Hatalı giriş!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txt_username.Clear();
            txt_password.Clear();
        }

        //personel için giriş işlemi
        private void btn_staff_Click(object sender, EventArgs e)
        {
            panel_selection.Visible = false;
            panel_login.Visible = true;
            pictureBoxBack.Visible = true;
            btn_register.Visible = false;
            lbl_username.Text = "Sicil Numarası:";
            state = true;
            this.Text = "Personel Girişi";
        }

        //müşteri için giriş işlemi
        private void btn_customer_Click(object sender, EventArgs e)
        {
            panel_selection.Visible = false;
            panel_login.Visible = true;
            pictureBoxBack.Visible = true;
            lbl_username.Text = "Email:";
            state = false;
            this.Text = "Müşteri Girişi";
        }

        //Kullancı türü seçmek için Geri dönme 
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            panel_login.Visible = false;
            panel_selection.Visible = true;
            pictureBoxBack.Visible = false;
            btn_register.Visible = true;
            txt_username.Clear();
            txt_password.Clear();
            this.Text = "Giriş";
        }

        //Müsteri Kayıt Formuna giriş
        private void btn_register_Click(object sender, EventArgs e)
        {
            RegisterForm registerform = new RegisterForm();
            registerform.Show();
        }

        //Hakkımızda kısmı
        private void btn_about_us_Click(object sender, EventArgs e)
        {
            string about_us = "      Serhat KAÇMAZ\n181307036@kocaeli.edu.tr\n\n     Ömer Faruk YILMAZ\n191307048@kocaeli.edu.tr\n\n      Barış ADIGÜZEL\n181307059@kocaeli.edu.tr\n\n\n" +
                "Bu programın tüm hakları\nüç kişi içinde toplanmıştır.";
            MessageBox.Show(about_us, "HAKKIMIZDA", MessageBoxButtons.OK);
        }
    }
}
