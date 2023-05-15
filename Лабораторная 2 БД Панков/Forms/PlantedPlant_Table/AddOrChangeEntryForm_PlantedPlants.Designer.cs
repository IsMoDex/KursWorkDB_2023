namespace Лабораторная_2_БД_Панков.Forms
{
    partial class AddOrChangeEntryForm_PlantedPlants
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
            this.NotDeadDataCheckBox = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.AddOrChangeEntryButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.дата_гибели_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_посадки_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.номер_в_каталоге_comboBox = new System.Windows.Forms.ComboBox();
            this.код_участка_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.условия_ухода_и_содержания_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ImportImageButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.стоимность_саженца_numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.стоимность_саженца_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NotDeadDataCheckBox
            // 
            this.NotDeadDataCheckBox.AutoSize = true;
            this.NotDeadDataCheckBox.Location = new System.Drawing.Point(16, 325);
            this.NotDeadDataCheckBox.Name = "NotDeadDataCheckBox";
            this.NotDeadDataCheckBox.Size = new System.Drawing.Size(209, 20);
            this.NotDeadDataCheckBox.TabIndex = 114;
            this.NotDeadDataCheckBox.Text = "Не выставлять дату гибели";
            this.NotDeadDataCheckBox.UseVisualStyleBackColor = true;
            this.NotDeadDataCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(381, 523);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 38);
            this.button2.TabIndex = 113;
            this.button2.Text = "На главную";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddOrChangeEntryButton
            // 
            this.AddOrChangeEntryButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOrChangeEntryButton.Location = new System.Drawing.Point(246, 523);
            this.AddOrChangeEntryButton.Name = "AddOrChangeEntryButton";
            this.AddOrChangeEntryButton.Size = new System.Drawing.Size(129, 38);
            this.AddOrChangeEntryButton.TabIndex = 112;
            this.AddOrChangeEntryButton.Text = "Добавить";
            this.AddOrChangeEntryButton.UseVisualStyleBackColor = true;
            this.AddOrChangeEntryButton.Click += new System.EventHandler(this.AddOrChangeEntryButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(280, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 242);
            this.pictureBox1.TabIndex = 111;
            this.pictureBox1.TabStop = false;
            // 
            // дата_гибели_dateTimePicker
            // 
            this.дата_гибели_dateTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.дата_гибели_dateTimePicker.Location = new System.Drawing.Point(14, 289);
            this.дата_гибели_dateTimePicker.Name = "дата_гибели_dateTimePicker";
            this.дата_гибели_dateTimePicker.Size = new System.Drawing.Size(243, 30);
            this.дата_гибели_dateTimePicker.TabIndex = 110;
            // 
            // дата_посадки_dateTimePicker
            // 
            this.дата_посадки_dateTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.дата_посадки_dateTimePicker.Location = new System.Drawing.Point(14, 222);
            this.дата_посадки_dateTimePicker.Name = "дата_посадки_dateTimePicker";
            this.дата_посадки_dateTimePicker.Size = new System.Drawing.Size(243, 30);
            this.дата_посадки_dateTimePicker.TabIndex = 109;
            // 
            // номер_в_каталоге_comboBox
            // 
            this.номер_в_каталоге_comboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.номер_в_каталоге_comboBox.FormattingEnabled = true;
            this.номер_в_каталоге_comboBox.Location = new System.Drawing.Point(16, 97);
            this.номер_в_каталоге_comboBox.Name = "номер_в_каталоге_comboBox";
            this.номер_в_каталоге_comboBox.Size = new System.Drawing.Size(243, 30);
            this.номер_в_каталоге_comboBox.TabIndex = 108;
            // 
            // код_участка_comboBox
            // 
            this.код_участка_comboBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.код_участка_comboBox.FormattingEnabled = true;
            this.код_участка_comboBox.Location = new System.Drawing.Point(16, 36);
            this.код_участка_comboBox.Name = "код_участка_comboBox";
            this.код_участка_comboBox.Size = new System.Drawing.Size(243, 30);
            this.код_участка_comboBox.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 22);
            this.label1.TabIndex = 106;
            this.label1.Text = "Стоимость саженца";
            // 
            // условия_ухода_и_содержания_textBox
            // 
            this.условия_ухода_и_содержания_textBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.условия_ухода_и_содержания_textBox.Location = new System.Drawing.Point(10, 373);
            this.условия_ухода_и_содержания_textBox.Multiline = true;
            this.условия_ухода_и_содержания_textBox.Name = "условия_ухода_и_содержания_textBox";
            this.условия_ухода_и_содержания_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.условия_ухода_и_содержания_textBox.Size = new System.Drawing.Size(513, 144);
            this.условия_ухода_и_содержания_textBox.TabIndex = 104;
            this.условия_ухода_и_содержания_textBox.WordWrap = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(5, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 22);
            this.label7.TabIndex = 103;
            this.label7.Text = "Условия ухода и содержания";
            // 
            // ImportImageButton
            // 
            this.ImportImageButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ImportImageButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ImportImageButton.Location = new System.Drawing.Point(280, 284);
            this.ImportImageButton.Name = "ImportImageButton";
            this.ImportImageButton.Size = new System.Drawing.Size(247, 35);
            this.ImportImageButton.TabIndex = 102;
            this.ImportImageButton.Text = "Загрузить (не обяз.)";
            this.ImportImageButton.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 22);
            this.label6.TabIndex = 101;
            this.label6.Text = "Дата гибели(не обязательно)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(11, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 22);
            this.label5.TabIndex = 100;
            this.label5.Text = "Дата посадки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 22);
            this.label4.TabIndex = 99;
            this.label4.Text = "Номер в каталоге";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 98;
            this.label3.Text = "Код участка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(276, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 22);
            this.label2.TabIndex = 97;
            this.label2.Text = "Фото растения";
            // 
            // стоимность_саженца_numericUpDown
            // 
            this.стоимность_саженца_numericUpDown.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.стоимность_саженца_numericUpDown.Location = new System.Drawing.Point(16, 164);
            this.стоимность_саженца_numericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.стоимность_саженца_numericUpDown.Name = "стоимность_саженца_numericUpDown";
            this.стоимность_саженца_numericUpDown.Size = new System.Drawing.Size(243, 30);
            this.стоимность_саженца_numericUpDown.TabIndex = 115;
            // 
            // AddOrChangeEntryForm_PlantedPlants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 568);
            this.Controls.Add(this.стоимность_саженца_numericUpDown);
            this.Controls.Add(this.NotDeadDataCheckBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddOrChangeEntryButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.дата_гибели_dateTimePicker);
            this.Controls.Add(this.дата_посадки_dateTimePicker);
            this.Controls.Add(this.номер_в_каталоге_comboBox);
            this.Controls.Add(this.код_участка_comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.условия_ухода_и_содержания_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ImportImageButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.MinimumSize = new System.Drawing.Size(555, 615);
            this.Name = "AddOrChangeEntryForm_PlantedPlants";
            this.Text = "Добавление записей в \"Растения\"";
            this.Load += new System.EventHandler(this.AddEntryForm_PlantedPlants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.стоимность_саженца_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox NotDeadDataCheckBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AddOrChangeEntryButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker дата_гибели_dateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_посадки_dateTimePicker;
        private System.Windows.Forms.ComboBox номер_в_каталоге_comboBox;
        private System.Windows.Forms.ComboBox код_участка_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox условия_ухода_и_содержания_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ImportImageButton;
        private System.Windows.Forms.NumericUpDown стоимность_саженца_numericUpDown;
    }
}