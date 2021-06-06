namespace erp_uygulama
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_1ara = new System.Windows.Forms.TextBox();
            this.button_ara = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1_kaydet = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_prsnlsil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1187, 69);
            this.label1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(748, 268);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox_1ara
            // 
            this.textBox_1ara.Location = new System.Drawing.Point(49, 96);
            this.textBox_1ara.Name = "textBox_1ara";
            this.textBox_1ara.Size = new System.Drawing.Size(206, 22);
            this.textBox_1ara.TabIndex = 4;
            // 
            // button_ara
            // 
            this.button_ara.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.button_ara.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ara.Location = new System.Drawing.Point(296, 85);
            this.button_ara.Name = "button_ara";
            this.button_ara.Size = new System.Drawing.Size(161, 40);
            this.button_ara.TabIndex = 34;
            this.button_ara.Text = "Ara";
            this.button_ara.UseVisualStyleBackColor = true;
            this.button_ara.Click += new System.EventHandler(this.button_ara_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(868, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 30);
            this.label5.TabIndex = 37;
            this.label5.Text = "Personel Ekle/Düzenle";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(762, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 30);
            this.label2.TabIndex = 44;
            this.label2.Text = "Bölüm id";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(766, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 30);
            this.label3.TabIndex = 43;
            this.label3.Text = "Ad Soyad";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(770, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 30);
            this.label4.TabIndex = 38;
            this.label4.Text = "Yaş";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(925, 328);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(198, 22);
            this.textBox4.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(774, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 30);
            this.label6.TabIndex = 39;
            this.label6.Text = "Maaş";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(925, 290);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(198, 22);
            this.textBox3.TabIndex = 41;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(925, 250);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 22);
            this.textBox2.TabIndex = 40;
            // 
            // button1_kaydet
            // 
            this.button1_kaydet.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.button1_kaydet.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1_kaydet.Location = new System.Drawing.Point(872, 388);
            this.button1_kaydet.Name = "button1_kaydet";
            this.button1_kaydet.Size = new System.Drawing.Size(161, 40);
            this.button1_kaydet.TabIndex = 46;
            this.button1_kaydet.Text = "Kaydet";
            this.button1_kaydet.UseVisualStyleBackColor = true;
            this.button1_kaydet.Click += new System.EventHandler(this.button1_kaydet_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CNC",
            "Kaynak",
            "Elektrik",
            "Cam",
            "Havuz",
            "Sevkiyat",
            "Satın Alma",
            "Pazarlama",
            "Muhasebe",
            "Sekreter"});
            this.comboBox1.Location = new System.Drawing.Point(925, 205);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 24);
            this.comboBox1.TabIndex = 47;
            // 
            // button_prsnlsil
            // 
            this.button_prsnlsil.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.button_prsnlsil.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_prsnlsil.Location = new System.Drawing.Point(63, 463);
            this.button_prsnlsil.Name = "button_prsnlsil";
            this.button_prsnlsil.Size = new System.Drawing.Size(161, 40);
            this.button_prsnlsil.TabIndex = 48;
            this.button_prsnlsil.Text = "Personeli Sil";
            this.button_prsnlsil.UseVisualStyleBackColor = true;
            this.button_prsnlsil.Click += new System.EventHandler(this.button_prsnlsil_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.button_prsnlsil);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1_kaydet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_ara);
            this.Controls.Add(this.textBox_1ara);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Personeller";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_1ara;
        private System.Windows.Forms.Button button_ara;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1_kaydet;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_prsnlsil;
    }
}