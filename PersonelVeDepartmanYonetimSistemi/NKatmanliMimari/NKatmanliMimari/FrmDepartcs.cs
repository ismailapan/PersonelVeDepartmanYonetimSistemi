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
    public partial class FrmDepartcs : Form
    {
        public FrmDepartcs()
        {
            InitializeComponent();
        }

        

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex; // Seçilen satırın indexini al

            // Hangi sütundaki değeri alacağını belirle (Örneğin: "department_gorev" sütunu)
            object cellValue = dataGridView1.Rows[secilen].Cells[2].Value; // 2. sütun, "department_gorev"
            // Null kontrolü yaparak hata önle
            richTextBox1.Text = "İş Tanımı: " + (cellValue != null ? cellValue.ToString() : "Veri bulunamadı!");
            textBox2.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox1.Text= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<EntityDepartment> deplist = LogicDepart.LLDepartmentList();
            dataGridView1.DataSource = deplist;

            dataGridView1.Columns["department_id"].HeaderText = "Departman No";
            dataGridView1.Columns["department_name"].HeaderText = "Departman Adı";
            dataGridView1.Columns["department_task"].HeaderText = "Açıklama";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EntityDepartment ent = new EntityDepartment();
            ent.Department_name = textBox1.Text;
            ent.Department_task = richTextBox2.Text;
            LogicDepart.LLDepartmentEkle(ent);
            MessageBox.Show("Seçilen departman kaydedildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EntityDepartment d1 = new EntityDepartment();
            d1.Department_id = Convert.ToInt32(textBox2.Text);
            LogicDepart.LLDepartmentSil(d1.Department_id);
            MessageBox.Show("Seçilen departman kaydı silindi","BİLGİ",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EntityDepartment d2 = new EntityDepartment();
            d2.Department_id = Convert.ToInt32(textBox2.Text);
            d2.Department_name=textBox1.Text;
            d2.Department_task = richTextBox2.Text;
            LogicDepart.LLDepartmentGuncel(d2 );
            MessageBox.Show("Seçilen departman kaydı güncellendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
