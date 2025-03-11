namespace FormControll
{
    partial class RegisForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelNama = new Label();
            textBox1 = new TextBox();
            labelBahasaProgram = new Label();
            comboBoxBahasaPemrograman = new ComboBox();
            labelPilihHariKursus = new Label();
            seninRabu = new RadioButton();
            selasaKamis = new RadioButton();
            jumatSabtu = new RadioButton();
            radioButtonPerempuan = new RadioButton();
            radioButtonLakilaki = new RadioButton();
            labelPilihKelamin = new Label();
            groupBoxJenisKelamin = new GroupBox();
            groupBoxJenisKelamin.SuspendLayout();
            SuspendLayout();
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Font = new Font("Segoe UI", 9F);
            labelNama.Location = new Point(52, 83);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(77, 32);
            labelNama.TabIndex = 0;
            labelNama.Text = "Nama";
            labelNama.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(415, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(487, 39);
            textBox1.TabIndex = 1;
            // 
            // labelBahasaProgram
            // 
            labelBahasaProgram.AutoSize = true;
            labelBahasaProgram.Font = new Font("Segoe UI", 9F);
            labelBahasaProgram.Location = new Point(52, 163);
            labelBahasaProgram.Name = "labelBahasaProgram";
            labelBahasaProgram.Size = new Size(296, 32);
            labelBahasaProgram.TabIndex = 2;
            labelBahasaProgram.Text = "Pilih Bahasa Pemrograman";
            // 
            // comboBoxBahasaPemrograman
            // 
            comboBoxBahasaPemrograman.FormattingEnabled = true;
            comboBoxBahasaPemrograman.Items.AddRange(new object[] { "C#", "Java", "JavaScript", "TypeScript", "Python", "C++", "C", "Pascal", "Ruby", "PHP" });
            comboBoxBahasaPemrograman.Location = new Point(415, 163);
            comboBoxBahasaPemrograman.Name = "comboBoxBahasaPemrograman";
            comboBoxBahasaPemrograman.Size = new Size(487, 40);
            comboBoxBahasaPemrograman.TabIndex = 3;
            // 
            // labelPilihHariKursus
            // 
            labelPilihHariKursus.AutoSize = true;
            labelPilihHariKursus.Font = new Font("Segoe UI", 9F);
            labelPilihHariKursus.Location = new Point(52, 265);
            labelPilihHariKursus.Name = "labelPilihHariKursus";
            labelPilihHariKursus.Size = new Size(186, 32);
            labelPilihHariKursus.TabIndex = 4;
            labelPilihHariKursus.Text = "Pilih Hari Kursus";
            // 
            // seninRabu
            // 
            seninRabu.AutoSize = true;
            seninRabu.Location = new Point(415, 261);
            seninRabu.Name = "seninRabu";
            seninRabu.Size = new Size(183, 36);
            seninRabu.TabIndex = 5;
            seninRabu.TabStop = true;
            seninRabu.Text = "Senin - Rabu";
            seninRabu.UseVisualStyleBackColor = true;
            // 
            // selasaKamis
            // 
            selasaKamis.AutoSize = true;
            selasaKamis.Location = new Point(415, 317);
            selasaKamis.Name = "selasaKamis";
            selasaKamis.Size = new Size(198, 36);
            selasaKamis.TabIndex = 6;
            selasaKamis.TabStop = true;
            selasaKamis.Text = "Selasa - Kamis";
            selasaKamis.UseVisualStyleBackColor = true;
            // 
            // jumatSabtu
            // 
            jumatSabtu.AutoSize = true;
            jumatSabtu.Location = new Point(415, 373);
            jumatSabtu.Name = "jumatSabtu";
            jumatSabtu.Size = new Size(194, 36);
            jumatSabtu.TabIndex = 7;
            jumatSabtu.TabStop = true;
            jumatSabtu.Text = "Jumat - Sabtu";
            jumatSabtu.UseVisualStyleBackColor = true;
            // 
            // radioButtonPerempuan
            // 
            radioButtonPerempuan.AutoSize = true;
            radioButtonPerempuan.Location = new Point(9, 71);
            radioButtonPerempuan.Name = "radioButtonPerempuan";
            radioButtonPerempuan.Size = new Size(166, 36);
            radioButtonPerempuan.TabIndex = 10;
            radioButtonPerempuan.TabStop = true;
            radioButtonPerempuan.Text = "Perempuan";
            radioButtonPerempuan.UseVisualStyleBackColor = true;
            radioButtonPerempuan.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButtonLakilaki
            // 
            radioButtonLakilaki.AutoSize = true;
            radioButtonLakilaki.Location = new Point(9, 29);
            radioButtonLakilaki.Name = "radioButtonLakilaki";
            radioButtonLakilaki.Size = new Size(146, 36);
            radioButtonLakilaki.TabIndex = 9;
            radioButtonLakilaki.TabStop = true;
            radioButtonLakilaki.Text = "Laki - laki";
            radioButtonLakilaki.UseVisualStyleBackColor = true;
            radioButtonLakilaki.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // labelPilihKelamin
            // 
            labelPilihKelamin.AutoSize = true;
            labelPilihKelamin.Font = new Font("Segoe UI", 9F);
            labelPilihKelamin.Location = new Point(52, 458);
            labelPilihKelamin.Name = "labelPilihKelamin";
            labelPilihKelamin.Size = new Size(211, 32);
            labelPilihKelamin.TabIndex = 8;
            labelPilihKelamin.Text = "Pilih Jenis Kelamin";
            // 
            // groupBoxJenisKelamin
            // 
            groupBoxJenisKelamin.Controls.Add(radioButtonPerempuan);
            groupBoxJenisKelamin.Controls.Add(radioButtonLakilaki);
            groupBoxJenisKelamin.Location = new Point(402, 415);
            groupBoxJenisKelamin.Name = "groupBoxJenisKelamin";
            groupBoxJenisKelamin.Size = new Size(400, 121);
            groupBoxJenisKelamin.TabIndex = 11;
            groupBoxJenisKelamin.TabStop = false;
            // 
            // RegisForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 1429);
            Controls.Add(groupBoxJenisKelamin);
            Controls.Add(labelPilihKelamin);
            Controls.Add(jumatSabtu);
            Controls.Add(selasaKamis);
            Controls.Add(seninRabu);
            Controls.Add(labelPilihHariKursus);
            Controls.Add(comboBoxBahasaPemrograman);
            Controls.Add(labelBahasaProgram);
            Controls.Add(textBox1);
            Controls.Add(labelNama);
            Name = "RegisForm";
            Text = "Form Pendaftaran Kursus";
            groupBoxJenisKelamin.ResumeLayout(false);
            groupBoxJenisKelamin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNama;
        private TextBox textBox1;
        private Label labelBahasaProgram;
        private ComboBox comboBoxBahasaPemrograman;
        private Label labelPilihHariKursus;
        private RadioButton seninRabu;
        private RadioButton selasaKamis;
        private RadioButton jumatSabtu;
        private RadioButton radioButtonPerempuan;
        private RadioButton radioButtonLakilaki;
        private Label labelPilihKelamin;
        private GroupBox groupBoxJenisKelamin;
    }
}