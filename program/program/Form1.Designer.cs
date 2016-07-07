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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.znak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czestotliwosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prawdopodobienstwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodHuffmana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakres_od = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakres_do = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.znak2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czestottliwosc2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prawdopodobienstwo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakres_od2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakres_do2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Otwórz plik...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(13, 43);
            this.info.Multiline = true;
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(259, 206);
            this.info.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.znak,
            this.czestotliwosc,
            this.prawdopodobienstwo,
            this.kodHuffmana,
            this.zakres_od,
            this.zakres_do});
            this.dataGridView1.Location = new System.Drawing.Point(278, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(816, 443);
            this.dataGridView1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // znak
            // 
            this.znak.HeaderText = "Znak";
            this.znak.Name = "znak";
            this.znak.Width = 50;
            // 
            // czestotliwosc
            // 
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.czestotliwosc.DefaultCellStyle = dataGridViewCellStyle5;
            this.czestotliwosc.HeaderText = "Częstotliwość";
            this.czestotliwosc.Name = "czestotliwosc";
            // 
            // prawdopodobienstwo
            // 
            dataGridViewCellStyle6.Format = "N6";
            dataGridViewCellStyle6.NullValue = null;
            this.prawdopodobienstwo.DefaultCellStyle = dataGridViewCellStyle6;
            this.prawdopodobienstwo.HeaderText = "Prawdopodobieństwo";
            this.prawdopodobienstwo.Name = "prawdopodobienstwo";
            this.prawdopodobienstwo.Width = 120;
            // 
            // kodHuffmana
            // 
            this.kodHuffmana.HeaderText = "Kod Huffmana";
            this.kodHuffmana.Name = "kodHuffmana";
            this.kodHuffmana.Width = 250;
            // 
            // zakres_od
            // 
            this.zakres_od.HeaderText = "Zakres od";
            this.zakres_od.Name = "zakres_od";
            this.zakres_od.Width = 150;
            // 
            // zakres_do
            // 
            this.zakres_do.HeaderText = "Zakres do";
            this.zakres_do.Name = "zakres_do";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.znak2,
            this.czestottliwosc2,
            this.prawdopodobienstwo2,
            this.zakres_od2,
            this.zakres_do2});
            this.dataGridView2.Location = new System.Drawing.Point(1101, 43);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(588, 563);
            this.dataGridView2.TabIndex = 4;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1716, 817);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.info);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox info;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn znak;
        private System.Windows.Forms.DataGridViewTextBoxColumn czestotliwosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn prawdopodobienstwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodHuffmana;
        private System.Windows.Forms.DataGridViewTextBoxColumn zakres_od;
        private System.Windows.Forms.DataGridViewTextBoxColumn zakres_do;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn znak2;
        private System.Windows.Forms.DataGridViewTextBoxColumn czestottliwosc2;
        private System.Windows.Forms.DataGridViewTextBoxColumn prawdopodobienstwo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn zakres_od2;
        private System.Windows.Forms.DataGridViewTextBoxColumn zakres_do2;
    }
}

