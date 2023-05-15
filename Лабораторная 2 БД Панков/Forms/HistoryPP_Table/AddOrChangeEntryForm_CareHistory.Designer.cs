namespace Лабораторная_2_БД_Панков.Forms.HistoryPP_Table
{
    partial class AddOrChangeEntryForm_CareHistory
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
            this.AddOrChangeEntryButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.код_растения_comboBox = new System.Windows.Forms.ComboBox();
            this.название_средства_comboBox = new System.Windows.Forms.ComboBox();
            this.фио_сотрудника_comboBox = new System.Windows.Forms.ComboBox();
            this.количество_упоковок_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.дата_обработки_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.количество_упоковок_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // AddOrChangeEntryButton
            // 
            this.AddOrChangeEntryButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOrChangeEntryButton.Location = new System.Drawing.Point(271, 151);
            this.AddOrChangeEntryButton.Name = "AddOrChangeEntryButton";
            this.AddOrChangeEntryButton.Size = new System.Drawing.Size(129, 38);
            this.AddOrChangeEntryButton.TabIndex = 34;
            this.AddOrChangeEntryButton.Text = "Добавить";
            this.AddOrChangeEntryButton.UseVisualStyleBackColor = true;
            this.AddOrChangeEntryButton.Click += new System.EventHandler(this.AddOrChangeEntryButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(14, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 22);
            this.label6.TabIndex = 32;
            this.label6.Text = "Количество упоковок";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(267, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 22);
            this.label5.TabIndex = 30;
            this.label5.Text = "ФИО сотрудника";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 22);
            this.label4.TabIndex = 28;
            this.label4.Text = "Дата обработки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "Код растения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(266, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "Названия средства";
            // 
            // код_растения_comboBox
            // 
            this.код_растения_comboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.код_растения_comboBox.FormattingEnabled = true;
            this.код_растения_comboBox.Location = new System.Drawing.Point(16, 38);
            this.код_растения_comboBox.Name = "код_растения_comboBox";
            this.код_растения_comboBox.Size = new System.Drawing.Size(243, 30);
            this.код_растения_comboBox.TabIndex = 108;
            // 
            // название_средства_comboBox
            // 
            this.название_средства_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.название_средства_comboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.название_средства_comboBox.FormattingEnabled = true;
            this.название_средства_comboBox.Location = new System.Drawing.Point(270, 38);
            this.название_средства_comboBox.Name = "название_средства_comboBox";
            this.название_средства_comboBox.Size = new System.Drawing.Size(280, 30);
            this.название_средства_comboBox.TabIndex = 109;
            // 
            // фио_сотрудника_comboBox
            // 
            this.фио_сотрудника_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.фио_сотрудника_comboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.фио_сотрудника_comboBox.FormattingEnabled = true;
            this.фио_сотрудника_comboBox.Location = new System.Drawing.Point(270, 101);
            this.фио_сотрудника_comboBox.Name = "фио_сотрудника_comboBox";
            this.фио_сотрудника_comboBox.Size = new System.Drawing.Size(280, 30);
            this.фио_сотрудника_comboBox.TabIndex = 110;
            // 
            // количество_упоковок_numericUpDown
            // 
            this.количество_упоковок_numericUpDown.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.количество_упоковок_numericUpDown.Location = new System.Drawing.Point(16, 101);
            this.количество_упоковок_numericUpDown.Name = "количество_упоковок_numericUpDown";
            this.количество_упоковок_numericUpDown.Size = new System.Drawing.Size(244, 30);
            this.количество_упоковок_numericUpDown.TabIndex = 111;
            // 
            // дата_обработки_dateTimePicker
            // 
            this.дата_обработки_dateTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.дата_обработки_dateTimePicker.Location = new System.Drawing.Point(16, 159);
            this.дата_обработки_dateTimePicker.Name = "дата_обработки_dateTimePicker";
            this.дата_обработки_dateTimePicker.Size = new System.Drawing.Size(243, 30);
            this.дата_обработки_dateTimePicker.TabIndex = 112;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(406, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 38);
            this.button1.TabIndex = 114;
            this.button1.Text = "На главную";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddOrChangeEntryForm_CareHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 203);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.дата_обработки_dateTimePicker);
            this.Controls.Add(this.количество_упоковок_numericUpDown);
            this.Controls.Add(this.фио_сотрудника_comboBox);
            this.Controls.Add(this.название_средства_comboBox);
            this.Controls.Add(this.код_растения_comboBox);
            this.Controls.Add(this.AddOrChangeEntryButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MinimumSize = new System.Drawing.Size(580, 250);
            this.Name = "AddOrChangeEntryForm_CareHistory";
            this.Text = "Добавление записей в \"История обработки растений\"";
            this.Load += new System.EventHandler(this.AddEntryForm_HistoryPP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.количество_упоковок_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddOrChangeEntryButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox код_растения_comboBox;
        private System.Windows.Forms.ComboBox название_средства_comboBox;
        private System.Windows.Forms.ComboBox фио_сотрудника_comboBox;
        private System.Windows.Forms.NumericUpDown количество_упоковок_numericUpDown;
        private System.Windows.Forms.DateTimePicker дата_обработки_dateTimePicker;
        private System.Windows.Forms.Button button1;
    }
}