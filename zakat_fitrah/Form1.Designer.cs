namespace zakat_fitrah
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_ubah = new System.Windows.Forms.Button();
            this.button_batal = new System.Windows.Forms.Button();
            this.button_simpan = new System.Windows.Forms.Button();
            this.button_hapus = new System.Windows.Forms.Button();
            this.button_total = new System.Windows.Forms.Button();
            this.textbox_id = new System.Windows.Forms.TextBox();
            this.textbox_nama = new System.Windows.Forms.TextBox();
            this.textbox_jiwa = new System.Windows.Forms.TextBox();
            this.textbox_beras = new System.Windows.Forms.TextBox();
            this.textbox_nik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textbox_total = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textbox_username = new System.Windows.Forms.TextBox();
            this.textbox_password = new System.Windows.Forms.TextBox();
            this.textbox_cariid = new System.Windows.Forms.TextBox();
            this.button_admin = new System.Windows.Forms.Button();
            this.button_cariid = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ubah
            // 
            this.button_ubah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ubah.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ubah.ForeColor = System.Drawing.Color.Navy;
            this.button_ubah.Location = new System.Drawing.Point(47, 530);
            this.button_ubah.Name = "button_ubah";
            this.button_ubah.Size = new System.Drawing.Size(134, 39);
            this.button_ubah.TabIndex = 0;
            this.button_ubah.Text = "Ubah";
            this.button_ubah.UseVisualStyleBackColor = true;
            this.button_ubah.Click += new System.EventHandler(this.button_ubah_Click);
            // 
            // button_batal
            // 
            this.button_batal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_batal.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_batal.ForeColor = System.Drawing.Color.Navy;
            this.button_batal.Location = new System.Drawing.Point(196, 530);
            this.button_batal.Name = "button_batal";
            this.button_batal.Size = new System.Drawing.Size(134, 39);
            this.button_batal.TabIndex = 1;
            this.button_batal.Text = "Batal";
            this.button_batal.UseVisualStyleBackColor = true;
            this.button_batal.Click += new System.EventHandler(this.button_batal_Click);
            // 
            // button_simpan
            // 
            this.button_simpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_simpan.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_simpan.ForeColor = System.Drawing.Color.Navy;
            this.button_simpan.Location = new System.Drawing.Point(47, 577);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(134, 39);
            this.button_simpan.TabIndex = 2;
            this.button_simpan.Text = "Simpan";
            this.button_simpan.UseVisualStyleBackColor = true;
            this.button_simpan.Click += new System.EventHandler(this.button_simpan_Click);
            // 
            // button_hapus
            // 
            this.button_hapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_hapus.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hapus.ForeColor = System.Drawing.Color.Navy;
            this.button_hapus.Location = new System.Drawing.Point(196, 577);
            this.button_hapus.Name = "button_hapus";
            this.button_hapus.Size = new System.Drawing.Size(134, 39);
            this.button_hapus.TabIndex = 3;
            this.button_hapus.Text = "Hapus";
            this.button_hapus.UseVisualStyleBackColor = true;
            this.button_hapus.Click += new System.EventHandler(this.button_hapus_Click);
            // 
            // button_total
            // 
            this.button_total.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_total.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_total.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_total.ForeColor = System.Drawing.Color.Navy;
            this.button_total.Location = new System.Drawing.Point(351, 530);
            this.button_total.Name = "button_total";
            this.button_total.Size = new System.Drawing.Size(134, 86);
            this.button_total.TabIndex = 4;
            this.button_total.Text = "Cek Total";
            this.button_total.UseVisualStyleBackColor = true;
            this.button_total.Click += new System.EventHandler(this.button_total_Click);
            // 
            // textbox_id
            // 
            this.textbox_id.Location = new System.Drawing.Point(196, 118);
            this.textbox_id.Name = "textbox_id";
            this.textbox_id.Size = new System.Drawing.Size(185, 26);
            this.textbox_id.TabIndex = 5;
            // 
            // textbox_nama
            // 
            this.textbox_nama.Location = new System.Drawing.Point(196, 230);
            this.textbox_nama.Name = "textbox_nama";
            this.textbox_nama.Size = new System.Drawing.Size(185, 26);
            this.textbox_nama.TabIndex = 6;
            // 
            // textbox_jiwa
            // 
            this.textbox_jiwa.Location = new System.Drawing.Point(196, 286);
            this.textbox_jiwa.Name = "textbox_jiwa";
            this.textbox_jiwa.Size = new System.Drawing.Size(185, 26);
            this.textbox_jiwa.TabIndex = 7;
            // 
            // textbox_beras
            // 
            this.textbox_beras.Location = new System.Drawing.Point(196, 345);
            this.textbox_beras.Name = "textbox_beras";
            this.textbox_beras.Size = new System.Drawing.Size(185, 26);
            this.textbox_beras.TabIndex = 8;
            // 
            // textbox_nik
            // 
            this.textbox_nik.Location = new System.Drawing.Point(196, 172);
            this.textbox_nik.Name = "textbox_nik";
            this.textbox_nik.Size = new System.Drawing.Size(185, 26);
            this.textbox_nik.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(66, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(66, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "NIK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(66, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(66, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Jumlah Jiwa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(66, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Jenis Beras";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(66, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total";
            // 
            // textbox_total
            // 
            this.textbox_total.Location = new System.Drawing.Point(196, 400);
            this.textbox_total.Name = "textbox_total";
            this.textbox_total.Size = new System.Drawing.Size(185, 26);
            this.textbox_total.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(449, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1117, 376);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Humnst777 BlkCn BT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(196, 457);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(185, 26);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(66, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tanggal";
            // 
            // textbox_username
            // 
            this.textbox_username.Location = new System.Drawing.Point(676, 536);
            this.textbox_username.Name = "textbox_username";
            this.textbox_username.Size = new System.Drawing.Size(146, 26);
            this.textbox_username.TabIndex = 20;
            this.textbox_username.TextChanged += new System.EventHandler(this.textbox_username_TextChanged);
            // 
            // textbox_password
            // 
            this.textbox_password.Location = new System.Drawing.Point(859, 536);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.Size = new System.Drawing.Size(146, 26);
            this.textbox_password.TabIndex = 21;
            // 
            // textbox_cariid
            // 
            this.textbox_cariid.Location = new System.Drawing.Point(515, 530);
            this.textbox_cariid.Name = "textbox_cariid";
            this.textbox_cariid.Size = new System.Drawing.Size(136, 26);
            this.textbox_cariid.TabIndex = 23;
            // 
            // button_admin
            // 
            this.button_admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_admin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_admin.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_admin.ForeColor = System.Drawing.Color.Navy;
            this.button_admin.Location = new System.Drawing.Point(676, 577);
            this.button_admin.Name = "button_admin";
            this.button_admin.Size = new System.Drawing.Size(329, 39);
            this.button_admin.TabIndex = 22;
            this.button_admin.Text = "Tambahkan Admin";
            this.button_admin.UseVisualStyleBackColor = true;
            this.button_admin.Click += new System.EventHandler(this.button_admin_Click);
            // 
            // button_cariid
            // 
            this.button_cariid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_cariid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_cariid.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cariid.ForeColor = System.Drawing.Color.Navy;
            this.button_cariid.Location = new System.Drawing.Point(515, 577);
            this.button_cariid.Name = "button_cariid";
            this.button_cariid.Size = new System.Drawing.Size(136, 39);
            this.button_cariid.TabIndex = 24;
            this.button_cariid.Text = "Cari ID";
            this.button_cariid.UseVisualStyleBackColor = true;
            this.button_cariid.Click += new System.EventHandler(this.button_cariid_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Humnst777 Blk BT", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(1439, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 49);
            this.button1.TabIndex = 25;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Navy;
            this.label8.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(712, 508);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Username";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Navy;
            this.label9.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(898, 508);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Impact", 28F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(740, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(324, 70);
            this.label10.TabIndex = 28;
            this.label10.Text = "ZAKAT FITRAH";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(614, 707);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(541, 29);
            this.label11.TabIndex = 29;
            this.label11.Text = "Copyright © Tugas UTS Zakat Fitrah //Tedi & Kawan-Kawan//";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1650, 760);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_cariid);
            this.Controls.Add(this.textbox_cariid);
            this.Controls.Add(this.button_admin);
            this.Controls.Add(this.textbox_password);
            this.Controls.Add(this.textbox_username);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textbox_total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_nik);
            this.Controls.Add(this.textbox_beras);
            this.Controls.Add(this.textbox_jiwa);
            this.Controls.Add(this.textbox_nama);
            this.Controls.Add(this.textbox_id);
            this.Controls.Add(this.button_total);
            this.Controls.Add(this.button_hapus);
            this.Controls.Add(this.button_simpan);
            this.Controls.Add(this.button_batal);
            this.Controls.Add(this.button_ubah);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1676, 820);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zakat Fitrah";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ubah;
        private System.Windows.Forms.Button button_batal;
        private System.Windows.Forms.Button button_simpan;
        private System.Windows.Forms.Button button_hapus;
        private System.Windows.Forms.Button button_total;
        private System.Windows.Forms.TextBox textbox_id;
        private System.Windows.Forms.TextBox textbox_nama;
        private System.Windows.Forms.TextBox textbox_jiwa;
        private System.Windows.Forms.TextBox textbox_beras;
        private System.Windows.Forms.TextBox textbox_nik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbox_total;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textbox_username;
        private System.Windows.Forms.TextBox textbox_password;
        private System.Windows.Forms.TextBox textbox_cariid;
        private System.Windows.Forms.Button button_admin;
        private System.Windows.Forms.Button button_cariid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

