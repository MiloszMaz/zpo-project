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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewRates);
            Controls.Add(download_data);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRates).EndInit();
            ResumeLayout(false);
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
    }
}
