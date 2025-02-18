using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace NKatmanliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> perlist = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = perlist;

            dataGridView1.Columns["Id"].HeaderText = "Sicil No";
            dataGridView1.Columns["AD"].HeaderText = "Personel Adı";
            dataGridView1.Columns["SOYAD"].HeaderText = "Personel Soyadı";
            dataGridView1.Columns["SEHIR"].HeaderText = "İkame Şehir";
            dataGridView1.Columns["GOREV"].HeaderText = "Departman";
            dataGridView1.Columns["MAAS"].HeaderText = "Maaşı";

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmEkle fr = new FrmEkle();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EntityPersonel personel = new EntityPersonel();
            personel.Id = Convert.ToInt32(textBox1.Text);
            LogicPersonel.LLPersonelSil(personel.Id);
            MessageBox.Show("Seçilen personle silindi","BİLGİ",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EntityPersonel per = new EntityPersonel();
            per.Id = Convert.ToInt32(textBox1.Text) ;
            per.Ad=textBox2.Text;
            per.Soyad=textBox3.Text;
            per.Gorev=textBox4.Text;
            per.Sehir=textBox5.Text;
            per.Maas = decimal.Parse(textBox6.Text);
            LogicPersonel.LLPersonelGuncel(per);
            MessageBox.Show("Seçilen personel bilgileri güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmDepartcs frm = new FrmDepartcs();
            frm.Show();
        }
    }
}
