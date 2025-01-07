using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Data;
using System.Drawing;
using System.Security.Policy;

namespace emlak
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        Boolean girisli = false;
        String girismail = "";

        public Form1()
        {
            InitializeComponent();
            string connectionString = "Server=localhost;Database=emlak;Uid=root;Pwd=;";
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VeriGetir("select * from houses");
        }

        void VeriGetir(string sql)
        {
            dt = new DataTable();
            adapter = new MySqlDataAdapter(sql, conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                MySqlCommand cmdconverter = new MySqlCommand("select * from users where email='" + dr.Cells[1].Value.ToString() + "'", conn);
                MySqlDataReader readerconverter = cmdconverter.ExecuteReader();
                while (readerconverter.Read())
                {
                    dr.Cells[1].Value = readerconverter["name"].ToString();
                }
                readerconverter.Close();
            }

            if (kategoriCombo.Items.Count == 0)
            {
                MySqlCommand cmd = new MySqlCommand("select * from houses", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    kategoriCombo.Items.Add(reader["kategori"]);
                    ilCombo.Items.Add(reader["sehir"]);
                    ilceCombo.Items.Add(reader["ilce"]);
                    metreCombo.Items.Add(reader["metrekare"]);
                }
                reader.Close();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (girisli)
            {
                groupBox2.Enabled = false;
                cikisyapBtn.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = true;
                cikisyapBtn.Enabled = false;
            }
        }

        private void girisyapBtn_Click(object sender, EventArgs e)
        {
            string kadi, sifre;

            if (kadiText1.Text != "")
            {
                kadi = kadiText1.Text;
            }
            else
            {
                MessageBox.Show("Kullanıcı adı boş olmamalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (sifreText1.Text != "")
            {
                sifre = sifreText1.Text;
            }
            else
            {
                MessageBox.Show("Şifre boş olmamalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MySqlCommand cmd = new MySqlCommand("select * from users where name = '" + kadi + "' AND password = '" + sifre + "'", conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Başarıyla giriş yapıldı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kadiText1.Text = string.Empty;
                sifreText1.Text = string.Empty;
                groupBox2.Enabled = false;
                cikisyapBtn.Enabled = true;
                girisli = true;
                girismail = reader["email"].ToString();
                girisEmojiText.Text = "✅";
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve şifre eşleşmiyor!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            kadiText1.Text = string.Empty;
            sifreText1.Text = string.Empty;
            reader.Close();
            cmd.Dispose();
        }

        private void cikisyapBtn_Click(object sender, EventArgs e)
        {
            girisli = false;
            tabControl1.SelectedIndex = 0;
            girismail = "";
        }

        private void filtreUygulaBtn_Click(object sender, EventArgs e)
        {
            string sql = $"select * from houses where kategori='{kategoriCombo.Text}' OR sehir='{ilCombo.Text}' OR ilce='{ilceCombo.Text}' OR metrekare='{metreCombo.Text}'";
            if (kendiİlanCheck.Checked == true && !girisli) MessageBox.Show("Giriş yapmadan kendi ilanlarınızı gösteri seçemezsiniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (kendiİlanCheck.Checked == false && kategoriCombo.Text == "" && ilCombo.Text == "" && ilceCombo.Text == "" && metreCombo.Text == "") VeriGetir("select * from houses");
            else if (kendiİlanCheck.Checked == true)
            {
                VeriGetir($"select * from houses where user='{girismail}'");
            }
            else if (kendiİlanCheck.Checked == false)
            {
                VeriGetir(sql);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tilansahibi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tkategori.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbaslik.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            taciklama.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            tfiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            tmetre.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            til.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            tilce.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            ttarih.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            tadres.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
        }
    }
}
