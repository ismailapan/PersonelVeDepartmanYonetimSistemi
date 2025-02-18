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
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace NKatmanliMimari
{
    public partial class FrmEkle : Form
    {
        public FrmEkle()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show
                (
                  "PERSONEL KAYDI YAPMAYI ONAYLIYOR MUSUNUZ ?","ONAY",MessageBoxButtons.YesNo,MessageBoxIcon.Warning
                );
            if (result == DialogResult.Yes)
            {
                PerEkle();
                MessageBox.Show("Personel Kaydı Tamamlandı","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Personel Kayıt Yapılmadı","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
           
        }
        private void PerEkle()
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad = textBox1.Text;
            ent.Soyad = textBox2.Text;
            ent.Sehir = textBox3.Text;
            ent.Gorev = textBox4.Text;
            ent.Maas = decimal.Parse(textBox5.Text);
            LogicPersonel.LLPersonelEkle(ent);
        }
    }
}
