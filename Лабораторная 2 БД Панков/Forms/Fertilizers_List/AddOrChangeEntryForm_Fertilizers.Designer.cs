namespace Лабораторная_2_БД_Панков.Forms
{
    partial class AddOrChangeEntryForm_TreatmentСP
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
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.название_средства_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddOrChangeEntryButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.стоимость_средства_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.единица_измерения_средства_comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.стоимость_средства_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 22);
            this.label2.TabIndex = 71;
            this.label2.Text = "Стоимость средтсва";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 22);
            this.label7.TabIndex = 67;
            this.label7.Text = "Название средства";
            // 
            // название_средства_textBox
            // 
            this.название_средства_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.название_средства_textBox.Location = new System.Drawing.Point(12, 34);
            this.название_средства_textBox.Name = "название_средства_textBox";
            this.название_средства_textBox.Size = new System.Drawing.Size(277, 30);
            this.название_средства_textBox.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 22);
            this.label3.TabIndex = 69;
            this.label3.Text = "Еденица измерения средства";
            // 
            // AddOrChangeEntryButton
            // 
            this.AddOrChangeEntryButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOrChangeEntryButton.Location = new System.Drawing.Point(12, 208);
            this.AddOrChangeEntryButton.Name = "AddOrChangeEntryButton";
            this.AddOrChangeEntryButton.Size = new System.Drawing.Size(129, 38);
            this.AddOrChangeEntryButton.TabIndex = 76;
            this.AddOrChangeEntryButton.Text = "Добавить";
            this.AddOrChangeEntryButton.UseVisualStyleBackColor = true;
            this.AddOrChangeEntryButton.Click += new System.EventHandler(this.AddOrChangeEntryButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(147, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 38);
            this.button2.TabIndex = 77;
            this.button2.Text = "На главную";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // стоимость_средства_numericUpDown
            // 
            this.стоимость_средства_numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.стоимость_средства_numericUpDown.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.стоимость_средства_numericUpDown.Location = new System.Drawing.Point(12, 169);
            this.стоимость_средства_numericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.стоимость_средства_numericUpDown.Name = "стоимость_средства_numericUpDown";
            this.стоимость_средства_numericUpDown.Size = new System.Drawing.Size(277, 30);
            this.стоимость_средства_numericUpDown.TabIndex = 115;
            // 
            // единица_измерения_средства_comboBox
            // 
            this.единица_измерения_средства_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.единица_измерения_средства_comboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.единица_измерения_средства_comboBox.FormattingEnabled = true;
            this.единица_измерения_средства_comboBox.Location = new System.Drawing.Point(12, 103);
            this.единица_измерения_средства_comboBox.Name = "единица_измерения_средства_comboBox";
            this.единица_измерения_средства_comboBox.Size = new System.Drawing.Size(277, 30);
            this.единица_измерения_средства_comboBox.TabIndex = 116;
            // 
            // AddOrChangeEntryForm_TreatmentСP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 258);
            this.Controls.Add(this.единица_измерения_средства_comboBox);
            this.Controls.Add(this.стоимость_средства_numericUpDown);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddOrChangeEntryButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.название_средства_textBox);
            this.Controls.Add(this.label3);
            this.MinimumSize = new System.Drawing.Size(320, 305);
            this.Name = "AddOrChangeEntryForm_TreatmentСP";
            this.Text = "Добавление записей в \"Средства ухода\"";
            this.Load += new System.EventHandler(this.AddEntryFormForm_HistoryPP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.стоимость_средства_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox название_средства_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddOrChangeEntryButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown стоимость_средства_numericUpDown;
        private System.Windows.Forms.ComboBox единица_измерения_средства_comboBox;
    }
}