namespace Лабораторная_2_БД_Панков.Forms.GardenPlots_Table
{
    partial class AddOrChangeEntryForm_GardenPlots
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
            this.регистрационный_номер_сада_comboBox = new System.Windows.Forms.ComboBox();
            this.номер_участка_в_саду_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.AddOrChangeEntryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.номер_участка_в_саду_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // регистрационный_номер_сада_comboBox
            // 
            this.регистрационный_номер_сада_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.регистрационный_номер_сада_comboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.регистрационный_номер_сада_comboBox.FormattingEnabled = true;
            this.регистрационный_номер_сада_comboBox.Location = new System.Drawing.Point(12, 104);
            this.регистрационный_номер_сада_comboBox.Name = "регистрационный_номер_сада_comboBox";
            this.регистрационный_номер_сада_comboBox.Size = new System.Drawing.Size(243, 30);
            this.регистрационный_номер_сада_comboBox.TabIndex = 122;
            // 
            // номер_участка_в_саду_numericUpDown
            // 
            this.номер_участка_в_саду_numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.номер_участка_в_саду_numericUpDown.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.номер_участка_в_саду_numericUpDown.Location = new System.Drawing.Point(16, 34);
            this.номер_участка_в_саду_numericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.номер_участка_в_саду_numericUpDown.Name = "номер_участка_в_саду_numericUpDown";
            this.номер_участка_в_саду_numericUpDown.Size = new System.Drawing.Size(239, 30);
            this.номер_участка_в_саду_numericUpDown.TabIndex = 121;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 22);
            this.label5.TabIndex = 117;
            this.label5.Text = "Номер участка в саду";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 22);
            this.label6.TabIndex = 118;
            this.label6.Text = "Номер сада";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(147, 140);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 38);
            this.button4.TabIndex = 120;
            this.button4.Text = "Отмена";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // AddOrChangeEntryButton
            // 
            this.AddOrChangeEntryButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOrChangeEntryButton.Location = new System.Drawing.Point(12, 140);
            this.AddOrChangeEntryButton.Name = "AddOrChangeEntryButton";
            this.AddOrChangeEntryButton.Size = new System.Drawing.Size(129, 38);
            this.AddOrChangeEntryButton.TabIndex = 119;
            this.AddOrChangeEntryButton.Text = "Применить";
            this.AddOrChangeEntryButton.UseVisualStyleBackColor = true;
            this.AddOrChangeEntryButton.Click += new System.EventHandler(this.AddOrChangeEntryButton_Click);
            // 
            // AddOrChangeEntryForm_GardenPlots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 188);
            this.Controls.Add(this.регистрационный_номер_сада_comboBox);
            this.Controls.Add(this.номер_участка_в_саду_numericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.AddOrChangeEntryButton);
            this.MinimumSize = new System.Drawing.Size(285, 235);
            this.Name = "AddOrChangeEntryForm_GardenPlots";
            this.Text = "AddOrChangeEntryForm_GardenPlots";
            this.Load += new System.EventHandler(this.AddOrChangeEntryForm_GardenPlots_Load);
            ((System.ComponentModel.ISupportInitialize)(this.номер_участка_в_саду_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox регистрационный_номер_сада_comboBox;
        private System.Windows.Forms.NumericUpDown номер_участка_в_саду_numericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button AddOrChangeEntryButton;
    }
}