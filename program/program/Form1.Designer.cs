namespace program
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_otworz_plik = new System.Windows.Forms.Button();
            this.dgv_huffman = new System.Windows.Forms.DataGridView();
            this.znak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czestotliwosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prawdopodobienstwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodHuffmana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakres_od = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakres_do = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_huffman = new System.Windows.Forms.Button();
            this.dgv_arytmetyczne = new System.Windows.Forms.DataGridView();
            this.znak2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czestottliwosc2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prawdopodobienstwo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakres_od2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakres_do2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_policz = new System.Windows.Forms.Button();
            this.tb_policz = new System.Windows.Forms.TextBox();
            this.dgv_info = new System.Windows.Forms.DataGridView();
            this.dgv_policz = new System.Windows.Forms.DataGridView();
            this.tb_huffman = new System.Windows.Forms.TextBox();
            this.tb_arytmetyczne = new System.Windows.Forms.TextBox();
            this.btn_arytmetyczna = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_huffman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_arytmetyczne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_policz)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_otworz_plik
            // 
            this.btn_otworz_plik.Location = new System.Drawing.Point(13, 13);
            this.btn_otworz_plik.Name = "btn_otworz_plik";
            this.btn_otworz_plik.Size = new System.Drawing.Size(249, 23);
            this.btn_otworz_plik.TabIndex = 0;
            this.btn_otworz_plik.Text = "1 :: Otwórz plik...";
            this.btn_otworz_plik.UseVisualStyleBackColor = true;
            this.btn_otworz_plik.Click += new System.EventHandler(this.btn_otworz_plik_click);
            // 
            // dgv_huffman
            // 
            this.dgv_huffman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_huffman.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.znak,
            this.czestotliwosc,
            this.prawdopodobienstwo,
            this.kodHuffmana,
            this.zakres_od,
            this.zakres_do});
            this.dgv_huffman.Location = new System.Drawing.Point(524, 43);
            this.dgv_huffman.Name = "dgv_huffman";
            this.dgv_huffman.RowHeadersVisible = false;
            this.dgv_huffman.Size = new System.Drawing.Size(250, 246);
            this.dgv_huffman.TabIndex = 2;
            // 
            // znak
            // 
            this.znak.HeaderText = "Znak";
            this.znak.MinimumWidth = 40;
            this.znak.Name = "znak";
            this.znak.Width = 40;
            // 
            // czestotliwosc
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.czestotliwosc.DefaultCellStyle = dataGridViewCellStyle1;
            this.czestotliwosc.HeaderText = "Częstotliwość";
            this.czestotliwosc.MinimumWidth = 70;
            this.czestotliwosc.Name = "czestotliwosc";
            // 
            // prawdopodobienstwo
            // 
            dataGridViewCellStyle2.Format = "N6";
            dataGridViewCellStyle2.NullValue = null;
            this.prawdopodobienstwo.DefaultCellStyle = dataGridViewCellStyle2;
            this.prawdopodobienstwo.HeaderText = "Prawdopodobieństwo";
            this.prawdopodobienstwo.MinimumWidth = 120;
            this.prawdopodobienstwo.Name = "prawdopodobienstwo";
            this.prawdopodobienstwo.Width = 120;
            // 
            // kodHuffmana
            // 
            this.kodHuffmana.HeaderText = "Kod Huffmana";
            this.kodHuffmana.MinimumWidth = 150;
            this.kodHuffmana.Name = "kodHuffmana";
            this.kodHuffmana.Width = 250;
            // 
            // zakres_od
            // 
            this.zakres_od.HeaderText = "Zakres od";
            this.zakres_od.MinimumWidth = 100;
            this.zakres_od.Name = "zakres_od";
            this.zakres_od.Width = 150;
            // 
            // zakres_do
            // 
            this.zakres_do.HeaderText = "Zakres do";
            this.zakres_do.MinimumWidth = 100;
            this.zakres_do.Name = "zakres_do";
            this.zakres_do.Width = 150;
            // 
            // btn_huffman
            // 
            this.btn_huffman.Location = new System.Drawing.Point(524, 12);
            this.btn_huffman.Name = "btn_huffman";
            this.btn_huffman.Size = new System.Drawing.Size(250, 23);
            this.btn_huffman.TabIndex = 3;
            this.btn_huffman.Text = "3 :: Kompresja Hufmana";
            this.btn_huffman.UseVisualStyleBackColor = true;
            this.btn_huffman.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgv_arytmetyczne
            // 
            this.dgv_arytmetyczne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_arytmetyczne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.znak2,
            this.czestottliwosc2,
            this.prawdopodobienstwo2,
            this.zakres_od2,
            this.zakres_do2});
            this.dgv_arytmetyczne.Location = new System.Drawing.Point(780, 43);
            this.dgv_arytmetyczne.Name = "dgv_arytmetyczne";
            this.dgv_arytmetyczne.RowHeadersVisible = false;
            this.dgv_arytmetyczne.Size = new System.Drawing.Size(250, 246);
            this.dgv_arytmetyczne.TabIndex = 4;
            // 
            // znak2
            // 
            this.znak2.HeaderText = "Znak";
            this.znak2.Name = "znak2";
            this.znak2.ReadOnly = true;
            // 
            // czestottliwosc2
            // 
            this.czestottliwosc2.HeaderText = "Częstotliwość";
            this.czestottliwosc2.Name = "czestottliwosc2";
            this.czestottliwosc2.ReadOnly = true;
            // 
            // prawdopodobienstwo2
            // 
            this.prawdopodobienstwo2.HeaderText = "Prawdopodobieństwo";
            this.prawdopodobienstwo2.Name = "prawdopodobienstwo2";
            this.prawdopodobienstwo2.ReadOnly = true;
            // 
            // zakres_od2
            // 
            this.zakres_od2.HeaderText = "Zakres od";
            this.zakres_od2.Name = "zakres_od2";
            this.zakres_od2.ReadOnly = true;
            // 
            // zakres_do2
            // 
            this.zakres_do2.HeaderText = "Zakres do";
            this.zakres_do2.Name = "zakres_do2";
            this.zakres_do2.ReadOnly = true;
            // 
            // btn_policz
            // 
            this.btn_policz.Location = new System.Drawing.Point(268, 14);
            this.btn_policz.Name = "btn_policz";
            this.btn_policz.Size = new System.Drawing.Size(250, 23);
            this.btn_policz.TabIndex = 5;
            this.btn_policz.Text = "2 :: Policz";
            this.btn_policz.UseVisualStyleBackColor = true;
            this.btn_policz.Click += new System.EventHandler(this.btn_policz_click);
            // 
            // tb_policz
            // 
            this.tb_policz.Location = new System.Drawing.Point(268, 295);
            this.tb_policz.MaxLength = 0;
            this.tb_policz.Multiline = true;
            this.tb_policz.Name = "tb_policz";
            this.tb_policz.Size = new System.Drawing.Size(250, 142);
            this.tb_policz.TabIndex = 6;
            // 
            // dgv_info
            // 
            this.dgv_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_info.Location = new System.Drawing.Point(12, 43);
            this.dgv_info.Name = "dgv_info";
            this.dgv_info.Size = new System.Drawing.Size(250, 394);
            this.dgv_info.TabIndex = 7;
            // 
            // dgv_policz
            // 
            this.dgv_policz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_policz.Location = new System.Drawing.Point(268, 43);
            this.dgv_policz.Name = "dgv_policz";
            this.dgv_policz.Size = new System.Drawing.Size(250, 246);
            this.dgv_policz.TabIndex = 8;
            // 
            // tb_huffman
            // 
            this.tb_huffman.Location = new System.Drawing.Point(524, 295);
            this.tb_huffman.MaxLength = 0;
            this.tb_huffman.Multiline = true;
            this.tb_huffman.Name = "tb_huffman";
            this.tb_huffman.Size = new System.Drawing.Size(250, 142);
            this.tb_huffman.TabIndex = 9;
            // 
            // tb_arytmetyczne
            // 
            this.tb_arytmetyczne.Location = new System.Drawing.Point(780, 295);
            this.tb_arytmetyczne.MaxLength = 0;
            this.tb_arytmetyczne.Multiline = true;
            this.tb_arytmetyczne.Name = "tb_arytmetyczne";
            this.tb_arytmetyczne.Size = new System.Drawing.Size(250, 142);
            this.tb_arytmetyczne.TabIndex = 10;
            // 
            // btn_arytmetyczna
            // 
            this.btn_arytmetyczna.Location = new System.Drawing.Point(781, 12);
            this.btn_arytmetyczna.Name = "btn_arytmetyczna";
            this.btn_arytmetyczna.Size = new System.Drawing.Size(249, 23);
            this.btn_arytmetyczna.TabIndex = 11;
            this.btn_arytmetyczna.Text = "4 :: Kompresja arytmetyczna";
            this.btn_arytmetyczna.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 453);
            this.Controls.Add(this.btn_arytmetyczna);
            this.Controls.Add(this.tb_arytmetyczne);
            this.Controls.Add(this.tb_huffman);
            this.Controls.Add(this.dgv_policz);
            this.Controls.Add(this.dgv_info);
            this.Controls.Add(this.tb_policz);
            this.Controls.Add(this.btn_policz);
            this.Controls.Add(this.dgv_arytmetyczne);
            this.Controls.Add(this.btn_huffman);
            this.Controls.Add(this.dgv_huffman);
            this.Controls.Add(this.btn_otworz_plik);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_huffman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_arytmetyczne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_policz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_otworz_plik;
        private System.Windows.Forms.DataGridView dgv_huffman;
        private System.Windows.Forms.Button btn_huffman;
        private System.Windows.Forms.DataGridView dgv_arytmetyczne;
        private System.Windows.Forms.DataGridViewTextBoxColumn znak2;
        private System.Windows.Forms.DataGridViewTextBoxColumn czestottliwosc2;
        private System.Windows.Forms.DataGridViewTextBoxColumn prawdopodobienstwo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn zakres_od2;
        private System.Windows.Forms.DataGridViewTextBoxColumn zakres_do2;
        private System.Windows.Forms.Button btn_policz;
        private System.Windows.Forms.DataGridViewTextBoxColumn znak;
        private System.Windows.Forms.DataGridViewTextBoxColumn czestotliwosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn prawdopodobienstwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodHuffmana;
        private System.Windows.Forms.DataGridViewTextBoxColumn zakres_od;
        private System.Windows.Forms.DataGridViewTextBoxColumn zakres_do;
        private System.Windows.Forms.TextBox tb_policz;
        private System.Windows.Forms.DataGridView dgv_info;
        private System.Windows.Forms.DataGridView dgv_policz;
        private System.Windows.Forms.TextBox tb_huffman;
        private System.Windows.Forms.TextBox tb_arytmetyczne;
        private System.Windows.Forms.Button btn_arytmetyczna;
    }
}

