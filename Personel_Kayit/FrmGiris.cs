using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personel_Kayit
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=MYPC\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Yonetici where KullaniciAd=@p1 and Sifre=@p2",baglantı);
            komut.Parameters.AddWithValue("@p1", KullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", Sifre.Text);
            SqlDataReader dr= komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAnaForm form = new FrmAnaForm();
                form.Show();
                this.Hide();



            }
            else {

                MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre");
            
            }
            baglantı.Close();




            
        }
    }
}
