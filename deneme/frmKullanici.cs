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

namespace deneme
{
    public partial class frmKullanici : Form
    {
        SqlConnection baglanti = new SqlConnection(@"data source = DESKTOP-K72V513;database = rezervasyon;integrated security= True");

        public frmKullanici()
        {
            InitializeComponent();
        }

        private void frmKullanici_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_listele_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "select rezervasyonID as 'No',rUlasim as 'Ulasim',rKonaklama as 'Konaklama',baslangicTarihi as 'Baslangic Tarihi',bitisTarihi as 'Bitis Tarihi',lokasyon as 'Lokasyon', ücret as 'Rezervasyon Ücreti ($)' from rCesitleri where baslangicTarihi >= @tarih1 and bitisTarihi <= @tarih2 and lokasyon = @lokasyon";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, baglanti);
            adapter.SelectCommand.Parameters.AddWithValue("@tarih1", dtp_rbaslangic.Value);
            adapter.SelectCommand.Parameters.AddWithValue("@tarih2", dtp_rbitis.Value);
            adapter.SelectCommand.Parameters.AddWithValue("@lokasyon",txt_lokasyon.Text);
            baglanti.Open();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void btn_rezervasyonyap_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                string ulasim = Convert.ToString(drow.Cells[1].Value);
                string konaklama = Convert.ToString(drow.Cells[2].Value);
                DateTime baslangic = Convert.ToDateTime(drow.Cells[3].Value);
                DateTime bitis = Convert.ToDateTime(drow.Cells[4].Value);
                string lokasyon = Convert.ToString(drow.Cells[5].Value);
                string ücret = Convert.ToString(drow.Cells[6].Value);


                SqlCommand komut = new SqlCommand("insert into ryapilan(konaklama,ulasim,tbaslangic,tbitis,kullaniciıd,lokasyon,ücret) values (@konaklama,@ulasim,@baslangic,@bitis,@kullaniciıd,@lokasyon,@ücret)", baglanti);
                komut.Parameters.AddWithValue("@konaklama", konaklama);
                komut.Parameters.AddWithValue("@ulasim", ulasim);
                komut.Parameters.AddWithValue("@baslangic", baslangic);
                komut.Parameters.AddWithValue("@bitis", bitis);
                komut.Parameters.AddWithValue("@kullaniciıd", txt_mno.Text);
                komut.Parameters.AddWithValue("@lokasyon", lokasyon);
                komut.Parameters.AddWithValue("@ücret", ücret);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();

            }
            frmÖdeme frmÖdeme = new frmÖdeme();
            frmÖdeme.ShowDialog();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void btn_rgöster_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql = "select ID as 'No',Ulasim as 'Ulasim',Konaklama as 'Konaklama',tBaslangic as 'Baslangic Tarihi',tBitis as 'Bitis Tarihi',Lokasyon as 'Lokasyon', Ücret as 'Rezervasyon Ücreti ($)' from rYapilan where kullaniciID = @kullaniciID";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, baglanti);
            adapter.SelectCommand.Parameters.AddWithValue("@kullaniciID", txt_mno2.Text);

            baglanti.Open();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
            baglanti.Close();
        }

        private void btn_konaklamaiptal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ulaşım da iptal edilsin mi", "Silme Onaylama!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 
            {
                foreach (DataGridViewRow drow in dataGridView2.SelectedRows)
                {
                    int numara = Convert.ToInt32(drow.Cells[0].Value);
                    SqlCommand komut = new SqlCommand("delete from rYapilan where ID = @id",baglanti);
                    komut.Parameters.AddWithValue("@id", numara);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }

              
            }
            else
            {
                foreach (DataGridViewRow drow in dataGridView2.SelectedRows)
                {
                    int numara = Convert.ToInt32(drow.Cells[0].Value);
                    string konaklama = "IPTAL";
                    SqlCommand komut = new SqlCommand("update rYapilan set Konaklama = @konaklama where ID = @id", baglanti);
                    
                    komut.Parameters.AddWithValue("@konaklama",konaklama);
                    komut.Parameters.AddWithValue("@id", numara);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    
                }
                
            }

        }

        private void btn_ulasimiptal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Konaklam da iptal edilsin mi", "Silme Onaylama!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                foreach (DataGridViewRow drow in dataGridView2.SelectedRows)
                {
                    int numara = Convert.ToInt32(drow.Cells[0].Value);
                    SqlCommand komut = new SqlCommand("delete from rYapilan where ID = @id", baglanti);
                    komut.Parameters.AddWithValue("@id", numara);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }

            }
            else
            {
                foreach (DataGridViewRow drow in dataGridView2.SelectedRows)
                {
                    int numara = Convert.ToInt32(drow.Cells[0].Value);
                    string ulasim = "IPTAL";
                    SqlCommand komut = new SqlCommand("update rYapilan set ulasim = @ulasim where ID = @id", baglanti);

                    komut.Parameters.AddWithValue("@ulasim", ulasim);
                    komut.Parameters.AddWithValue("@id", numara);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                }
            }
        }

        private void btn_kcikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGiris frmGiris = new frmGiris();
            frmGiris.ShowDialog();
        }

        private void btn_kcikis2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGiris frmGiris = new frmGiris();
            frmGiris.ShowDialog();
        }
    }
}
