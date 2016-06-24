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
            this.button1 = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.znak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czestotliwosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prawdopodobienstwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodHuffmana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.kodHuffmana});
            this.dataGridView1.Location = new System.Drawing.Point(278, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(549, 443);
            this.dataGridView1.TabIndex = 2;
            // 
            // znak
            // 
            this.znak.HeaderText = "Znak";
            this.znak.Name = "znak";
            this.znak.Width = 50;
            // 
            // czestotliwosc
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.czestotliwosc.DefaultCellStyle = dataGridViewCellStyle1;
            this.czestotliwosc.HeaderText = "Częstotliwość";
            this.czestotliwosc.Name = "czestotliwosc";
            // 
            // prawdopodobienstwo
            // 
            dataGridViewCellStyle2.Format = "N6";
            dataGridViewCellStyle2.NullValue = null;
            this.prawdopodobienstwo.DefaultCellStyle = dataGridViewCellStyle2;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 498);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.info);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox info;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn znak;
        private System.Windows.Forms.DataGridViewTextBoxColumn czestotliwosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn prawdopodobienstwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodHuffmana;
    }
}

