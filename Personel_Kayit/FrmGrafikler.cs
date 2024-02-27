﻿using System;
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
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=MYPC\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            //grafik 1
            baglantı.Open();
            SqlCommand komutg1 = new SqlCommand("Select PerSehir,Count(*)From Tbl_Personel Group By PerSehir", baglantı);
            SqlDataReader dr1 = komutg1.ExecuteReader();
            while (dr1.Read())
            {

                chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
            }

            baglantı.Close();
            //grafik 2

            baglantı.Open();
            SqlCommand komutg2 = new SqlCommand("Select  PersonelMeslek,Avg(PerMaas) From Tbl_Personel Group By   PersonelMeslek", baglantı);
            SqlDataReader dr2 = komutg2.ExecuteReader();
            while (dr2.Read()) {


                chart2.Series["Meslek-Maas"].Points.AddXY(dr2[0], dr2[1]);
            }

            baglantı.Close();



        }
    }
}
