namespace Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.textBoxpass = new System.Windows.Forms.TextBox();
            this.btsimpan = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.bthapus = new System.Windows.Forms.Button();
            this.btclear = new System.Windows.Forms.Button();
            this.comboBoxkat = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kategori";
            // 
            // textBoxusername
            // 
            this.textBoxusername.Location = new System.Drawing.Point(254, 61);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(161, 26);
            this.textBoxusername.TabIndex = 3;
            // 
            // textBoxpass
            // 
            this.textBoxpass.Location = new System.Drawing.Point(254, 128);
            this.textBoxpass.Name = "textBoxpass";
            this.textBoxpass.Size = new System.Drawing.Size(161, 26);
            this.textBoxpass.TabIndex = 4;
            // 
            // btsimpan
            // 
            this.btsimpan.Location = new System.Drawing.Point(512, 63);
            this.btsimpan.Name = "btsimpan";
            this.btsimpan.Size = new System.Drawing.Size(75, 23);
            this.btsimpan.TabIndex = 6;
            this.btsimpan.Text = "Simpan";
            this.btsimpan.UseVisualStyleBackColor = true;
            this.btsimpan.Click += new System.EventHandler(this.btsimpan_Click);
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(512, 124);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(75, 23);
            this.btupdate.TabIndex = 7;
            this.btupdate.Text = "Update";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // bthapus
            // 
            this.bthapus.Location = new System.Drawing.Point(512, 175);
            this.bthapus.Name = "bthapus";
            this.bthapus.Size = new System.Drawing.Size(75, 23);
            this.bthapus.TabIndex = 8;
            this.bthapus.Text = "Hapus";
            this.bthapus.UseVisualStyleBackColor = true;
            this.bthapus.Click += new System.EventHandler(this.bthapus_Click);
            // 
            // btclear
            // 
            this.btclear.Location = new System.Drawing.Point(512, 224);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(75, 23);
            this.btclear.TabIndex = 9;
            this.btclear.Text = "Clear";
            this.btclear.UseVisualStyleBackColor = true;
            this.btclear.Click += new System.EventHandler(this.btclear_Click);
            // 
            // comboBoxkat
            // 
            this.comboBoxkat.FormattingEnabled = true;
            this.comboBoxkat.Location = new System.Drawing.Point(254, 211);
            this.comboBoxkat.Name = "comboBoxkat";
            this.comboBoxkat.Size = new System.Drawing.Size(161, 28);
            this.comboBoxkat.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(709, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxkat);
            this.Controls.Add(this.btclear);
            this.Controls.Add(this.bthapus);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.btsimpan);
            this.Controls.Add(this.textBoxpass);
            this.Controls.Add(this.textBoxusername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.TextBox textBoxpass;
        private System.Windows.Forms.Button btsimpan;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button bthapus;
        private System.Windows.Forms.Button btclear;
        private System.Windows.Forms.ComboBox comboBoxkat;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

