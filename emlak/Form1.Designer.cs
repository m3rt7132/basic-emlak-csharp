namespace emlak
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox3 = new GroupBox();
            tadres = new TextBox();
            label18 = new Label();
            ttarih = new TextBox();
            label17 = new Label();
            tilce = new TextBox();
            label16 = new Label();
            til = new TextBox();
            label15 = new Label();
            tmetre = new TextBox();
            label14 = new Label();
            tfiyat = new TextBox();
            label13 = new Label();
            taciklama = new TextBox();
            label12 = new Label();
            tbaslik = new TextBox();
            label11 = new Label();
            tkategori = new TextBox();
            label10 = new Label();
            tilansahibi = new TextBox();
            label5 = new Label();
            girisEmojiText = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            filtreUygulaBtn = new Button();
            kendiİlanCheck = new CheckBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            metreCombo = new ComboBox();
            ilceCombo = new ComboBox();
            ilCombo = new ComboBox();
            label2 = new Label();
            kategoriCombo = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            cikisyapBtn = new Button();
            groupBox2 = new GroupBox();
            girisyapBtn = new Button();
            sifreText1 = new TextBox();
            label9 = new Label();
            kadiText1 = new TextBox();
            label8 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Bahnschrift", 14F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(842, 505);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Silver;
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(834, 469);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Bütün İlanlar";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tadres);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(ttarih);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(tilce);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(til);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(tmetre);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(tfiyat);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(taciklama);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(tbaslik);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(tkategori);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(tilansahibi);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(girisEmojiText);
            groupBox3.Controls.Add(label7);
            groupBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox3.Location = new Point(290, 184);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(538, 279);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Detay";
            // 
            // tadres
            // 
            tadres.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            tadres.Location = new Point(399, 137);
            tadres.Multiline = true;
            tadres.Name = "tadres";
            tadres.ReadOnly = true;
            tadres.Size = new Size(129, 70);
            tadres.TabIndex = 23;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(349, 141);
            label18.Name = "label18";
            label18.Size = new Size(48, 19);
            label18.TabIndex = 22;
            label18.Text = "Adres";
            // 
            // ttarih
            // 
            ttarih.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            ttarih.Location = new Point(399, 105);
            ttarih.Name = "ttarih";
            ttarih.ReadOnly = true;
            ttarih.Size = new Size(129, 27);
            ttarih.TabIndex = 21;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(349, 109);
            label17.Name = "label17";
            label17.Size = new Size(42, 19);
            label17.TabIndex = 20;
            label17.Text = "Tarih";
            // 
            // tilce
            // 
            tilce.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            tilce.Location = new Point(399, 72);
            tilce.Name = "tilce";
            tilce.ReadOnly = true;
            tilce.Size = new Size(129, 27);
            tilce.TabIndex = 19;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(349, 76);
            label16.Name = "label16";
            label16.Size = new Size(32, 19);
            label16.TabIndex = 18;
            label16.Text = "İlçe";
            // 
            // til
            // 
            til.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            til.Location = new Point(399, 39);
            til.Name = "til";
            til.ReadOnly = true;
            til.Size = new Size(129, 27);
            til.TabIndex = 17;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(349, 43);
            label15.Name = "label15";
            label15.Size = new Size(17, 19);
            label15.TabIndex = 16;
            label15.Text = "İl";
            // 
            // tmetre
            // 
            tmetre.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            tmetre.Location = new Point(94, 246);
            tmetre.Name = "tmetre";
            tmetre.ReadOnly = true;
            tmetre.Size = new Size(232, 27);
            tmetre.TabIndex = 15;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(6, 250);
            label14.Name = "label14";
            label14.Size = new Size(79, 19);
            label14.TabIndex = 14;
            label14.Text = "Metrekare";
            // 
            // tfiyat
            // 
            tfiyat.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            tfiyat.Location = new Point(94, 213);
            tfiyat.Name = "tfiyat";
            tfiyat.ReadOnly = true;
            tfiyat.Size = new Size(232, 27);
            tfiyat.TabIndex = 13;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(6, 217);
            label13.Name = "label13";
            label13.Size = new Size(41, 19);
            label13.TabIndex = 12;
            label13.Text = "Fiyat";
            // 
            // taciklama
            // 
            taciklama.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            taciklama.Location = new Point(94, 138);
            taciklama.Multiline = true;
            taciklama.Name = "taciklama";
            taciklama.ReadOnly = true;
            taciklama.Size = new Size(232, 69);
            taciklama.TabIndex = 11;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(6, 141);
            label12.Name = "label12";
            label12.Size = new Size(71, 19);
            label12.TabIndex = 10;
            label12.Text = "Açıklama";
            // 
            // tbaslik
            // 
            tbaslik.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            tbaslik.Location = new Point(94, 105);
            tbaslik.Name = "tbaslik";
            tbaslik.ReadOnly = true;
            tbaslik.Size = new Size(232, 27);
            tbaslik.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(6, 109);
            label11.Name = "label11";
            label11.Size = new Size(48, 19);
            label11.TabIndex = 8;
            label11.Text = "Başlık";
            // 
            // tkategori
            // 
            tkategori.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            tkategori.Location = new Point(94, 72);
            tkategori.Name = "tkategori";
            tkategori.ReadOnly = true;
            tkategori.Size = new Size(232, 27);
            tkategori.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(6, 76);
            label10.Name = "label10";
            label10.Size = new Size(67, 19);
            label10.TabIndex = 6;
            label10.Text = "Kategori";
            // 
            // tilansahibi
            // 
            tilansahibi.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            tilansahibi.Location = new Point(94, 39);
            tilansahibi.Name = "tilansahibi";
            tilansahibi.ReadOnly = true;
            tilansahibi.Size = new Size(232, 27);
            tilansahibi.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(6, 43);
            label5.Name = "label5";
            label5.Size = new Size(82, 19);
            label5.TabIndex = 4;
            label5.Text = "İlan Sahibi:";
            // 
            // girisEmojiText
            // 
            girisEmojiText.AutoSize = true;
            girisEmojiText.Location = new Point(502, 249);
            girisEmojiText.Name = "girisEmojiText";
            girisEmojiText.Size = new Size(31, 20);
            girisEmojiText.TabIndex = 3;
            girisEmojiText.Text = "❌";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(462, 249);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 2;
            label7.Text = "Giriş: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(filtreUygulaBtn);
            groupBox1.Controls.Add(kendiİlanCheck);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(metreCombo);
            groupBox1.Controls.Add(ilceCombo);
            groupBox1.Controls.Add(ilCombo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(kategoriCombo);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(6, 184);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(278, 279);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtreleme";
            // 
            // filtreUygulaBtn
            // 
            filtreUygulaBtn.BackColor = Color.Black;
            filtreUygulaBtn.Cursor = Cursors.Hand;
            filtreUygulaBtn.FlatAppearance.BorderSize = 2;
            filtreUygulaBtn.FlatStyle = FlatStyle.Flat;
            filtreUygulaBtn.ForeColor = Color.Turquoise;
            filtreUygulaBtn.Location = new Point(194, 234);
            filtreUygulaBtn.Name = "filtreUygulaBtn";
            filtreUygulaBtn.Size = new Size(78, 35);
            filtreUygulaBtn.TabIndex = 13;
            filtreUygulaBtn.Text = "Uygula";
            filtreUygulaBtn.UseVisualStyleBackColor = false;
            filtreUygulaBtn.Click += filtreUygulaBtn_Click;
            // 
            // kendiİlanCheck
            // 
            kendiİlanCheck.AutoSize = true;
            kendiİlanCheck.Location = new Point(173, 245);
            kendiİlanCheck.Name = "kendiİlanCheck";
            kendiİlanCheck.Size = new Size(15, 14);
            kendiİlanCheck.TabIndex = 12;
            kendiİlanCheck.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(6, 239);
            label6.Name = "label6";
            label6.Size = new Size(165, 20);
            label6.TabIndex = 11;
            label6.Text = "Kendi İlanlarımı Göster";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 175);
            label4.Name = "label4";
            label4.Size = new Size(46, 19);
            label4.TabIndex = 9;
            label4.Text = "Metre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 135);
            label3.Name = "label3";
            label3.Size = new Size(29, 19);
            label3.TabIndex = 8;
            label3.Text = "İlçe";
            // 
            // metreCombo
            // 
            metreCombo.FormattingEnabled = true;
            metreCombo.Location = new Point(96, 172);
            metreCombo.Name = "metreCombo";
            metreCombo.Size = new Size(176, 28);
            metreCombo.TabIndex = 5;
            // 
            // ilceCombo
            // 
            ilceCombo.FormattingEnabled = true;
            ilceCombo.Location = new Point(96, 132);
            ilceCombo.Name = "ilceCombo";
            ilceCombo.Size = new Size(176, 28);
            ilceCombo.TabIndex = 4;
            // 
            // ilCombo
            // 
            ilCombo.FormattingEnabled = true;
            ilCombo.Location = new Point(96, 92);
            ilCombo.Name = "ilCombo";
            ilCombo.Size = new Size(176, 28);
            ilCombo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 95);
            label2.Name = "label2";
            label2.Size = new Size(16, 19);
            label2.TabIndex = 2;
            label2.Text = "İl";
            // 
            // kategoriCombo
            // 
            kategoriCombo.FormattingEnabled = true;
            kategoriCombo.Location = new Point(96, 52);
            kategoriCombo.Name = "kategoriCombo";
            kategoriCombo.Size = new Size(176, 28);
            kategoriCombo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 55);
            label1.Name = "label1";
            label1.Size = new Size(60, 19);
            label1.TabIndex = 0;
            label1.Text = "Kategori";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Blue;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.BackgroundColor = Color.Silver;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(822, 172);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cikisyapBtn);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(834, 469);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Giriş İşlemleri";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cikisyapBtn
            // 
            cikisyapBtn.BackColor = Color.Black;
            cikisyapBtn.FlatAppearance.BorderSize = 2;
            cikisyapBtn.FlatStyle = FlatStyle.Flat;
            cikisyapBtn.ForeColor = Color.Red;
            cikisyapBtn.Location = new Point(722, 6);
            cikisyapBtn.Name = "cikisyapBtn";
            cikisyapBtn.Size = new Size(106, 46);
            cikisyapBtn.TabIndex = 3;
            cikisyapBtn.Text = "Çıkış Yap";
            cikisyapBtn.UseVisualStyleBackColor = false;
            cikisyapBtn.Click += cikisyapBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(girisyapBtn);
            groupBox2.Controls.Add(sifreText1);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(kadiText1);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(229, 111);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(328, 222);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bilgiler";
            // 
            // girisyapBtn
            // 
            girisyapBtn.BackColor = Color.Black;
            girisyapBtn.FlatAppearance.BorderSize = 2;
            girisyapBtn.FlatStyle = FlatStyle.Flat;
            girisyapBtn.ForeColor = Color.FromArgb(0, 192, 0);
            girisyapBtn.Location = new Point(204, 154);
            girisyapBtn.Name = "girisyapBtn";
            girisyapBtn.Size = new Size(93, 37);
            girisyapBtn.TabIndex = 4;
            girisyapBtn.Text = "Giriş Yap";
            girisyapBtn.UseVisualStyleBackColor = false;
            girisyapBtn.Click += girisyapBtn_Click;
            // 
            // sifreText1
            // 
            sifreText1.Location = new Point(146, 94);
            sifreText1.Name = "sifreText1";
            sifreText1.Size = new Size(151, 27);
            sifreText1.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 97);
            label9.Name = "label9";
            label9.Size = new Size(44, 19);
            label9.TabIndex = 2;
            label9.Text = "Şifre";
            // 
            // kadiText1
            // 
            kadiText1.Location = new Point(146, 42);
            kadiText1.Name = "kadiText1";
            kadiText1.Size = new Size(151, 27);
            kadiText1.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 45);
            label8.Name = "label8";
            label8.Size = new Size(99, 19);
            label8.TabIndex = 0;
            label8.Text = "Kullanıcı Adı";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(78, 78, 78);
            ClientSize = new Size(866, 529);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private ComboBox kategoriCombo;
        private Label label1;
        private Label label6;
        private Label label4;
        private Label label3;
        private ComboBox metreCombo;
        private ComboBox ilceCombo;
        private ComboBox ilCombo;
        private Label label2;
        private Button filtreUygulaBtn;
        private CheckBox kendiİlanCheck;
        private Label girisEmojiText;
        private Label label7;
        private GroupBox groupBox2;
        private Button button2;
        private Button girisyapBtn;
        private TextBox sifreText1;
        private Label label9;
        private TextBox kadiText1;
        private Label label8;
        private Button cikisyapBtn;
        private GroupBox groupBox3;
        private TextBox tfiyat;
        private Label label13;
        private TextBox taciklama;
        private Label label12;
        private TextBox tbaslik;
        private Label label11;
        private TextBox tkategori;
        private Label label10;
        private TextBox tilansahibi;
        private Label label5;
        private TextBox tadres;
        private Label label18;
        private TextBox ttarih;
        private Label label17;
        private TextBox tilce;
        private Label label16;
        private TextBox til;
        private Label label15;
        private TextBox tmetre;
        private Label label14;
    }
}
