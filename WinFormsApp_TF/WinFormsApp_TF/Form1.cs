using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace WinFormsApp_TF
{
    public partial class Form1 : Form
    {
        VtContext veriler = new VtContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci yeni_ogr = new Ogrenci();
            yeni_ogr.OkulNo = Int32.Parse(textBoxokulno.Text);
            yeni_ogr.Ad = textBoxad.Text;
            yeni_ogr.Soyad = textBoxsoyad.Text;

            veriler.Ogrencilwe.Add(yeni_ogr);
            veriler.SaveChanges();



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            veriler.Ogrencilwe.Load();
            dataGridView1.DataSource = veriler.Ogrencilwe.Local.ToBindingList();
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

            btn.HeaderText = "Kayýt Sil";
            btn.Name = "Buton";
            btn.Text = "Sil";
            btn.UseColumnTextForButtonValue = true;
            btn.DefaultCellStyle.BackColor= Color.DarkRed;
            dataGridView1.Columns.Add(btn);

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Buton")
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                MessageBox.Show(Text = "Kaydý Baþarýyla Sildiniz.");
                veriler.SaveChanges();
             
            }
        }
    }
}