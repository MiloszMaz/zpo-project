using System.Runtime.CompilerServices;

namespace projekt
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
            download_data = new Button();
            dataGridViewRates = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRates).BeginInit();
            SuspendLayout();
            // 
            // download_data
            // 
            download_data.Location = new Point(26, 27);
            download_data.Name = "download_data";
            download_data.Size = new Size(108, 23);
            download_data.TabIndex = 0;
            download_data.Text = "Pobierz dane";
            download_data.UseVisualStyleBackColor = true;
            download_data.Click += button1_Click;
            // 
            // dataGridViewRates
            // 
            dataGridViewRates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRates.Location = new Point(243, 27);
            dataGridViewRates.Name = "dataGridViewRates";
            dataGridViewRates.Size = new Size(381, 411);
            dataGridViewRates.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(630, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(630, 27);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 3;
            label1.Text = "Wyszukaj po kodzie";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(26, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += selectRate;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(26, 140);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 5;
            listBox1.SelectedIndexChanged += selectRate;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(26, 252);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 94);
            listBox2.TabIndex = 6;
            listBox2.SelectedIndexChanged += selectRate;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 372);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 7;
            label2.Text = "Kwota:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 84);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 8;
            label3.Text = "Przelicz kwotę";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 372);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridViewRates);
            Controls.Add(download_data);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRates).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void changeColumn()
        {
            dataGridViewRates.AutoGenerateColumns = false;
            dataGridViewRates.Columns.Clear();

            dataGridViewRates.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Currency",
                HeaderText = "Waluta"
            });
            dataGridViewRates.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Code",
                HeaderText = "Kod"
            });
            dataGridViewRates.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Mid",
                HeaderText = "Kurs (PLN)"
            });
        }

        #endregion

        private Button download_data;
        private DataGridView dataGridViewRates;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
